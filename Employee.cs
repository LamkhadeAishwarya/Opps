using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
   /** public class Employee
    {
        protected string name;
        protected int id;
        protected double salary, hra, da, ta, pf, gross,bonus;

        public Employee(string name, int id, double salary, double hra, double da, double ta, double pf,double bonus)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
            this.hra = hra;
            this.da = da;
            this.ta = ta;
            this.pf = pf;
            this.bonus= bonus;
        
        }

        public virtual double Calculate()
        {
            hra = salary * 0.87;
            da = salary * 56.8;
            ta = salary * 78.9;
            pf = salary * 89.8;
            gross = (salary + hra + da + ta) - pf;
     
            return gross;
        }

        public virtual string print()
        {
            return $"Employee Gross{gross}";
        }
    }

    public class Manager : Employee
    {
        private double FoodAllow;
        public Manager(double FoodAllow, string name,int id, double salary,double hra,double da,double ta,double pf) : base(name, id,salary,hra,da,ta,pf)
        {
            this.FoodAllow = FoodAllow;
        }

        public override double Calculate()
        {
            hra = salary * 0.87;
            da = salary * 56.8;
            ta = salary * 78.9;
            pf = salary * 89.8;
            gross = (salary + hra + da + ta+FoodAllow) - pf;

            return gross;

        }

        public override string print()
        {
            return $"Gross Manager{gross}";
        }






    }**/



    }



