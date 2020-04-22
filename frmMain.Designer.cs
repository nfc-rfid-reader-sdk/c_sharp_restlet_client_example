namespace x509_verifier_rest_client
{
    partial class frmMain
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
            this.btnX509Verify = new System.Windows.Forms.Button();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.webDisplay = new System.Windows.Forms.WebBrowser();
            this.btnPdfVerify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnX509Verify
            // 
            this.btnX509Verify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX509Verify.Location = new System.Drawing.Point(770, 694);
            this.btnX509Verify.Name = "btnX509Verify";
            this.btnX509Verify.Size = new System.Drawing.Size(226, 23);
            this.btnX509Verify.TabIndex = 5;
            this.btnX509Verify.Text = "Verify X.509 Certificate";
            this.btnX509Verify.UseVisualStyleBackColor = true;
            this.btnX509Verify.Click += new System.EventHandler(this.btnX509Verify_Click);
            // 
            // tbStatus
            // 
            this.tbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbStatus.Location = new System.Drawing.Point(65, 667);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(679, 20);
            this.tbStatus.TabIndex = 3;
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbStatus.Location = new System.Drawing.Point(12, 670);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(47, 13);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Status:";
            // 
            // webDisplay
            // 
            this.webDisplay.AllowNavigation = false;
            this.webDisplay.AllowWebBrowserDrop = false;
            this.webDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webDisplay.IsWebBrowserContextMenuEnabled = false;
            this.webDisplay.Location = new System.Drawing.Point(13, 25);
            this.webDisplay.MinimumSize = new System.Drawing.Size(20, 20);
            this.webDisplay.Name = "webDisplay";
            this.webDisplay.Size = new System.Drawing.Size(983, 626);
            this.webDisplay.TabIndex = 1;
            this.webDisplay.WebBrowserShortcutsEnabled = false;
            // 
            // btnPdfVerify
            // 
            this.btnPdfVerify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPdfVerify.Location = new System.Drawing.Point(770, 665);
            this.btnPdfVerify.Name = "btnPdfVerify";
            this.btnPdfVerify.Size = new System.Drawing.Size(226, 23);
            this.btnPdfVerify.TabIndex = 4;
            this.btnPdfVerify.Text = "Verify PDF";
            this.btnPdfVerify.UseVisualStyleBackColor = true;
            this.btnPdfVerify.Click += new System.EventHandler(this.btnPdfVerify_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verification log:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPdfVerify);
            this.Controls.Add(this.webDisplay);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.btnX509Verify);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "X.509 Verifier (C# REST Client Example)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnX509Verify;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.WebBrowser webDisplay;
        private System.Windows.Forms.Button btnPdfVerify;
        private System.Windows.Forms.Label label1;
    }
}

