using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public class Hirarical
    {

        protected string type;

        public Hirarical(string type)
        {
            this.type = type;
           
        }

        public string Get()
        {
            return $"{type}";
        }
    }
    public class Cat1 :Hirarical
      {
        private string cat_name;
        private string cat_color;
       private string gender;
       public Cat1(string gender,string cat_name, string cat_color,string type) :base(type)
        {
        this.gender = gender;
        this.cat_name = cat_name;
        this.cat_color = cat_color;
        }

        public void Display()
        {
            Console.WriteLine( gender+"\t"+cat_name+"\t"+cat_color+"\t"+type);
        }
     }

    public class Dog : Hirarical
    {
        private string Dog_name;
        private string Dog_color;
      
        public Dog(string Dog_name,string Dog_color,string type):base(type)
        {
           this.Dog_name = Dog_name;
           this.Dog_color = Dog_color;

        }
       public void Show()
        {
            Console.WriteLine( Dog_name+""+Dog_color+""+type);
        }
    }
}
