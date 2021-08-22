using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class addinfocs:basicinfo
    {
        string course;
        int year, sem;
        public addinfocs(string fnm, string mnm, string lnm, string cr, int yr, int s)
        {
            fn = fnm;
            mn = mnm;
            ln = lnm;
            course = cr;
            year = yr;
            sem = s;
        }
        public string processadd()
        { return "\n" + course + " " + year + " year " + sem + " sem "; }
    }
}
