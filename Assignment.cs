using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public interface Assignment
    {
        string print();
    }
    public class Employee : Assignment
    {
        public string print()
        {
            return "This is Employee Detatils";
        }
    }
    public class Manager : Assignment
    {
        public string print()
        {
            return "This is Manager Detatls";
        }
    }
    public class Student : Assignment
    {
        public string print()
        {
            return "This is Student Detatls";
        }
    }

}
