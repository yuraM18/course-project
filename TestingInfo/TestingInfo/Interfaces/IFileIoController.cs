using TestingInfo.Data;

namespace TestingInfo.Interfaces
{
    public interface IFileIoController
    {
        string FileExtension { get; set; }
        void Save(DataSet dataSet, string fileName);
        void Load(DataSet dataSet, string fileName);
    }
}
