using Microsoft.EntityFrameworkCore;
using GYMSHARK_KC_MVC.Models;

namespace GYMSHARK_KC_MVC.Data
{
    public class KCContext : DbContext
    {
        public KCContext(DbContextOptions<KCContext> options) : base(options) { }

        public DbSet<KCProducto> KCProductos { get; set; }
    }
}
