using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public  interface Iuser
    {
        string print();//By 
    }
    public class Practice : Iuser
    {
        public string print()
        {
            return "This is Implement Method";
        }
    }
}
