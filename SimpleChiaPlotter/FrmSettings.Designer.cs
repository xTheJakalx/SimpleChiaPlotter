
namespace SimpleChiaPlotter
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.lblDeamonDirectory = new System.Windows.Forms.Label();
            this.textBoxDeamonDirectory = new System.Windows.Forms.TextBox();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExecutable = new System.Windows.Forms.Label();
            this.btnExecutable = new System.Windows.Forms.Button();
            this.textBoxExecutable = new System.Windows.Forms.TextBox();
            this.groupBoxSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeamonDirectory
            // 
            this.lblDeamonDirectory.AutoSize = true;
            this.lblDeamonDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeamonDirectory.Location = new System.Drawing.Point(17, 78);
            this.lblDeamonDirectory.Name = "lblDeamonDirectory";
            this.lblDeamonDirectory.Size = new System.Drawing.Size(161, 13);
            this.lblDeamonDirectory.TabIndex = 0;
            this.lblDeamonDirectory.Text = "Current Chia deamon folder";
            // 
            // textBoxDeamonDirectory
            // 
            this.textBoxDeamonDirectory.Location = new System.Drawing.Point(20, 95);
            this.textBoxDeamonDirectory.Name = "textBoxDeamonDirectory";
            this.textBoxDeamonDirectory.Size = new System.Drawing.Size(163, 20);
            this.textBoxDeamonDirectory.TabIndex = 1;
            // 
            // btnDirectory
            // 
            this.btnDirectory.Location = new System.Drawing.Point(189, 94);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(60, 22);
            this.btnDirectory.TabIndex = 2;
            this.btnDirectory.Text = "Browse";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.btnSave);
            this.groupBoxSettings.Controls.Add(this.label1);
            this.groupBoxSettings.Controls.Add(this.lblExecutable);
            this.groupBoxSettings.Controls.Add(this.btnExecutable);
            this.groupBoxSettings.Controls.Add(this.lblDeamonDirectory);
            this.groupBoxSettings.Controls.Add(this.textBoxExecutable);
            this.groupBoxSettings.Controls.Add(this.btnDirectory);
            this.groupBoxSettings.Controls.Add(this.textBoxDeamonDirectory);
            this.groupBoxSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(271, 229);
            this.groupBoxSettings.TabIndex = 3;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(67, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 51);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "If chia has been updated the deamon folder \r\nwill now be elsewhere, so please cha" +
    "nge it here";
            // 
            // lblExecutable
            // 
            this.lblExecutable.AutoSize = true;
            this.lblExecutable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExecutable.Location = new System.Drawing.Point(17, 118);
            this.lblExecutable.Name = "lblExecutable";
            this.lblExecutable.Size = new System.Drawing.Size(70, 13);
            this.lblExecutable.TabIndex = 0;
            this.lblExecutable.Text = "Executable";
            // 
            // btnExecutable
            // 
            this.btnExecutable.Enabled = false;
            this.btnExecutable.Location = new System.Drawing.Point(189, 134);
            this.btnExecutable.Name = "btnExecutable";
            this.btnExecutable.Size = new System.Drawing.Size(60, 22);
            this.btnExecutable.TabIndex = 2;
            this.btnExecutable.Text = "Browse";
            this.btnExecutable.UseVisualStyleBackColor = true;
            this.btnExecutable.Click += new System.EventHandler(this.btnExecutable_Click);
            // 
            // textBoxExecutable
            // 
            this.textBoxExecutable.Location = new System.Drawing.Point(20, 135);
            this.textBoxExecutable.Name = "textBoxExecutable";
            this.textBoxExecutable.Size = new System.Drawing.Size(163, 20);
            this.textBoxExecutable.TabIndex = 1;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 253);
            this.Controls.Add(this.groupBoxSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSettings";
            this.Text = "Settings";
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDeamonDirectory;
        private System.Windows.Forms.TextBox textBoxDeamonDirectory;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Label lblExecutable;
        private System.Windows.Forms.Button btnExecutable;
        private System.Windows.Forms.TextBox textBoxExecutable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
    }
}