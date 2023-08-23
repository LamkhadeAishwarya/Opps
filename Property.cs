using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public class Property
    {
        int id;
        string name;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }


        public string Name
        {
            set { name = value; }
            get { return name; }
        }
    }
}
