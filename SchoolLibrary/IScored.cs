using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    interface IScored
    {
        float Score { get; set; }
        float MaximumScore { get; set; }
    }
}
