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
        public Gender Gender { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }
        public bool Reserved { get; set; }
        public bool IsSold { get; set; }
        public Species Species { get; set; }

        public Animal(Species species, string name, int age, Gender gender, decimal weight, decimal price, bool reserved, bool isSold)
        {
            Species = species;
            Name = name;
            Age = age;
            Gender = gender;
            Weight = weight;
            Price = price;
            Reserved = reserved;
            IsSold = isSold;
        }

        public void Sell(Animal animal)
        {
            animal.IsSold = true;
        }

        public void SetReserved(Animal animal)
        {
            animal.Reserved = true;
        }

        public bool CheckReserved(Animal animal)
        {
            return animal.Reserved;
        }

        public void RemoveReservation(Animal animal)
        {
            animal.Reserved = false;
        }

        public override string ToString()
        {
            return "Species: " + Species + " " + "Name: " + Name + " " + "Reserved: " + Reserved;
        }
    }
}
