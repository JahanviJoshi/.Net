using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class basicinfo
    {
        public string fn, mn, ln;
        public basicinfo()
        { }
        public basicinfo(string f, string m, string l)
        {
            fn = f;
            mn = m;
            ln = l;
        }

        public string processbasic()
        { return "welcome " + fn + " " + mn + " " + ln; }
    }
}
