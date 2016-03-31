namespace dataimport
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstMaster = new System.Windows.Forms.ListBox();
            this.lstSource = new System.Windows.Forms.ListBox();
            this.txtMaster = new System.Windows.Forms.TextBox();
            this.btnBrowseMaster = new System.Windows.Forms.Button();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.txtDelimit = new System.Windows.Forms.TextBox();
            this.txtSeparator = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.btnLoadTemplate = new System.Windows.Forms.Button();
            this.btnLoadDefaultTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMaster
            // 
            this.lstMaster.FormattingEnabled = true;
            this.lstMaster.Location = new System.Drawing.Point(12, 103);
            this.lstMaster.Name = "lstMaster";
            this.lstMaster.Size = new System.Drawing.Size(348, 160);
            this.lstMaster.TabIndex = 0;
            this.lstMaster.SelectedIndexChanged += new System.EventHandler(this.lstMaster_SelectedIndexChanged);
            // 
            // lstSource
            // 
            this.lstSource.FormattingEnabled = true;
            this.lstSource.Location = new System.Drawing.Point(366, 103);
            this.lstSource.Name = "lstSource";
            this.lstSource.Size = new System.Drawing.Size(168, 160);
            this.lstSource.TabIndex = 1;
            this.lstSource.SelectedIndexChanged += new System.EventHandler(this.lstSource_SelectedIndexChanged);
            // 
            // txtMaster
            // 
            this.txtMaster.Location = new System.Drawing.Point(71, 15);
            this.txtMaster.Name = "txtMaster";
            this.txtMaster.Size = new System.Drawing.Size(365, 20);
            this.txtMaster.TabIndex = 2;
            this.txtMaster.TextChanged += new System.EventHandler(this.txtMaster_TextChanged);
            // 
            // btnBrowseMaster
            // 
            this.btnBrowseMaster.Location = new System.Drawing.Point(459, 12);
            this.btnBrowseMaster.Name = "btnBrowseMaster";
            this.btnBrowseMaster.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseMaster.TabIndex = 3;
            this.btnBrowseMaster.Text = "Browse";
            this.btnBrowseMaster.UseVisualStyleBackColor = true;
            this.btnBrowseMaster.Click += new System.EventHandler(this.btnBrowseMaster_Click);
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Location = new System.Drawing.Point(459, 41);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSource.TabIndex = 5;
            this.btnBrowseSource.Text = "Browse";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(71, 44);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(365, 20);
            this.txtSource.TabIndex = 4;
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // cbStyle
            // 
            this.cbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Items.AddRange(new object[] {
            "Column Style",
            "Row Mix Style"});
            this.cbStyle.Location = new System.Drawing.Point(71, 71);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(121, 21);
            this.cbStyle.TabIndex = 6;
            // 
            // txtDelimit
            // 
            this.txtDelimit.Location = new System.Drawing.Point(215, 72);
            this.txtDelimit.Name = "txtDelimit";
            this.txtDelimit.Size = new System.Drawing.Size(100, 20);
            this.txtDelimit.TabIndex = 7;
            // 
            // txtSeparator
            // 
            this.txtSeparator.Location = new System.Drawing.Point(346, 71);
            this.txtSeparator.Name = "txtSeparator";
            this.txtSeparator.Size = new System.Drawing.Size(100, 20);
            this.txtSeparator.TabIndex = 8;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(438, 282);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(96, 30);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "IMPORT";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Location = new System.Drawing.Point(12, 282);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(96, 30);
            this.btnSaveTemplate.TabIndex = 10;
            this.btnSaveTemplate.Text = "Save Template";
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            this.btnSaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // btnLoadTemplate
            // 
            this.btnLoadTemplate.Location = new System.Drawing.Point(114, 282);
            this.btnLoadTemplate.Name = "btnLoadTemplate";
            this.btnLoadTemplate.Size = new System.Drawing.Size(96, 30);
            this.btnLoadTemplate.TabIndex = 11;
            this.btnLoadTemplate.Text = "Load Template";
            this.btnLoadTemplate.UseVisualStyleBackColor = true;
            this.btnLoadTemplate.Click += new System.EventHandler(this.btnLoadTemplate_Click);
            // 
            // btnLoadDefaultTemplate
            // 
            this.btnLoadDefaultTemplate.Location = new System.Drawing.Point(216, 282);
            this.btnLoadDefaultTemplate.Name = "btnLoadDefaultTemplate";
            this.btnLoadDefaultTemplate.Size = new System.Drawing.Size(134, 30);
            this.btnLoadDefaultTemplate.TabIndex = 12;
            this.btnLoadDefaultTemplate.Text = "Load Default Template";
            this.btnLoadDefaultTemplate.UseVisualStyleBackColor = true;
            this.btnLoadDefaultTemplate.Click += new System.EventHandler(this.btnLoadDefaultTemplate_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 324);
            this.Controls.Add(this.btnLoadDefaultTemplate);
            this.Controls.Add(this.btnLoadTemplate);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtSeparator);
            this.Controls.Add(this.txtDelimit);
            this.Controls.Add(this.cbStyle);
            this.Controls.Add(this.btnBrowseSource);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnBrowseMaster);
            this.Controls.Add(this.txtMaster);
            this.Controls.Add(this.lstSource);
            this.Controls.Add(this.lstMaster);
            this.Name = "MainFrm";
            this.Text = "Data Import";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMaster;
        private System.Windows.Forms.ListBox lstSource;
        private System.Windows.Forms.TextBox txtMaster;
        private System.Windows.Forms.Button btnBrowseMaster;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.TextBox txtDelimit;
        private System.Windows.Forms.TextBox txtSeparator;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.Button btnLoadTemplate;
        private System.Windows.Forms.Button btnLoadDefaultTemplate;
    }
}

