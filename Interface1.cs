using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
   public interface Interface1
    {
        string print();
    }
    public interface Interface2
    {
        string print();
    }
    public class Subclass : Interface1, Interface2
    
    {
       string Interface1.print()
        {
            return "This is first Interface";
            
        }
        string Interface2.print()
        {
            return "This is second";
        }
    }
   
}
