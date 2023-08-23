using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public class Person
    {
        protected long Addhar;
        protected string name;
        protected string address;
        public Person(long Addhar, string name, string address)
        {
            this.Addhar = Addhar;
            this.name = name;
           this. address = address;
        }
        public void Display()
        {
            Console.WriteLine( Addhar+"\t"+name+"\t"+address);
        }
       
    }

    public class Patient :Person
    {
        private string BloodGroup;
        private long Bill;
       
        public Patient(string BloodGroup,long Addhar ,string name,string Address,long Bill) : base( Addhar,name,Address)
        {
           
            this.BloodGroup = BloodGroup;
            this.Bill = Bill;
          
        }
        public void show()
        {
            Console.WriteLine( BloodGroup+"\t"+Bill);
        }


    }
}
