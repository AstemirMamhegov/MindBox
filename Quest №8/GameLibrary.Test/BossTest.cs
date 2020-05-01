using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLibrary;
using GameLibrary.Exceptions;

namespace GameLibrary.Test
{
    [TestClass]
    public class BossTest
    {
        [TestMethod]
        
        public void TestConstructor()
        {
            string expected = "Jack";
            Boss boss = new Boss(expected);

            string actual = boss.Name;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(IncorrectNameException))]
        public void TestConstructorShortName()
        {
            string name = "Ja";
            Boss boss = new Boss(name);
        }
        [TestMethod]
        [ExpectedException(typeof(IncorrectNameException))]
        public void TestConstructorLongName()
        {
            string name = "JackSuperStarBoss";
            Boss boss = new Boss(name);
        }


        [TestMethod]
        public void TestConstructorNormalHp()
        {
            int hp = 500;
            Boss boss = new Boss(hp);
            int actual = boss.HealthPoints;
            Assert.AreEqual(hp, actual);
        }
        [TestMethod] 
        [ExpectedException(typeof(GameException))]
        public void TestConstructorOverHp()
        {
            int hp = 10500;
            Boss boss = new Boss(hp);
        }


        [TestMethod]
        public void TestConstructorNormalDPS()
        {
            double dps = 1000;
            Boss boss = new Boss(dps);
            double actual = boss.DamagePerSecond;
            Assert.AreEqual(dps, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(GameException))]
        public void TestConstructorIncorrectDPS()
        {
            double dps = -1000;
            Boss boss = new Boss(dps);
        }
    }
}
