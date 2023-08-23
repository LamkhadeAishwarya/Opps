using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public class Account
    {
        int Account_no;
        string name;
        float Ammount;
        float result,result1;

        public void Insert(int Account_no, string name, float Ammount)
        {
            this.Account_no = Account_no;
            this.name = name;
            this.Ammount = Ammount;
          
        }
        public void Display()
        {
            Console.WriteLine( Account_no+"\t"+name+"\t"+Ammount);
        }

        public float Deposit(float dpst)
        {
            
            result=  Ammount + dpst;
            return result;
        }

        public float Withdraw(float wtdr)
        {
         
            result1 = Ammount - wtdr;

            return result1;
        }

        public void CheckBalance()
        {
            Console.WriteLine(Ammount );
            Console.WriteLine(result);
            Console.WriteLine( result1);

        }
    }
}
