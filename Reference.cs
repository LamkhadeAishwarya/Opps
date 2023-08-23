using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public class Reference
    {
         public static void Swap(ref int a, ref int b)
        {
           int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 45;
            int b = 78;
            Swap(ref a, ref b);
            Console.WriteLine( "After Swapping value of"+a+"Value of B"+b);

        }
    }
    

   
}
