using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.DomainClasses;

namespace DLL
{
    public static class Animalshelter
    {

        public static List<Animal> AnimalList { get; private set; }
        public static List<Customer> CustomerList { get; private set; }

        static Animalshelter()
        {
            AnimalList = new List<Animal>();
        }

        public static void AddAnimal(object species, string name, object gender, int age, decimal weight, bool reserved, decimal price)
        {
            switch ((Species)species)
            {
                case Species.Cat:
                    AnimalList.Add(new Cat((Species)species, name, age, (Gender)gender, weight, price, reserved, false));
                    break;
                case Species.Dog:
                    AnimalList.Add(new Dog((Species)species, name, age, (Gender)gender, weight, price, reserved, false));
                    break;
            }
        }

        public static void AddCustomer(string name, object country, string streetname, int housenr)
        {
            CustomerList.Add(new Customer(name, (Country)country, streetname, housenr));
        }

        public static void Update()
        {
            
        }

        public static void ReserveAnimal(object animal, object customer)
        {
            
        }
    }
}
