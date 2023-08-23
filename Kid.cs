using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    //MethodOverLoading.Overriding
    public class Kid
    {
        int page;
        string name;
        string color;
        public virtual void ReadBook(string color)
        {
            this.color = color;
            Console.WriteLine("Reading Book" + color);
        }
        public void ReadBook(int page, string name)
        {
            this.page = page;
            this.name = name;
            Console.WriteLine("Number of reading Pages " + page + "\nName of Book " + name);
        }
    }
        public class BigKid : Kid
        {
            string author;
            public override void ReadBook(string author)
            {
                this.author= author;
                Console.WriteLine( "Its Overriding Method"+author);
            }
        }
       
    }

