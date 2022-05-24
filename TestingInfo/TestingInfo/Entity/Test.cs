using Common.Context.Extensions;
using Common.Context.LineIndents;
using Common.Generic.Entities;
using Common.Interfaces;
using System;

namespace TestingInfo.Entity
{
    public class Test : Entity<Test>,
        IStringIdentified, IComparable<Test>
    {
        static Test()
        {
            EntityName = "Тести";
            EntityPluralName = "Тести";
        }

        private User user;

        private string name;
        public string Topic { get; set; }
        private int? bales;
        public static int MAX_BALES = 100;
        public string Description { get; set; }

        public string StringIdentifier => Name;

        public Test(string test, string topic, User user)
        {
            Name = test;
            Topic = topic;
            this.User = user; 
        }

        protected override string MembersString
        {
            get
            {
                return string.Format($"{base.MembersString}" +
                    $"{LineIndent.Current.Value}Назва: {Name}\n" +
                    $"{LineIndent.Current.Value}Назва теми: {Topic}\n" +
                    $"{LineIndent.Current.Value}User: {(User == null ? "" : User.UserLog)}\n" +
                    $"{LineIndent.Current.Value}Максимальна кількість балів: {Bales}\n" +
                    $"{LineIndent.Current.Value}Опис:" +
                    $" {(string.IsNullOrWhiteSpace(Description) ? "" : Description.ToIndentadLineBlock())}\n");
            }
        }

        public User User
        {
            get { return user; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Users");
                }
                user = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("Test");
                }
                name = value;
            }
        }
         
        public int? Bales
        {
            get { return bales; }
            set
            {
                if (value < 0 || value >= MAX_BALES)
                {
                    throw new ArgumentOutOfRangeException();
                }
                bales = value;
            }
        }

        public int CompareTo(Test other)
        {
            if (other == null)
                return 1;
            return this.Name.CompareTo(other.Name);
        }

        public Test() { }
    }
}
