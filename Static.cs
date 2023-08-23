using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public class Static
    {
        int id;
        static string name;

        static Static()
        {
            Console.WriteLine("name");
        }

        public Static()
        {
            id = 9;
        }

        public static  void show()
        {
            name = "Sakshi";
            Console.WriteLine( name);
        }

    }
}
