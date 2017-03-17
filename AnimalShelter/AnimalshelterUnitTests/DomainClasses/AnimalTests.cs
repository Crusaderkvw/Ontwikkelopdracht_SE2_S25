using DLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DLL.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Tests
{
    [TestClass()]
    public class AnimalTests
    {
        [TestMethod()]
        public void AnimalTest()
        {
            Dog dog = new Dog(Species.Dog, "kevin", 22, Gender.Male, 85, 10, false, false);
            Assert.AreEqual("kevin", dog.Name);
            Assert.AreEqual(dog.Species, Species.Dog);
            Assert.AreEqual(dog.Age, 22);
            Assert.AreEqual(dog.Gender, Gender.Male);
            Assert.AreEqual(dog.Reserved, false);
        }
    }
}