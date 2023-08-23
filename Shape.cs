using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
   abstract public class Shape
    {
        public abstract string Draw(string name);
        public abstract void Area();
    }
    public class Calculate : Shape 
    {
        private int length, breadth;
        int area;
       override public string Draw(string name)
        {
            return name;
        }

        public Calculate(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override void Area()
        {
            area = length * breadth;
        
        }

        

        public void Display()
        {
            Console.WriteLine( length+"\t"+breadth+"\nArea of rectangle is:"+area);
        }
     
        
       
        
    }

}
