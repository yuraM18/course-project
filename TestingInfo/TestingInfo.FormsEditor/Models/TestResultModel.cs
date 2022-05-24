using System;
using TestingInfo.Entity;

namespace TestingInfo.FormsEditor.Models
{
    public class TestResultModel
    {
        public int Id { get; set; }
        public string Person { get; set; }
        public string Test { get; set; }
        public DateTime? DateTime { get; set; }
        public int? Bales { get; set; }
        public string Result { get; set; }
        public string Note { get; set; }

        public static explicit operator TestResultModel(TestResult inst)
        {
            return new TestResultModel()
            {
                Id = inst.Id,
                Person = inst.Person,
                Test = inst.Test.Name,
                DateTime = inst.DateTime,
                Bales = inst.Bales,
                Result = inst.Result,
                Note = inst.Note
            };
        }
    }
}
