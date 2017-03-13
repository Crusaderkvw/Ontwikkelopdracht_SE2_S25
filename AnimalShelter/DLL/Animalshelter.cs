using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.Types;

namespace DLL
{
    public static class Animalshelter
    {

        public static List<Animal> AnimalList { get; private set; }

        static Animalshelter()
        {
            AnimalList = new List<Animal>();
        }

        public static void AddAnimal(object species, string Name, object gender, int Age, decimal Weight, bool Reserved, decimal Price)
        {
            switch ((Species)species)
            {
                case Species.Cat:
                    AnimalList.Add(new Cat((Species)species, Name, Age, (Gender)gender, Weight, Price, Reserved, false));
                    break;
                case Species.Dog:
                    AnimalList.Add(new Dog((Species)species, Name, Age, (Gender)gender, Weight, Price, Reserved, false));
                    break;
            }
        }

        private static void Update()
        {
            
        }

        private static void ReserveAnimal()
        {
            
        }
    }
}
