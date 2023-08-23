using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public class StaticVariable
    {
        int x = 56;
        static int y = 20;

        public void Show()
        {
            Console.WriteLine(x+""+y);
        }

        public static void Display()

         {
            StaticVariable c6= new StaticVariable();
            Console.WriteLine( c6.x);
            Console.WriteLine( y);


        }   
            
            
           }
}
