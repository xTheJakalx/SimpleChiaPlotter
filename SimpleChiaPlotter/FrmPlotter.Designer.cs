
namespace SimpleChiaPlotter
{
    partial class FrmPlotter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlotter));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlot = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabelLearnMore = new System.Windows.Forms.LinkLabel();
            this.lblPlotInfo = new System.Windows.Forms.Label();
            this.listBoxPlotSize = new System.Windows.Forms.ListBox();
            this.lblPlotSize = new System.Windows.Forms.Label();
            this.checkBoxExcludeFinalDir = new System.Windows.Forms.CheckBox();
            this.checkBoxDisabelBitfieldPlotting = new System.Windows.Forms.CheckBox();
            this.lblBuckets = new System.Windows.Forms.Label();
            this.lblQueue = new System.Windows.Forms.Label();
            this.lblPlotCount = new System.Windows.Forms.Label();
            this.lblThreads = new System.Windows.Forms.Label();
            this.lblMemory = new System.Windows.Forms.Label();
            this.textBoxBuckets = new System.Windows.Forms.TextBox();
            this.textBoxQueue = new System.Windows.Forms.TextBox();
            this.lblFinalDir = new System.Windows.Forms.Label();
            this.textBoxThreads = new System.Windows.Forms.TextBox();
            this.btnFinalDir = new System.Windows.Forms.Button();
            this.textBoxMemory = new System.Windows.Forms.TextBox();
            this.lblTempDir2 = new System.Windows.Forms.Label();
            this.lblTempDir1 = new System.Windows.Forms.Label();
            this.textBoxFinalDir = new System.Windows.Forms.TextBox();
            this.btnTempDir2 = new System.Windows.Forms.Button();
            this.btnTempDir1 = new System.Windows.Forms.Button();
            this.textBoxTempDir2 = new System.Windows.Forms.TextBox();
            this.textBoxTempDir1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPlotCount = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox2ndTempDir = new System.Windows.Forms.CheckBox();
            this.lblMainInfo = new System.Windows.Forms.Label();
            this.toolTipBitfield = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxPoolPublicKey = new System.Windows.Forms.TextBox();
            this.textBoxFarmerPublicKey = new System.Windows.Forms.TextBox();
            this.checkBoxPoolPublicKey = new System.Windows.Forms.CheckBox();
            this.checkBoxFarmerPublicKey = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuyMeACoffee = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(868, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(408, 371);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(87, 42);
            this.btnPlot.TabIndex = 2;
            this.btnPlot.Text = "Build Plots";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabelLearnMore);
            this.groupBox1.Controls.Add(this.lblPlotInfo);
            this.groupBox1.Controls.Add(this.listBoxPlotSize);
            this.groupBox1.Controls.Add(this.lblPlotSize);
            this.groupBox1.Location = new System.Drawing.Point(13, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 191);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Choose plot Size";
            // 
            // linkLabelLearnMore
            // 
            this.linkLabelLearnMore.AutoSize = true;
            this.linkLabelLearnMore.Location = new System.Drawing.Point(56, 68);
            this.linkLabelLearnMore.Name = "linkLabelLearnMore";
            this.linkLabelLearnMore.Size = new System.Drawing.Size(61, 13);
            this.linkLabelLearnMore.TabIndex = 29;
            this.linkLabelLearnMore.TabStop = true;
            this.linkLabelLearnMore.Text = "Learn More";
            this.linkLabelLearnMore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLearnMore_LinkClicked);
            // 
            // lblPlotInfo
            // 
            this.lblPlotInfo.AutoSize = true;
            this.lblPlotInfo.Location = new System.Drawing.Point(6, 16);
            this.lblPlotInfo.Name = "lblPlotInfo";
            this.lblPlotInfo.Size = new System.Drawing.Size(237, 65);
            this.lblPlotInfo.TabIndex = 28;
            this.lblPlotInfo.Text = "You do not need to be synched or connected to \r\nplot. Temporary files are created" +
    " during the \r\nplotting process which exceed the size of the \r\nfinal plot files. " +
    "Make sure you have enough \r\nspace.";
            // 
            // listBoxPlotSize
            // 
            this.listBoxPlotSize.FormattingEnabled = true;
            this.listBoxPlotSize.Items.AddRange(new object[] {
            "600MiB (k=25, temporary space: 1.8GiB)",
            "101.4GiB (k=32, temporary space: 239GiB)",
            "208.8GiB (k=33, temporary space: 521GiB)",
            "429.8GiB (k=34, temporary space: 1041GiB)",
            "884.1GiB (k=35, temporary space: 2175GiB)"});
            this.listBoxPlotSize.Location = new System.Drawing.Point(9, 111);
            this.listBoxPlotSize.Name = "listBoxPlotSize";
            this.listBoxPlotSize.Size = new System.Drawing.Size(228, 69);
            this.listBoxPlotSize.TabIndex = 26;
            // 
            // lblPlotSize
            // 
            this.lblPlotSize.AutoSize = true;
            this.lblPlotSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlotSize.Location = new System.Drawing.Point(6, 94);
            this.lblPlotSize.Name = "lblPlotSize";
            this.lblPlotSize.Size = new System.Drawing.Size(57, 13);
            this.lblPlotSize.TabIndex = 9;
            this.lblPlotSize.Text = "Plot Size";
            // 
            // checkBoxExcludeFinalDir
            // 
            this.checkBoxExcludeFinalDir.AutoSize = true;
            this.checkBoxExcludeFinalDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExcludeFinalDir.Location = new System.Drawing.Point(9, 161);
            this.checkBoxExcludeFinalDir.Name = "checkBoxExcludeFinalDir";
            this.checkBoxExcludeFinalDir.Size = new System.Drawing.Size(299, 17);
            this.checkBoxExcludeFinalDir.TabIndex = 30;
            this.checkBoxExcludeFinalDir.Text = "Exclude adding final dir to harvester for farming.";
            this.checkBoxExcludeFinalDir.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisabelBitfieldPlotting
            // 
            this.checkBoxDisabelBitfieldPlotting.AutoSize = true;
            this.checkBoxDisabelBitfieldPlotting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDisabelBitfieldPlotting.Location = new System.Drawing.Point(9, 137);
            this.checkBoxDisabelBitfieldPlotting.Name = "checkBoxDisabelBitfieldPlotting";
            this.checkBoxDisabelBitfieldPlotting.Size = new System.Drawing.Size(246, 17);
            this.checkBoxDisabelBitfieldPlotting.TabIndex = 29;
            this.checkBoxDisabelBitfieldPlotting.Text = "Disable bitfield plotting (Hover for info)";
            this.toolTipBitfield.SetToolTip(this.checkBoxDisabelBitfieldPlotting, resources.GetString("checkBoxDisabelBitfieldPlotting.ToolTip"));
            this.checkBoxDisabelBitfieldPlotting.UseVisualStyleBackColor = true;
            // 
            // lblBuckets
            // 
            this.lblBuckets.AutoSize = true;
            this.lblBuckets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuckets.Location = new System.Drawing.Point(6, 93);
            this.lblBuckets.Name = "lblBuckets";
            this.lblBuckets.Size = new System.Drawing.Size(101, 13);
            this.lblBuckets.TabIndex = 10;
            this.lblBuckets.Text = "Num. of Buckets";
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueue.Location = new System.Drawing.Point(107, 93);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(80, 13);
            this.lblQueue.TabIndex = 11;
            this.lblQueue.Text = "Queue Name";
            // 
            // lblPlotCount
            // 
            this.lblPlotCount.AutoSize = true;
            this.lblPlotCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlotCount.Location = new System.Drawing.Point(6, 16);
            this.lblPlotCount.Name = "lblPlotCount";
            this.lblPlotCount.Size = new System.Drawing.Size(66, 13);
            this.lblPlotCount.TabIndex = 12;
            this.lblPlotCount.Text = "Plot Count";
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreads.Location = new System.Drawing.Point(107, 53);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(53, 13);
            this.lblThreads.TabIndex = 13;
            this.lblThreads.Text = "Threads";
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemory.Location = new System.Drawing.Point(6, 53);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(78, 13);
            this.lblMemory.TabIndex = 14;
            this.lblMemory.Text = "Memory Size";
            // 
            // textBoxBuckets
            // 
            this.textBoxBuckets.Location = new System.Drawing.Point(9, 110);
            this.textBoxBuckets.Name = "textBoxBuckets";
            this.textBoxBuckets.Size = new System.Drawing.Size(95, 20);
            this.textBoxBuckets.TabIndex = 21;
            this.textBoxBuckets.Text = "128";
            // 
            // textBoxQueue
            // 
            this.textBoxQueue.Location = new System.Drawing.Point(110, 110);
            this.textBoxQueue.Name = "textBoxQueue";
            this.textBoxQueue.Size = new System.Drawing.Size(64, 20);
            this.textBoxQueue.TabIndex = 16;
            this.textBoxQueue.Text = "default";
            // 
            // lblFinalDir
            // 
            this.lblFinalDir.AutoSize = true;
            this.lblFinalDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalDir.Location = new System.Drawing.Point(6, 141);
            this.lblFinalDir.Name = "lblFinalDir";
            this.lblFinalDir.Size = new System.Drawing.Size(129, 13);
            this.lblFinalDir.TabIndex = 15;
            this.lblFinalDir.Text = "Select Final Directory";
            // 
            // textBoxThreads
            // 
            this.textBoxThreads.Location = new System.Drawing.Point(110, 70);
            this.textBoxThreads.Name = "textBoxThreads";
            this.textBoxThreads.Size = new System.Drawing.Size(64, 20);
            this.textBoxThreads.TabIndex = 19;
            this.textBoxThreads.Text = "2";
            // 
            // btnFinalDir
            // 
            this.btnFinalDir.Location = new System.Drawing.Point(148, 157);
            this.btnFinalDir.Name = "btnFinalDir";
            this.btnFinalDir.Size = new System.Drawing.Size(75, 22);
            this.btnFinalDir.TabIndex = 23;
            this.btnFinalDir.Text = "Browse";
            this.btnFinalDir.UseVisualStyleBackColor = true;
            this.btnFinalDir.Click += new System.EventHandler(this.btnFinalDir_Click);
            // 
            // textBoxMemory
            // 
            this.textBoxMemory.Location = new System.Drawing.Point(9, 70);
            this.textBoxMemory.Name = "textBoxMemory";
            this.textBoxMemory.Size = new System.Drawing.Size(95, 20);
            this.textBoxMemory.TabIndex = 18;
            this.textBoxMemory.Text = "3390";
            // 
            // lblTempDir2
            // 
            this.lblTempDir2.AutoSize = true;
            this.lblTempDir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempDir2.Location = new System.Drawing.Point(6, 69);
            this.lblTempDir2.Name = "lblTempDir2";
            this.lblTempDir2.Size = new System.Drawing.Size(186, 13);
            this.lblTempDir2.TabIndex = 7;
            this.lblTempDir2.Text = "Select 2nd Temporary Directory";
            // 
            // lblTempDir1
            // 
            this.lblTempDir1.AutoSize = true;
            this.lblTempDir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempDir1.Location = new System.Drawing.Point(6, 16);
            this.lblTempDir1.Name = "lblTempDir1";
            this.lblTempDir1.Size = new System.Drawing.Size(161, 13);
            this.lblTempDir1.TabIndex = 6;
            this.lblTempDir1.Text = "Select Temporary Directory";
            // 
            // textBoxFinalDir
            // 
            this.textBoxFinalDir.Location = new System.Drawing.Point(9, 158);
            this.textBoxFinalDir.Name = "textBoxFinalDir";
            this.textBoxFinalDir.Size = new System.Drawing.Size(132, 20);
            this.textBoxFinalDir.TabIndex = 17;
            // 
            // btnTempDir2
            // 
            this.btnTempDir2.Location = new System.Drawing.Point(148, 105);
            this.btnTempDir2.Name = "btnTempDir2";
            this.btnTempDir2.Size = new System.Drawing.Size(75, 22);
            this.btnTempDir2.TabIndex = 24;
            this.btnTempDir2.Text = "Browse";
            this.btnTempDir2.UseVisualStyleBackColor = true;
            this.btnTempDir2.Click += new System.EventHandler(this.btnTempDir2_Click);
            // 
            // btnTempDir1
            // 
            this.btnTempDir1.Location = new System.Drawing.Point(148, 32);
            this.btnTempDir1.Name = "btnTempDir1";
            this.btnTempDir1.Size = new System.Drawing.Size(75, 22);
            this.btnTempDir1.TabIndex = 25;
            this.btnTempDir1.Text = "Browse";
            this.btnTempDir1.UseVisualStyleBackColor = true;
            this.btnTempDir1.Click += new System.EventHandler(this.btnTempDir1_Click);
            // 
            // textBoxTempDir2
            // 
            this.textBoxTempDir2.Location = new System.Drawing.Point(9, 106);
            this.textBoxTempDir2.Name = "textBoxTempDir2";
            this.textBoxTempDir2.Size = new System.Drawing.Size(132, 20);
            this.textBoxTempDir2.TabIndex = 22;
            // 
            // textBoxTempDir1
            // 
            this.textBoxTempDir1.Location = new System.Drawing.Point(9, 33);
            this.textBoxTempDir1.Name = "textBoxTempDir1";
            this.textBoxTempDir1.Size = new System.Drawing.Size(132, 20);
            this.textBoxTempDir1.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxExcludeFinalDir);
            this.groupBox2.Controls.Add(this.lblPlotCount);
            this.groupBox2.Controls.Add(this.checkBoxDisabelBitfieldPlotting);
            this.groupBox2.Controls.Add(this.textBoxPlotCount);
            this.groupBox2.Controls.Add(this.textBoxMemory);
            this.groupBox2.Controls.Add(this.textBoxThreads);
            this.groupBox2.Controls.Add(this.textBoxQueue);
            this.groupBox2.Controls.Add(this.textBoxBuckets);
            this.groupBox2.Controls.Add(this.lblMemory);
            this.groupBox2.Controls.Add(this.lblBuckets);
            this.groupBox2.Controls.Add(this.lblThreads);
            this.groupBox2.Controls.Add(this.lblQueue);
            this.groupBox2.Location = new System.Drawing.Point(269, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 191);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Choose Number of plots";
            // 
            // textBoxPlotCount
            // 
            this.textBoxPlotCount.Location = new System.Drawing.Point(9, 32);
            this.textBoxPlotCount.Name = "textBoxPlotCount";
            this.textBoxPlotCount.Size = new System.Drawing.Size(95, 20);
            this.textBoxPlotCount.TabIndex = 18;
            this.textBoxPlotCount.Text = "1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox2ndTempDir);
            this.groupBox3.Controls.Add(this.lblTempDir1);
            this.groupBox3.Controls.Add(this.textBoxTempDir1);
            this.groupBox3.Controls.Add(this.textBoxTempDir2);
            this.groupBox3.Controls.Add(this.lblFinalDir);
            this.groupBox3.Controls.Add(this.btnTempDir1);
            this.groupBox3.Controls.Add(this.btnFinalDir);
            this.groupBox3.Controls.Add(this.btnTempDir2);
            this.groupBox3.Controls.Add(this.textBoxFinalDir);
            this.groupBox3.Controls.Add(this.lblTempDir2);
            this.groupBox3.Location = new System.Drawing.Point(622, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 191);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Select Directories";
            // 
            // checkBox2ndTempDir
            // 
            this.checkBox2ndTempDir.AutoSize = true;
            this.checkBox2ndTempDir.Location = new System.Drawing.Point(12, 86);
            this.checkBox2ndTempDir.Name = "checkBox2ndTempDir";
            this.checkBox2ndTempDir.Size = new System.Drawing.Size(196, 17);
            this.checkBox2ndTempDir.TabIndex = 26;
            this.checkBox2ndTempDir.Text = "Enable (Used during phase 3 and 4)";
            this.checkBox2ndTempDir.UseVisualStyleBackColor = true;
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Location = new System.Drawing.Point(18, 40);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(623, 26);
            this.lblMainInfo.TabIndex = 10;
            this.lblMainInfo.Text = resources.GetString("lblMainInfo.Text");
            // 
            // toolTipBitfield
            // 
            this.toolTipBitfield.AutoPopDelay = 500000000;
            this.toolTipBitfield.InitialDelay = 500;
            this.toolTipBitfield.IsBalloon = true;
            this.toolTipBitfield.ReshowDelay = 100;
            this.toolTipBitfield.ToolTipTitle = resources.GetString("toolTipBitfield.ToolTipTitle");
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxPoolPublicKey);
            this.groupBox4.Controls.Add(this.textBoxFarmerPublicKey);
            this.groupBox4.Controls.Add(this.checkBoxPoolPublicKey);
            this.groupBox4.Controls.Add(this.checkBoxFarmerPublicKey);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(844, 89);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Public Keys (Optional)";
            // 
            // textBoxPoolPublicKey
            // 
            this.textBoxPoolPublicKey.Enabled = false;
            this.textBoxPoolPublicKey.Location = new System.Drawing.Point(127, 55);
            this.textBoxPoolPublicKey.Name = "textBoxPoolPublicKey";
            this.textBoxPoolPublicKey.Size = new System.Drawing.Size(706, 20);
            this.textBoxPoolPublicKey.TabIndex = 6;
            // 
            // textBoxFarmerPublicKey
            // 
            this.textBoxFarmerPublicKey.Enabled = false;
            this.textBoxFarmerPublicKey.Location = new System.Drawing.Point(127, 33);
            this.textBoxFarmerPublicKey.Name = "textBoxFarmerPublicKey";
            this.textBoxFarmerPublicKey.Size = new System.Drawing.Size(706, 20);
            this.textBoxFarmerPublicKey.TabIndex = 5;
            // 
            // checkBoxPoolPublicKey
            // 
            this.checkBoxPoolPublicKey.AutoSize = true;
            this.checkBoxPoolPublicKey.Location = new System.Drawing.Point(21, 57);
            this.checkBoxPoolPublicKey.Name = "checkBoxPoolPublicKey";
            this.checkBoxPoolPublicKey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxPoolPublicKey.Size = new System.Drawing.Size(100, 17);
            this.checkBoxPoolPublicKey.TabIndex = 4;
            this.checkBoxPoolPublicKey.Text = "Pool Public Key";
            this.checkBoxPoolPublicKey.UseVisualStyleBackColor = true;
            this.checkBoxPoolPublicKey.CheckedChanged += new System.EventHandler(this.checkBoxPoolPublicKey_CheckedChanged);
            // 
            // checkBoxFarmerPublicKey
            // 
            this.checkBoxFarmerPublicKey.AutoSize = true;
            this.checkBoxFarmerPublicKey.Location = new System.Drawing.Point(10, 36);
            this.checkBoxFarmerPublicKey.Name = "checkBoxFarmerPublicKey";
            this.checkBoxFarmerPublicKey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxFarmerPublicKey.Size = new System.Drawing.Size(111, 17);
            this.checkBoxFarmerPublicKey.TabIndex = 3;
            this.checkBoxFarmerPublicKey.Text = "Farmer Public Key";
            this.checkBoxFarmerPublicKey.UseVisualStyleBackColor = true;
            this.checkBoxFarmerPublicKey.CheckedChanged += new System.EventHandler(this.checkBoxFarmerPublicKey_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Use this section to enable your public Farmer and Pool keys - ALWAYS copy and pas" +
    "te your keys! (you might accidentally type the wrong key if you don\'t)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Does this app help you out?\r\n";
            // 
            // btnBuyMeACoffee
            // 
            this.btnBuyMeACoffee.AutoSize = true;
            this.btnBuyMeACoffee.BackgroundImage = global::SimpleChiaPlotter.Properties.Resources.BuyMeACoffee;
            this.btnBuyMeACoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuyMeACoffee.Location = new System.Drawing.Point(13, 371);
            this.btnBuyMeACoffee.Name = "btnBuyMeACoffee";
            this.btnBuyMeACoffee.Size = new System.Drawing.Size(199, 47);
            this.btnBuyMeACoffee.TabIndex = 30;
            this.btnBuyMeACoffee.UseVisualStyleBackColor = true;
            this.btnBuyMeACoffee.Click += new System.EventHandler(this.btnBuyMeACoffee_Click);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1,
            this.aboutToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FrmPlotter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 425);
            this.Controls.Add(this.btnBuyMeACoffee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblMainInfo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmPlotter";
            this.Text = "Simple Chia Plotter";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPlotInfo;
        private System.Windows.Forms.ListBox listBoxPlotSize;
        private System.Windows.Forms.Label lblPlotSize;
        private System.Windows.Forms.CheckBox checkBoxExcludeFinalDir;
        private System.Windows.Forms.CheckBox checkBoxDisabelBitfieldPlotting;
        private System.Windows.Forms.Label lblBuckets;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label lblPlotCount;
        private System.Windows.Forms.Label lblThreads;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.TextBox textBoxBuckets;
        private System.Windows.Forms.TextBox textBoxQueue;
        private System.Windows.Forms.Label lblFinalDir;
        private System.Windows.Forms.TextBox textBoxThreads;
        private System.Windows.Forms.Button btnFinalDir;
        private System.Windows.Forms.TextBox textBoxMemory;
        private System.Windows.Forms.Label lblTempDir2;
        private System.Windows.Forms.Label lblTempDir1;
        private System.Windows.Forms.TextBox textBoxFinalDir;
        private System.Windows.Forms.Button btnTempDir2;
        private System.Windows.Forms.Button btnTempDir1;
        private System.Windows.Forms.TextBox textBoxTempDir2;
        private System.Windows.Forms.TextBox textBoxTempDir1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel linkLabelLearnMore;
        private System.Windows.Forms.TextBox textBoxPlotCount;
        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.CheckBox checkBox2ndTempDir;
        private System.Windows.Forms.ToolTip toolTipBitfield;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxPoolPublicKey;
        private System.Windows.Forms.TextBox textBoxFarmerPublicKey;
        private System.Windows.Forms.CheckBox checkBoxPoolPublicKey;
        private System.Windows.Forms.CheckBox checkBoxFarmerPublicKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuyMeACoffee;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}