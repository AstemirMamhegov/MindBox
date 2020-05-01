using System;
using GameLibrary.Exceptions;
using GameLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameLibrary.Test
{
    [TestClass]
    public class HeroTests
    {
        [TestMethod]

        public void TestConstructor()
        {
            string name = "Artas";
            Hero hero = new Hero(name);

            string actual = hero.Name;

            Assert.AreEqual(name, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(IncorrectNameException))]
        public void TestConstructorShortName()
        {
            string name = "Ar";
            Hero hero = new Hero(name);
        }
        [TestMethod]
        [ExpectedException(typeof(IncorrectNameException))]
        public void TestConstructorLongName()
        {
            string name = "ArtasGetOverPower";
            Hero hero = new Hero(name);
        }

        [TestMethod]
        public void TestConstructorNormalHp()
        {
            int hp = 500;
            Hero hero = new Hero( hp);
            int actual = hero.HealthPoints;
            Assert.AreEqual(hp, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(GameException))]
        public void TestConstructorOverHp()
        {
            int hp = 10500;
            Hero hero = new Hero( hp);
        }

        [TestMethod]
        public void TestConstructorNormalDPS()
        {
            double dps = 1000;
            Hero hero = new Hero(dps);
            double actual = hero.DamagePerSecond;
            Assert.AreEqual(dps, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(GameException))]
        public void TestConstructorIncorrectDPS()
        {
            double dps = -1000;
            Hero hero = new Hero(dps);
        }
    }
}
