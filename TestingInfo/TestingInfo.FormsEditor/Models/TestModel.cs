using TestingInfo.Entity;

namespace TestingInfo.FormsEditor.Models
{
    public class TestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Topic { get; set; }
        public string User { get; set; }
        public int? MaxBales { get; set; }
        public string Description { get; set; }

        public static explicit operator TestModel(Test inst)
        {
            return new TestModel()
            {
                Id = inst.Id,
                Name = inst.Name,
                Topic = inst.Topic,
                User = inst.User.UserLog,
                MaxBales = inst.Bales,
                Description = inst.Description
            };
        }
    }
}
