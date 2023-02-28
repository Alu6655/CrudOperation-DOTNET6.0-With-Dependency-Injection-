using Microsoft.EntityFrameworkCore;

namespace Core.Models
{
    public class AnxietyEntities :DbContext
    {
        public AnxietyEntities(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Anxiety_RegPatient> Anxiety_RegPatients { get; set; }
    }
}
