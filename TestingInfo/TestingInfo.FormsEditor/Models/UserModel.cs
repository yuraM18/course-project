using TestingInfo.Entity;

namespace TestingInfo.FormsEditor.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string UserLog { get; set; }
        public string UserPass { get; set; }

        public static explicit operator UserModel(User inst)
        {
            return new UserModel()
            {
                Id = inst.Id,
                UserLog = inst.UserLog,
                UserPass = inst.UserPass,
            };
        }
    }
}
