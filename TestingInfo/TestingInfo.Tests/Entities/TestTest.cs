using System;
using Common.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingInfo.Entity;

namespace TestingInfo.Tests.Entities
{
    [TestClass]
    public class TestTest
    {
        [TestMethod]
        public void Test_InstanceCreated()
        {
            //
            string name = "Укрїна в 20 роки 20 століття";
            User user = new User("admin", "admin");
            //
            Test inst = new Test(name, null, user);
            //
            Assert.IsNotNull(inst);
        }

        [TestMethod]
        public void Test_IsEntity()
        {
            //
            string name = "Укрїна в 20 роки 20 століття";
            User user = new User("admin", "admin");
            //
            Test inst = new Test(name, null, user);
            //
            Assert.IsInstanceOfType(inst, typeof(Common.Entities.Entity));
        }

        [TestMethod]
        public void Test_IsStringIdentified()
        {
            //
            string name = "Укрїна в 20 роки 20 століття";
            User user = new User("admin", "admin");
            //
            Test inst = new Test(name, null, user);
            //
            Assert.IsInstanceOfType(inst, typeof(IStringIdentified));
        }

        [TestMethod]
        public void Test_IsSetted()
        {
            //
            string name = "Укрїна в 20 роки 20 століття";
            User user = new User("admin", "admin");
            //
            Test inst = new Test(name, null, user);
            //
            Assert.AreEqual(name, inst.Name);
        }

        [TestMethod]
        public void Test_Result_ContainsPersonName()
        {
            //
            string name = "Укрїна в 20 роки 20 століття";
            User user = new User("admin", "admin");
            //
            Test inst = new Test(name, null, user);
            string result = inst.ToString();
            //
            Assert.IsTrue(result.Contains(name));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSet_null_ArgNullEx()
        {
            //
            string name = "Укрїна в 20 роки 20 століття";
            User user = new User("admin", "admin");
            //
            Test inst = new Test(name, null, user);
            string newTest = null;
            // assert
            inst.Name = newTest;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSet_Empty_ArgNullEx()
        {
            //
            string name = "Укрїна в 20 роки 20 століття";
            User user = new User("admin", "admin");
            //
            Test inst = new Test(name, null, user);
            string newTest = "";
            // assert
            inst.Name = newTest;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BalesSet_minus1_ArgOutRangeEx()
        {
            //
            string name = "Укрїна в 20 роки 20 століття";
            int bales = 5;
            User user = new User("admin", "admin");
            //
            Test inst = new Test(name, null, user);
            inst.Bales = bales;
            int newBales = -1;
            // assert
            inst.Bales = newBales;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BalesSet_MaxPlus1_ArgOutRangeEx()
        {
            //
            string name = "Укрїна в 20 роки 20 століття";
            int bales = 5;
            User user = new User("admin", "admin");
            //
            Test inst = new Test(name, null, user);
            inst.Bales = bales;
            int newBales = Test.MAX_BALES + 1;
            // assert
            inst.Bales = newBales;
        }
    }
}
