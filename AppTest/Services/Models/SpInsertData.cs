using EntityFrameworkExtras.EFCore;
using System.Data;

namespace AppTest.Services.Models
{
    [StoredProcedure("InsertData")]
    public class SpInsertData
    {
        [StoredProcedureParameter(SqlDbType.Udt, ParameterName = "gender")]
        public List<GenderUDTType> GenderUDTType { get; set; }

        [StoredProcedureParameter(SqlDbType.Udt, ParameterName = "hobi")]
        public List<HobiUDTType> HobiUDTTypes { get; set; }

        [StoredProcedureParameter(SqlDbType.Udt, ParameterName = "person")]
        public List<PersonUDTType> PersonUDTType { get; set; }

        [StoredProcedureParameter(SqlDbType.Udt, ParameterName = "umur")]
        public List<UmurUDTType> UmurUDTType { get; set; }
    }
}
