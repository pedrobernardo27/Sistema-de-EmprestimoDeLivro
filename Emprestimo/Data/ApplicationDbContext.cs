using Emprestimo.Models;
using Microsoft.EntityFrameworkCore;

namespace Emprestimo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> optins) : base(optins)
        {            
        }

        public DbSet<EmprestimoModel> Emprestimos { get; set; }
    }
}
