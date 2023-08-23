using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public class IPLTeam
    {
        public void Play()
        {
            Console.WriteLine( "Its Parent Class");
        }
    }
    public class CSK:IPLTeam
    {
        public  void Play1()
        {
           Console.WriteLine( "Its First Child Class");
           
        }
    }

    public class RCB : IPLTeam
    {
        public  void Play2()
        {
            Console.WriteLine( "Its Second Child Class");
        }
    }

}
