using System.Collections.Generic;
using TestingInfo.Entity;

namespace TestingInfo.Data
{
    public class DataSet
    {
        public List<TestResult> TestResults { get; private set; }
        public List<Test> Tests { get; private set; }
        public List<User> Users { get; private set; }

        public DataSet()
        {
            Users = new List<User>();
            TestResults = new List<TestResult>();
            Tests = new List<Test>();
        }
    }
}
