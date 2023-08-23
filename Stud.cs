using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public  class Stud
    {
        int num1;
        int num2;
        public Stud()
        {
            num2=num1+num2;
            Console.WriteLine(num2 );
        }
        public Stud(int p,int q)
        {
            int t = p + q;
            Console.WriteLine( t);

        }   
    }
    public class Over
    {
        static void Main(string[] args)
        {
            Stud s1= new Stud();
            Stud s2= new Stud(20,9);
        }
    }
}
