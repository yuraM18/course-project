using Common.Context.LineIndents;

namespace Common.Entities
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public static int IdWidth { get; set; }

        static Entity()
        {
            IdWidth = 7;
        }

        public override string ToString()
        {
            return string.Format($"{LineIndent.Current.Value}{Id.ToString().PadLeft(IdWidth)} {MembersString}");
        }

        protected abstract string MembersString { get; }

        public string ToDataString()
        {
            return string.Format($"{LineIndent.Current.Value}{MembersString}");
        }
    }
}
