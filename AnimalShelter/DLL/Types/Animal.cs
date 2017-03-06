using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public EnumClass.Gender gender { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }
        public bool Reserved { get; set; }

        public Animal(string name, int age, EnumClass.Gender gender, decimal weight, decimal price, bool reserved)
        {
            
        }

        public void Sell(Animal animal)
        {
            
        }

        public void SetReserved(Animal animal)
        {
            
        }

        public bool CheckReserved(Animal animal)
        {

            return true;
        }

        public void RemoveReservation(Animal animal)
        {
            
        }
    }
}
