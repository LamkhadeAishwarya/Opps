using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public class Multilevel
    {
        protected int rollno;
        protected string name;
        protected long contact;

        public Multilevel(int rollno,string name,long contact)
        {
         this.rollno = rollno;
         this.name = name;
         this.contact = contact;
            
        }

    }
    public class Second : Multilevel
    {
       protected string bloodGroup;

        public Second(string name, int rollno, long contact, string bloodGroup) : base(rollno, name, contact)
        {
            this.bloodGroup = bloodGroup;
        }
    }
        public class Third : Second
        {
            int age;
            public Third(int age, string name, int rollno, long contact, string bloodGroup) : base(name, rollno, contact, bloodGroup)
            {
                this.age=age;
            }

            public string Show()
            {
                return $"{age},{name},{rollno},{contact},{bloodGroup}";
            }
        }
         
        
    }


