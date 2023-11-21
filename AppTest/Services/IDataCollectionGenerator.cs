using AppTest.Services.Models;

namespace AppTest.Services
{
    public interface IDataCollectionGenerator
    {
        Task<List<DataCollectionGeneratorRequest>> GetData();
        Task<bool> SaveData(List<DataCollectionGeneratorRequest> data);
    }
}
