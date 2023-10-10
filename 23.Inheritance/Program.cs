using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    
       internal class Chef
       { 
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes Chicken");

        }
        public void MakeSalad()
        {
            Console.WriteLine("The chef makes a salad");
        }
        public virtual void MakeSpecialDish() //virtual allows subclasses to override
        {
            Console.WriteLine("The Chef makes special dish");

        }
        internal class ItalianChef : Chef //this makes Italian Chef inheritall there is in Chef, can now call methods in chef!                                           
        {
            public void MakePasta()
            {
                Console.WriteLine("Makes Pasta");
            }
            public override void MakeSpecialDish() //use keyword override
            {
                Console.WriteLine("The chef makes Italianspecials");
            }


           
       }
    }
}
