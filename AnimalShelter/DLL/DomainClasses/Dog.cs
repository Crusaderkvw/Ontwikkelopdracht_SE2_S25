using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Types
{
    class Dog : Animal
    {
        public DateTime LastWalk { get; set; }

        public Dog(Species species, string name, int age, Gender gender, decimal weight, decimal price, bool reserved, bool isSold) : base(species, name, age, gender, weight, price, reserved, isSold)
        {
            
        }

        public void SetWalkingDate(DateTime datetime)
        {
            
        }
    }
}
