using Common.Context.Extensions;
using Common.Context.LineIndents;
using Common.Generic.Entities;
using Common.Interfaces;
using System;

namespace TestingInfo.Entity
{
    public class TestResult : Entity<TestResult>, IStringIdentified
    {
        static TestResult()
        {
            EntityName = "Облік тестування";
            EntityPluralName = "Облік тестування";
        }

        private Test test;

        private string person;
        public DateTime? DateTime { get; set; }
        private int? bales;
        public string Result { get; set; }
        public string Note { get; set; }

        public Test Test
        {
            get { return test; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Tests");
                }
                test = value;
            }
        }

        public string StringIdentifier => Person;

        protected override string MembersString
        {
            get
            {
                return string.Format($"{base.MembersString}" +
              $"{LineIndent.Current.Value}ПІБ особи: {Person}\n" +
              $"{LineIndent.Current.Value}Назва тесту: {(Test == null ? "" : Test.Name)}\n" +
              $"{LineIndent.Current.Value}Дата і час: {DateTime}\n" +
              $"{LineIndent.Current.Value}Кількість балів: {Bales}\n" +
              $"{LineIndent.Current.Value}Результати тесту: {Result}\n" +
              $"{LineIndent.Current.Value}Примітка: {(string.IsNullOrWhiteSpace(Note) ? "" : Note.ToIndentadLineBlock())}\n");
            }
        }

        public string Person
        {
            get { return person; }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("Person");
                }
                person = value;
            }
        }

        public static int MAX_BALES = Test.MAX_BALES;

        public int? Bales
        {
            get { return bales; }
            set
            {
                if (value < 0 || value > MAX_BALES)
                {
                    throw new ArgumentOutOfRangeException();
                }
                bales = value;
            }
        }

        public TestResult(string person, Test test, DateTime? dateTime, int? bales)
        {
            Person = person;
            this.Test = test;
            DateTime = dateTime;
            Bales = bales;
        }

        public TestResult(string person, Test tests)
            : this(person, tests, null, null) { }

        public TestResult() { }
    }
}
