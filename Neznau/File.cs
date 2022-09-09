using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neznau
{
    internal interface File
    {
        string trimString(string text);// { return text.Trim(new Char[] { '\r', '\n' }); }
        double toDouble(string text);// { return Convert.ToDouble(text); }
        void SaveSomewhere(string where);
    }
}
