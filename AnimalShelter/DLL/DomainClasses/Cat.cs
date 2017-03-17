using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DomainClasses
{
    public class Cat : Animal
    {
        public string Behavior { get; set; }

        public Cat(Species species, string name, int age, Gender gender, decimal weight, decimal price, bool reserved, bool isSold) : base(species, name, age, gender, weight, price, reserved, isSold)
        {
            
        }

        public void SetBehavior(string behavior)
        {
            Behavior = behavior;
        }
    }
}
