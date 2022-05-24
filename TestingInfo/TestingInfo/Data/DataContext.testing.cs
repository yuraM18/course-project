using System;
using System.Linq;
using TestingInfo.Entity;

namespace TestingInfo.Data
{
    partial class DataContext
    {
        public void CreateTestingData()
        {
            CreateTestUsers();
            CreateTestTests();
            CreateTestTestResult();
            OnDataChanged();
        }

        private void CreateTestUsers()
        {
            Users.Add(new User("admin", "admin")
            {
                Id = 1,
            });
            Users.Add(new User("yura", "yura")
            {
                Id = 2,
            });
            Users.Add(new User("123456", "123456")
            {
                Id = 3,
            });
        }

        private void CreateTestTestResult()
        {
            TestResults.Add(new TestResult("Бакута Віталій",
                Tests.First(e => e.Name == "Технології"), new DateTime(2020, 03, 02, 12, 44, 0), 4)
            {
                Id = 1,
            });
            TestResults.Add(new TestResult("Бакута Віталій",
                Tests.First(e => e.Name == "Перші технології"), new DateTime(2020, 03, 02, 12, 44, 0), 4)
            {
                Id = 1,
            });
            TestResults.Add(new TestResult("Барабаш Валерія",
                Tests.First(e => e.Name == "Перші технології"))
            {
                Id = 2,
                Bales = 5,
            });
            TestResults.Add(new TestResult("Булега Віталій",
                Tests.First(e => e.Name == "Украіїна в 20 роки 20 ст."), new DateTime(2020, 03, 02, 12, 44, 0), 4)
            {
                Id = 3,
            });
            TestResults.Add(new TestResult("Ярошевський Олександр",
                Tests.First(e => e.Name == "Технології"))
            {
                Id = 4,
                Bales = 4,
            });
        }

        private void CreateTestTests()
        {
            Tests.Add(new Test("Украіїна в 20 роки 20 ст.", "Історія України", Users.First(e => e.UserLog == "admin"))
            {
                Id = 1,
                Bales = 5,
            });
            Tests.Add(new Test("Нові технології","Технології", Users.First(e => e.UserLog == "yura"))
            {
                Id = 2,
                Bales = 5,
            });
            Tests.Add(new Test("Перші технології","Технології", Users.First(e => e.UserLog == "admin"))
            {
                Id = 3,
                Bales = 5,
            });
            Tests.Add(new Test("Технології","Технології", Users.First(e => e.UserLog == "admin"))
            {
                Id = 4,
                Bales = 5,
            });

            Tests.Add(new Test("Past Simple", "Англ мова", Users.First(e => e.UserLog == "admin"))
            {
                Id = 5,
                Bales = 5,
            });
            Tests.Add(new Test("Present Simple", "Англ мова", Users.First(e => e.UserLog == "admin"))
            {
                Id = 6,
                Bales = 5,
            });
            Tests.Add(new Test("Соняна активність", "Географія", Users.First(e => e.UserLog == "admin"))
            {
                Id = 7,
                Bales = 5,
            });
            Tests.Add(new Test("Психічна складова здоров'я", "Психологія", Users.First(e => e.UserLog == "admin"))
            {
                Id = 8,
                Bales = 5,
            });
            Tests.Add(new Test("Духовна складова здоров'я", "Психологія", Users.First(e => e.UserLog == "admin"))
            {
                Id = 9,
                Bales = 5,
            });
            Tests.Add(new Test("Усний рахунок", "Математика", Users.First(e => e.UserLog == "admin"))
            {
                Id = 10,
                Bales = 5,
            });
            Tests.Add(new Test("Квадратні рівняння", "Математика", Users.First(e => e.UserLog == "admin"))
            {
                Id = 11,
                Bales = 5,
            });
            Tests.Add(new Test("Лінійні рівняння", "Математика", Users.First(e => e.UserLog == "admin"))
            {
                Id = 12,
                Bales = 5,
            });
            Tests.Add(new Test("Глобальна економіка", "Екноміка", Users.First(e => e.UserLog == "admin"))
            {
                Id = 13,
                Bales = 5,
            });
            Tests.Add(new Test("Алгоритми", "Програмуваня", Users.First(e => e.UserLog == "admin"))
            {
                Id = 14,
                Bales = 5,
            });
        }
    }
}
