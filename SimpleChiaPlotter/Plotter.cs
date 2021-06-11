using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleChiaPlotter
{
    class Plotter
    {
        public void Run(Chia chia, bool tempdir2, bool exclude, bool bitfield, bool farmerKey, bool poolKey)
        {
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = $"{chia.Directory}\\{chia.Executable}";

            info.Arguments = $"plots create -k {chia.PlotSize} -b {chia.Memory} -u {chia.Buckets} -r {chia.Threads} -n {chia.TotalPlots} -t {chia.TempDir1} -d {chia.TargetDir}";
            if (tempdir2) { info.Arguments += $" -2 {chia.TempDir2}"; }
            if (bitfield) { info.Arguments += $" -e"; }
            if (exclude) { info.Arguments += $" -x"; }
            if (farmerKey) { info.Arguments += $" -f {chia.FarmerPublicKey}"; }
            if (poolKey) { info.Arguments += $" -p {chia.PoolPublicKey}"; }
            info.WorkingDirectory = chia.Directory;
            p.StartInfo = info;
            try
            {
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error Ocurred! \r\n Message: {ex.Message}", "Error");
            }

        }
    }
}
