using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
   public class StaticMethod
    {
        public static string name;
        public static int id;
        public static void Get()
        {
            Console.WriteLine( "Enter id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(id);
            //Console.WriteLine( "Enter name");
            //string name=Console.ReadLine();
           // Console.WriteLine(name);
        }

        public static void Show()
        {
            Console.WriteLine( id);
           
       
        }
        public static void show()
        {
            name = "Tanuja";
            Console.WriteLine( name);
          
        }
    }
}
