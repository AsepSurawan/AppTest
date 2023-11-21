using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTest.Data.Entity
{
    [Table("tblM_gender")]
    public class MsGender
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        [Column("Nama")]
        public string Name { get; set; }
    }
}
