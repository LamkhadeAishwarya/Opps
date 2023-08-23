using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    //Interface Implementation
    public interface IceCream
    {
        void eat();
    }
    public interface juice
    {
        void Drink();
    }
    public class Mastani : IceCream, juice
    { 
        public void eat()
        {
            Console.WriteLine( "Its IceCream Interface");
        }
        public void Drink()
        {
            Console.WriteLine("Its Juice Interface");
        }
    }

   
    

    
    
        
    
    
}
