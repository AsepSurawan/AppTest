using EntityFrameworkExtras.EFCore;

namespace AppTest.Services.Models
{
    [UserDefinedTableType("HobiType")]
    public class HobiUDTType
    {
        [UserDefinedTableTypeColumn(1)]
        public string Id { get; set; }

        [UserDefinedTableTypeColumn(2)]
        public string Nama { get; set; }
    }
}
