using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTest.Data.Entity
{
    [Table("tblT_Umur")]
    public class MsUmur
    {
        public int Umur { get; set; }
        public int Total { get; set; }
    }
}
