using EntityFrameworkExtras.EFCore;

namespace AppTest.Services.Models
{
    [UserDefinedTableType("UmurType")]
    public class UmurUDTType
    {
        [UserDefinedTableTypeColumn(1)]
        public int Umur { get; set; }

        [UserDefinedTableTypeColumn(2)]
        public int Total { get; set; }
    }
}
