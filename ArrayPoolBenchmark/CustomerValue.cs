using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HighPerformancePatternsBenchmark
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CustomerValue
    {
        double Earnings;
        DateTime DateOfBirth;
        bool IsSmoker;
        double Scoring;

        public void UpdateScoring()
        {
            Scoring = Earnings * (IsSmoker ? 0.8 : 1.0);
        }
    }
}
