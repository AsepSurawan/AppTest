using AppTest.Data;
using AppTest.Helpers;
using AppTest.Services.Models;
using EntityFrameworkExtras.EFCore;

namespace AppTest.Services
{
    public class DataCollectionGenerator : IDataCollectionGenerator
    {
        private readonly ApplicationDBContext _context;
        public DataCollectionGenerator(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<List<DataCollectionGeneratorRequest>> GetData()
        {
            try
            {
                var result = new List<DataCollectionGeneratorRequest>();

                for (int i = 0; i < 1000; i++)
                {
                    var genderId = 1;
                    if (i % 2 == 0)
                    {
                        genderId = 1;
                    }
                    else
                    {
                        genderId = 2;
                    }

                    var hobbyId = GeneratedHelper.GetRandAlphabet(1);
                    result.Add(new DataCollectionGeneratorRequest
                    {
                        Name = GeneratedHelper.GetRandAlphanumeric(8),
                        GenderId = genderId,
                        GenderName = ConstantHelpers.Gender[genderId],
                        HobbyId = hobbyId,
                        HobbyName = ConstantHelpers.Hobby[hobbyId],
                        Age = GeneratedHelper.GetRandomInt(18, 40),
                    });
                }

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<bool> SaveData(List<DataCollectionGeneratorRequest> data)
        {
            try
            {
                var gender = data.GroupBy(x => x.GenderId).Select(p => new GenderUDTType
                {
                    Id = p.Key,
                    Nama = p.FirstOrDefault().GenderName
                }).ToList();

                var hobi = data.GroupBy(p => p.HobbyId).Select(p => new HobiUDTType
                {
                    Id = p.Key,
                    Nama = p.FirstOrDefault().HobbyName
                }).ToList();

                var person = data.Select((p, index) => new PersonUDTType
                {
                    Id = index,
                    Nama = p.Name,
                    IdGender = p.GenderId,
                    IdHobi = p.HobbyId,
                    Umur = p.Age,
                }).ToList();

                var umur = data.GroupBy(p => p.Age).Select(p => new UmurUDTType
                {
                    Umur = p.Key,
                    Total = p.Count()
                }).ToList();

                var procedure = new SpInsertData()
                {
                    GenderUDTType = gender,
                    HobiUDTTypes = hobi,
                    PersonUDTType = person,
                    UmurUDTType = umur
                };

                _context.Database.ExecuteStoredProcedure(procedure);

                return Task.FromResult(true);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
