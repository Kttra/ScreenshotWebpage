namespace webView2_Starter_Template
{
    partial class Form_Settings
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
            this.labelPicType = new System.Windows.Forms.Label();
            this.labelPicName = new System.Windows.Forms.Label();
            this.comboBoxPicType = new System.Windows.Forms.ComboBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.labelFolder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPicType
            // 
            this.labelPicType.AutoSize = true;
            this.labelPicType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPicType.Location = new System.Drawing.Point(12, 15);
            this.labelPicType.Name = "labelPicType";
            this.labelPicType.Size = new System.Drawing.Size(134, 24);
            this.labelPicType.TabIndex = 0;
            this.labelPicType.Text = "Picture Type:";
            // 
            // labelPicName
            // 
            this.labelPicName.AutoSize = true;
            this.labelPicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPicName.Location = new System.Drawing.Point(12, 51);
            this.labelPicName.Name = "labelPicName";
            this.labelPicName.Size = new System.Drawing.Size(109, 24);
            this.labelPicName.TabIndex = 1;
            this.labelPicName.Text = "File name:";
            // 
            // comboBoxPicType
            // 
            this.comboBoxPicType.FormattingEnabled = true;
            this.comboBoxPicType.Items.AddRange(new object[] {
            "PNG",
            "JPEG",
            "BMP"});
            this.comboBoxPicType.Location = new System.Drawing.Point(152, 15);
            this.comboBoxPicType.Name = "comboBoxPicType";
            this.comboBoxPicType.Size = new System.Drawing.Size(172, 23);
            this.comboBoxPicType.TabIndex = 2;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(152, 52);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(172, 23);
            this.textBoxFileName.TabIndex = 3;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(144, 125);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirm.TabIndex = 4;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Location = new System.Drawing.Point(152, 88);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(172, 23);
            this.textBoxFolder.TabIndex = 6;
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFolder.Location = new System.Drawing.Point(12, 87);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(135, 24);
            this.labelFolder.TabIndex = 5;
            this.labelFolder.Text = "Folder name:";
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 156);
            this.Controls.Add(this.textBoxFolder);
            this.Controls.Add(this.labelFolder);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.comboBoxPicType);
            this.Controls.Add(this.labelPicName);
            this.Controls.Add(this.labelPicType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form_Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPicType;
        private Label labelPicName;
        private TextBox textBoxFileName;
        private Button BtnConfirm;
        private ComboBox comboBoxPicType;
        private TextBox textBoxFolder;
        private Label labelFolder;
    }
}