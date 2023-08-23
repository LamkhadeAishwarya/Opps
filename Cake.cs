using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public interface Cake
    {
         void Bake();
    }
    public class Strawberry : Cake
    {
        public void Bake() 
        {
            Console.WriteLine( "Its strawberry");
        }

    }

    public class BlackForest : Cake
    {
        public void Bake()
        {
            Console.WriteLine("Its BlackForest");
        }
    }
}
