using EntityFrameworkExtras.EFCore;


namespace AppTest.Services.Models
{
    [UserDefinedTableType("PersonalType")]
    public class PersonUDTType
    {
        [UserDefinedTableTypeColumn(1)]
        public int Id { get; set; }

        [UserDefinedTableTypeColumn(2)]
        public string Nama { get; set; }

        [UserDefinedTableTypeColumn(3)]
        public int IdGender {  get; set; }

        [UserDefinedTableTypeColumn(4)]
        public string IdHobi {  get; set; }

        [UserDefinedTableTypeColumn(5)]
        public int Umur {  get; set; }
        
    }
}
