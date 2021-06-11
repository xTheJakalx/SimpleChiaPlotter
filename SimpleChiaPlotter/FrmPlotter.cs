using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SimpleChiaPlotter
{
    public partial class FrmPlotter : Form
    {
        private Chia chia = new Chia();
        IniFile MyIni = new IniFile();

        public FrmPlotter()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void LoadConfig()
        {
            string curFile = "SimpleChiaPlotter.ini";
            if (File.Exists(curFile))
            {
                try
                {
                    MyIni = new IniFile("SimpleChiaPlotter.ini");
                    textBoxTempDir1.Text = MyIni.Read("TempDir1");
                    textBoxTempDir2.Text = MyIni.Read("TempDir2");
                    textBoxFinalDir.Text = MyIni.Read("TargetDir");
                    listBoxPlotSize.SelectedIndex = 1;
                }
                catch (Exception)
                {
                    CreateConfig();
                    MyIni = new IniFile("SimpleChiaPlotter.ini");
                    listBoxPlotSize.SelectedIndex = 1;
                }
            }
            else
            {
                CreateConfig();
            }
            var chia = new Chia
            {
                Directory = MyIni.Read("Directory"),
                Executable = MyIni.Read("Executable"),
                PlotSize = GetSelectedPlotSize(),
                Buckets = MyIni.Read("Buckets"),
                Threads = MyIni.Read("Threads"),
                Memory = MyIni.Read("Memory"),
                TotalPlots = MyIni.Read("TotalPlots"),
                FarmerPublicKey = MyIni.Read("FarmerPublicKey"),
                PoolPublicKey = MyIni.Read("PoolPublicKey"),
                TempDir1 = MyIni.Read("TempDir1"),
                TempDir2 = MyIni.Read("TempDir2"),
                TargetDir = MyIni.Read("TargetDir")
            };
            if (chia.Directory == "")
            {
                MessageBox.Show("Please configure Chia Deamon Directory!", "Urgent!");
                FrmSettings f2 = new FrmSettings();
                f2.ShowDialog();
            }
        }

        private void CreateConfig()
        {
            MyIni.Write("Directory", null);
            MyIni.Write("Executable", "chia.exe");
            MyIni.Write("PlotSize", "32");
            MyIni.Write("Buckets", "128");
            MyIni.Write("Threads", "2");
            MyIni.Write("Memory", "3390");
            MyIni.Write("TotalPlots", "1");
            MyIni.Write("FarmerPublicKey", null);
            MyIni.Write("PoolPublicKey", null);
            MyIni.Write("TempDir1", null);
            MyIni.Write("TempDir2", null);
            MyIni.Write("TargetDir", null);
        }

        private void SaveConfig(Chia chia)
        {
            MyIni.Write("Directory", chia.Directory);
            MyIni.Write("Executable", chia.Executable);
            MyIni.Write("PlotSize", chia.PlotSize);
            MyIni.Write("Buckets", chia.Buckets);
            MyIni.Write("Threads", chia.Threads);
            MyIni.Write("Memory", chia.Memory);
            MyIni.Write("TotalPlots", chia.TotalPlots);
            MyIni.Write("FarmerPublicKey", chia.FarmerPublicKey);
            MyIni.Write("PoolPublicKey", chia.PoolPublicKey);
            MyIni.Write("TempDir1", chia.TempDir1);
            MyIni.Write("TempDir2", chia.TempDir2);
            MyIni.Write("TargetDir", chia.TargetDir);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // exit program
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open about form
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open settings form
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.ShowDialog();
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            var chia = new Chia
            {
                Directory = MyIni.Read("Directory"),
                Executable = MyIni.Read("Executable"),
                PlotSize = GetSelectedPlotSize(),
                Threads = textBoxThreads.Text,
                Buckets = textBoxBuckets.Text,
                Memory = textBoxMemory.Text,
                TotalPlots = textBoxPlotCount.Text,
                FarmerPublicKey = textBoxFarmerPublicKey.Text,
                PoolPublicKey = textBoxPoolPublicKey.Text,
                TempDir1 = textBoxTempDir1.Text,
                TempDir2 = textBoxTempDir2.Text,
                TargetDir = textBoxFinalDir.Text 
            };
            SaveConfig(chia);
            if (textBoxTempDir1.Text == "" || textBoxFinalDir.Text == "" || (checkBox2ndTempDir.Checked == true && textBoxTempDir2.Text == ""))
            {
                    MessageBox.Show("Please configure plotting directories!", "Urgent!");
            }
            else
            {
                var plotter = new Plotter();
                var tempDir2 = false;
                var bitfield = false;
                var exclude = false;
                var farmerKey = false;
                var poolKey = false;
                if (checkBox2ndTempDir.Checked)
                {
                    tempDir2 = true;
                }
                if (checkBoxDisabelBitfieldPlotting.Checked)
                {
                    bitfield = true;
                }
                if(checkBoxExcludeFinalDir.Checked)
                {
                    exclude = true;
                }
                if (checkBoxFarmerPublicKey.Checked)
                {
                    farmerKey = true;
                }
                if (checkBoxPoolPublicKey.Checked)
                {
                    poolKey = true;
                }
                plotter.Run(chia, tempDir2, exclude, bitfield, farmerKey, poolKey);
            }

        }

        private string GetSelectedPlotSize()
        {
            string result = "";
            switch ((string)listBoxPlotSize.SelectedItem)
            {
                case "600MiB (k=25, temporary space: 1.8GiB)":
                    result = "25";
                    break;
                case "101.4GiB (k=32, temporary space: 239GiB)":
                    result = "32";
                    break;
                case "208.8GiB (k=33, temporary space: 521GiB)":
                    result = "33";
                    break;
                case "429.8GiB (k=34, temporary space: 1041GiB)":
                    result = "34";
                    break;
                case "884.1GiB (k=35, temporary space: 2175GiB)":
                    result = "35";
                    break;
                default:
                    break;
            }
            return result;
        }

        private void linkLabelLearnMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
        private void VisitLink()
        {
            linkLabelLearnMore.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Chia-Network/chia-blockchain/wiki/k-sizes");
        }

        private void btnTempDir1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    chia.TempDir1 = fbd.SelectedPath;
                    textBoxTempDir1.Text = fbd.SelectedPath;
                    MyIni.Write("TempDir1", chia.TempDir1);
                    LoadConfig();
                }
            }
        }

        private void btnTempDir2_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    chia.TempDir2 = fbd.SelectedPath;
                    textBoxTempDir2.Text = fbd.SelectedPath;
                    MyIni.Write("TempDir2", chia.TempDir2);
                    LoadConfig();
                }
            }
        }

        private void btnFinalDir_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    chia.TargetDir = fbd.SelectedPath;
                    textBoxFinalDir.Text = fbd.SelectedPath;
                    MyIni.Write("TargetDir", chia.TargetDir);
                    LoadConfig();
                }
            }
        }

        private void checkBoxFarmerPublicKey_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxFarmerPublicKey.Enabled)
            {
                textBoxFarmerPublicKey.Enabled = false;
            }
            else
            {
                textBoxFarmerPublicKey.Enabled = true;
            }
        }

        private void checkBoxPoolPublicKey_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxPoolPublicKey.Enabled)
            {
                textBoxPoolPublicKey.Enabled = false;
            }
            else
            {
                textBoxPoolPublicKey.Enabled = true;
            }
        }
        private void BuyMeACoffee()
        {
            System.Diagnostics.Process.Start("https://buymeacoffee.com/TheJakal");
        }

        private void btnBuyMeACoffee_Click(object sender, EventArgs e)
        {
            BuyMeACoffee();
        }
    }
}
