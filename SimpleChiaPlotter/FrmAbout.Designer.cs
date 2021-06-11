
namespace SimpleChiaPlotter
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.linkLabelAuthor = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuyMeACoffee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(18, 77);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(316, 26);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "A simple Chia Plotter GUI for using the commandline to build plots.\r\nI built this" +
    " for myself and then decided to release it open source.";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(25, 118);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(46, 13);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "GitHub: ";
            // 
            // linkLabelAuthor
            // 
            this.linkLabelAuthor.AutoSize = true;
            this.linkLabelAuthor.Location = new System.Drawing.Point(76, 117);
            this.linkLabelAuthor.Name = "linkLabelAuthor";
            this.linkLabelAuthor.Size = new System.Drawing.Size(241, 13);
            this.linkLabelAuthor.TabIndex = 2;
            this.linkLabelAuthor.TabStop = true;
            this.linkLabelAuthor.Text = "https://github.com/xTheJakalx/SimpleChiaPlotter";
            this.linkLabelAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAuthor_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simple Chia Plotter";
            // 
            // btnBuyMeACoffee
            // 
            this.btnBuyMeACoffee.AutoSize = true;
            this.btnBuyMeACoffee.BackgroundImage = global::SimpleChiaPlotter.Properties.Resources.BuyMeACoffee;
            this.btnBuyMeACoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuyMeACoffee.Location = new System.Drawing.Point(79, 154);
            this.btnBuyMeACoffee.Name = "btnBuyMeACoffee";
            this.btnBuyMeACoffee.Size = new System.Drawing.Size(199, 47);
            this.btnBuyMeACoffee.TabIndex = 32;
            this.btnBuyMeACoffee.UseVisualStyleBackColor = true;
            this.btnBuyMeACoffee.Click += new System.EventHandler(this.btnBuyMeACoffee_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Does this app help you out?\r\n";
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 203);
            this.Controls.Add(this.btnBuyMeACoffee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAbout";
            this.Text = "About Simple Chia Plotter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.LinkLabel linkLabelAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuyMeACoffee;
        private System.Windows.Forms.Label label2;
    }
}