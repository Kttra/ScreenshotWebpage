namespace webView2_Starter_Template
{
    partial class webView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnCapture = new System.Windows.Forms.Button();
            this.myWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnCustom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myWebView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddressBox
            // 
            this.AddressBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressBox.Location = new System.Drawing.Point(12, 12);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(626, 23);
            this.AddressBox.TabIndex = 1;
            this.AddressBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressBox_KeyDown);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfirm.Location = new System.Drawing.Point(725, 11);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirm.TabIndex = 2;
            this.BtnConfirm.Text = "Go";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnCapture
            // 
            this.BtnCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCapture.Location = new System.Drawing.Point(644, 11);
            this.BtnCapture.Name = "BtnCapture";
            this.BtnCapture.Size = new System.Drawing.Size(75, 23);
            this.BtnCapture.TabIndex = 3;
            this.BtnCapture.Text = "Capture";
            this.BtnCapture.UseVisualStyleBackColor = true;
            this.BtnCapture.Click += new System.EventHandler(this.BtnCapture_Click);
            // 
            // myWebView
            // 
            this.myWebView.AllowExternalDrop = true;
            this.myWebView.CreationProperties = null;
            this.myWebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.myWebView.Location = new System.Drawing.Point(0, 67);
            this.myWebView.Name = "myWebView";
            this.myWebView.Size = new System.Drawing.Size(800, 383);
            this.myWebView.Source = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            this.myWebView.TabIndex = 0;
            this.myWebView.ZoomFactor = 1D;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(91, 40);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(15, 44);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(75, 15);
            this.labelProgress.TabIndex = 5;
            this.labelProgress.Text = "Progress: 0/0";
            // 
            // BtnSettings
            // 
            this.BtnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSettings.Location = new System.Drawing.Point(725, 40);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(75, 23);
            this.BtnSettings.TabIndex = 6;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnCustom
            // 
            this.BtnCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCustom.Location = new System.Drawing.Point(644, 40);
            this.BtnCustom.Name = "BtnCustom";
            this.BtnCustom.Size = new System.Drawing.Size(75, 23);
            this.BtnCustom.TabIndex = 7;
            this.BtnCustom.Text = "Custom";
            this.BtnCustom.UseVisualStyleBackColor = true;
            // 
            // webView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCustom);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.myWebView);
            this.Controls.Add(this.BtnCapture);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.AddressBox);
            this.Name = "webView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webpage Screenshot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.myWebView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox AddressBox;
        private Button BtnConfirm;
        private Button BtnCapture;
        private Microsoft.Web.WebView2.WinForms.WebView2 myWebView;
        private Panel panel1;
        private Button button1;
        private ProgressBar progressBar1;
        private Label labelProgress;
        private Button BtnSettings;
        private Button BtnCustom;
    }
}