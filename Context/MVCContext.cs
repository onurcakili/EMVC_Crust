using EFMVC_odev.Models;
using Microsoft.EntityFrameworkCore;

namespace EFMVC_odev.Context
{
    public class MVCContext : DbContext
    {   //context yapısı SQL ile ilişkilidir.
        public MVCContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Subject> Subjects { get; set; }    // db ile eşleşme yapılıyor
        public DbSet<Teacher> Teachers { get; set; }

    }
}
