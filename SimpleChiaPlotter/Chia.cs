using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChiaPlotter
{
    class Chia
    {

        // .\chia plots create -k %plotSize% -b %memory% -t %tempDir1% -2 %tempDir2% -d %targetDir%
        public string Directory { get; set; }
        public string Executable { get; set; }
        public string PlotSize { get; set; }
        public string Buckets { get; set; }
        public string Threads { get; set; }
        public string Memory { get; set; }
        public string TotalPlots { get; set; }
        public string FarmerPublicKey { get; set; }
        public string PoolPublicKey { get; set; }
        public string TempDir1 { get; set; }
        public string TempDir2 { get; set; }
        public string TargetDir { get; set; }
    }
}
