using PessoasModel;
using Microsoft.EntityFrameworkCore;

namespace PessoasData
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<PessoasModel.PessoasModel> Pessoas { get; set; }
    }
}