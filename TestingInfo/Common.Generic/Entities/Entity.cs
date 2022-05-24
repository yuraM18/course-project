using Common.Context.LineIndents;
using Common.Entities;

namespace Common.Generic.Entities
{
    public abstract class Entity<T> : Entity where T : class
    {
        public static string EntityName { get; set; }
        public static string EntityPluralName { get; set; }

        public sealed override string ToString()
        {
            return string.Format($"{LineIndent.Current.Value}{EntityName}\n{MembersString}");
        }

        protected override string MembersString
        {
            get
            {
                return string.Format($"{LineIndent.Current.Value}Id: {Id}\n");
            }
        }
    }
}
