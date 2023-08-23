using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public class SimpleClass1
    {
        int id;
        string name;

        public SimpleClass1(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine(id + "\t" + name);
        }





    }
}
