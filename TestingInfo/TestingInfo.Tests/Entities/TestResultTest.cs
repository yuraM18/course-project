using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingInfo.Entity;
using TestResult = TestingInfo.Entity.TestResult;

namespace TestingInfo.Tests.Entities
{
    [TestClass]
    public class TestResultTest
    {
        [TestMethod]
        public void TestResult_IsEntity()
        {
            // arrange
            string person = "Іванов Микола";
            User user = new User("admin", "admin");
            Test test = new Test("Ієрархія класів", null, user);
            // act
            TestResult inst = new TestResult(person, test);
            // assert
            Assert.IsInstanceOfType(inst, typeof(Common.Entities.Entity));
        }

        [TestMethod]
        public void TestResult_InstanceCreated()
        {
            // arrange
            string person = "Іванов Микола";
            User user = new User("admin", "admin");
            Test test = new Test("Ієрархія класів", null, user);
            // act
            TestResult inst = new TestResult(person, test);
            // assert
            Assert.IsNotNull(inst);
        }

        [TestMethod]
        public void TestResult_IsSetted()
        {
            // arrange
            string person = "Іванов Микола";
            User user = new User("admin", "admin");
            Test test = new Test("Ієрархія класів", null, user);
            // act
            TestResult inst = new TestResult(person, test);
            // assert
            Assert.AreEqual(person, inst.Person);
        }

        [TestMethod]
        public void TestResult_Result_ContainsPersonName()
        {
            // arrange
            string person = "Іванов Микола";
            User user = new User("admin", "admin");
            Test test = new Test("Ієрархія класів", null, user);
            // act
            TestResult inst = new TestResult(person, test);
            string result = inst.ToString();
            // assert
            Assert.IsTrue(result.Contains(person));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSet_null_ArgNullEx()
        {
            // arrange
            string person = "Іванов Микола";
            User user = new User("admin", "admin");
            Test test = new Test("Ієрархія класів", null, user);
            // act
            TestResult inst = new TestResult(person, test);
            Test newTest = null;
            // assert
            inst.Test = newTest;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PersonSet_null_ArgEx()
        {
            // arrange
            string person = "Іванов Микола";
            User user = new User("admin", "admin");
            Test test = new Test("Ієрархія класів", null, user);
            // act
            TestResult inst = new TestResult(person, test);
            string newPerson = null;
            // assert
            inst.Person = newPerson;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PersonSet_Empty_ArgEx()
        {
            // arrange
            string person = "Іванов Микола";
            User user = new User("admin", "admin");
            Test test = new Test("Ієрархія класів", null, user);
            // act
            TestResult inst = new TestResult(person, test);
            string newPerson = "";
            // assert
            inst.Person = newPerson;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BalesSet_minus1_ArgOutRangeEx()
        {
            // arrange
            string person = "Іванов Микола";
            User user = new User("admin", "admin");
            Test test = new Test("Ієрархія класів", null, user);
            int bales = 5;
            // act
            TestResult inst = new TestResult(person, test);
            inst.Bales = bales;
            int newBales = -1;
            // assert
            inst.Bales = newBales;
        }

    }
}
