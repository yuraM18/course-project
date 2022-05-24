using System.Collections.Generic;
using System.Linq;
using TestingInfo.Entity;
using TestingInfo.FormsEditor.Models;

namespace TestingInfo.FormsEditor.Extensions
{
    public static class ModelMethods
    {
        public static User ToUser(this UserModel inst, IEnumerable<User> tests)
        {
            //return new Test(inst.Name, tests.FirstOrDefault(e => e.Name == inst.Topic))
            return new User(inst.UserLog, inst.UserPass)
            {
                Id = inst.Id
            };
        }

        public static Test ToTest(this TestModel inst, IEnumerable<User> tests)
        {
            //return new Test(inst.Name, tests.FirstOrDefault(e => e.Name == inst.Topic))
            return new Test(inst.Name, inst.Topic, tests.FirstOrDefault(e => e.UserLog == inst.User))
            {
                Id = inst.Id,
                Bales = inst.MaxBales,
                Description = inst.Description
            };
        }

        public static TestResult ToTestResult(this TestResultModel inst, IEnumerable<Test> testResults )
        {
            return new TestResult(inst.Person, testResults.FirstOrDefault(e => e.Name == inst.Test),
                inst.DateTime, inst.Bales){
                Id = inst.Id,
                Result = inst.Result,
                Note = inst.Note
            };
        }
    }
}
