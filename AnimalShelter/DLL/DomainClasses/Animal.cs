using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender gender { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }
        public bool Reserved { get; set; }
        public bool IsSold { get; set; }
        public Species Species { get; set; }

        public Animal(Species species, string name, int age, Gender gender, decimal weight, decimal price, bool reserved, bool isSold)
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

        public override string ToString()
        {
            return Species + " " + Name + " " + Reserved;
        }
    }
}
