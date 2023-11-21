using AppTest.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace AppTest.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
       : base(options)
        {

        }

        public DbSet<MsGender> Genders { get; set; }
    }
}
