using Common.Context.LineIndents;
using Common.Generic.Entities;
using Common.Interfaces;
using System;

namespace TestingInfo.Entity
{
    public class User : Entity<User>,
        IStringIdentified, IComparable<User>
    {

        static User()
        {
            EntityName = "Користувач";
            EntityPluralName = "Користувач";
        }

        private string userLog;
        private string pass;

        public string StringIdentifier => UserLog;

        public User(string log, string pass)
        {
            UserLog = log;
            UserPass = pass;
        }

        protected override string MembersString
        {
            get
            {
                return string.Format($"{base.MembersString}" +
                    $"{LineIndent.Current.Value}Логін: {UserLog}\n" +
                    $"{LineIndent.Current.Value}Пароль: {UserPass}\n");
            }
        }

        public string UserLog
        {
            get { return userLog; }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("UserLOG");
                }
                userLog = value;
            }
        }

        public string UserPass
        {
            get { return pass; }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("UserPass");
                }
                pass = value;
            }
        }

        public int CompareTo(User other)
        {
            if (other == null)
                return 1;
            return this.UserLog.CompareTo(other.UserLog);
        }
    }
}
