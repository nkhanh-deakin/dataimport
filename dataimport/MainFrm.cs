using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;
using System.IO;
using System.Xml.Serialization;

namespace dataimport
{
    public partial class MainFrm : Form
    {
        string default_template_file = "template.txt";
        List<string> master = new List<string>();
        List<int> master_source = new List<int>();
        List<string> source = new List<string>();
        XmlSerializer s = new XmlSerializer(typeof(List<int>));
        SLDocument master_doc = null;

        public MainFrm()
        {
            InitializeComponent();
            cbStyle.SelectedIndex = 0;
            txtDelimit.Text = ",\t;";
        }

        private string selectFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                return dlg.FileName;
            return null;
        }

        private void btnBrowseMaster_Click(object sender, EventArgs e)
        {
            string filename = selectFile();
            if (filename == null)
                return;
            txtMaster.Text = filename;
            master_doc = new SLDocument(filename);
            master_doc.SelectWorksheet("results");

            int i = 1;

            lstMaster.Items.Clear();
            master.Clear();
            master_source.Clear();
            List<int> t2 = new List<int>();
            while (master_doc.GetCellValueAsString(1, i).Trim() != "")
            {
                string st = master_doc.GetCellValueAsString(1, i).Trim();
                lstMaster.Items.Add(st + " << ");
                master.Add(st);
                master_source.Add(-1);
                i++;
            }
        }

        StreamReader source_reader;
        private void readSourceFile()
        {
            source_reader = new StreamReader(txtSource.Text);
            string line = source_reader.ReadLine();
            if (cbStyle.SelectedIndex < 0)
                return;

            lstSource.Items.Clear();
            lstSource.Items.Add("(none)");
            source.Clear(); 
            if (cbStyle.SelectedIndex == 0)
            {
                source.AddRange(line.Split(txtDelimit.Text.ToCharArray()));
                for (int i = 0; i < source.Count; i++)
                {
                    lstSource.Items.Add(source[i]);
                }
            }
        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            string filename = selectFile();
            if (filename == null)
                return;
            txtSource.Text = filename;

            readSourceFile();
        }

        private void lstMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstMaster.SelectedIndex;
            if (index < 0)
                return;
            if (lstSource.Items.Count <= 0)
                return;
            lstSource.SelectedIndex = master_source[index] + 1;
        }

        private void lstSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index_source = lstSource.SelectedIndex;
            int index_master = lstMaster.SelectedIndex;
            if ((index_master < 0) || (index_source < 0))
                return;
            master_source[index_master] = index_source - 1;
            lstMaster.Items[index_master] = master[index_master] + " << "
               + ((index_source <= 0) ? "" : source[index_source - 1]);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            int iRow = 1;
            while (master_doc.GetCellValueAsString(iRow, 1).Trim() != "")
                iRow++;
            if (cbStyle.SelectedIndex == 0)
            {
                while (!source_reader.EndOfStream)
                {
                    string line = source_reader.ReadLine();
                    string[] data = line.Split(txtDelimit.Text.Trim().ToCharArray());
                    for (int i = 0; i < master.Count; i++)
                    {
                        int index_source = master_source[i];
                        string value = (index_source < 0) ? "" : data[index_source];
                        
                        master_doc.SetCellValueNumeric(iRow, i + 1, value);
                    }
                    iRow++;
                }
            }
            master_doc.Save();
        }

        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
                s.Serialize(new StreamWriter(dlg.FileName), master_source);
        }

        private void btnLoadTemplate_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                master_source = (List<int>)s.Deserialize(new StreamReader(dlg.FileName));
            }
        }

        private void btnLoadDefaultTemplate_Click(object sender, EventArgs e)
        {
            if(!File.Exists(default_template_file))
                return;
            master_source = (List<int>)s.Deserialize(new StreamReader(default_template_file));
        }
    }
}
