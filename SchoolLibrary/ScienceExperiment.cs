using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SchoolLibrary
{
    class ScienceExperiment : IScored
    {
        public string Hypothesis { get; set; }
        public string Materials { get; set; }
        public string  Method { get; set; }
        public string Conclusion { get; set; }
        float IScored.Score { get; set; }
        float IScored.MaximumScore { get; set; }
    }
}
