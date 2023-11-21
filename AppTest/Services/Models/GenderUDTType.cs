using EntityFrameworkExtras.EFCore;

namespace AppTest.Services.Models
{
    [UserDefinedTableType("genderType")]
    public class GenderUDTType
    {
        [UserDefinedTableTypeColumn(1)]
        public int Id { get; set; }

        [UserDefinedTableTypeColumn(2)]
        public string Nama { get; set; }
    }
}
