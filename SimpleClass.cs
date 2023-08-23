using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public class SimpleClass
    {
        int id;
        string name;

        public void Access(int id, string name)
        {
            this.id = id;
            this.name = name;

        }

        public void Show()
        {
            Console.WriteLine( id+"\t"+name);
        }
    }
}
