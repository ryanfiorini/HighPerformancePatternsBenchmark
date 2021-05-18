using BenchmarkDotNet.Attributes;
using System;

namespace HighPerformancePatternsBenchmark
{
    public class Customer
    {
        private double Earnings;
        private DateTime DateOfBirth;
        private bool IsSmoker;
        private double Scoring;
        
        public void UpdateScoring()
        {
            Scoring = Earnings * (IsSmoker ? 0.8 : 1.0);
        }
    }
}
