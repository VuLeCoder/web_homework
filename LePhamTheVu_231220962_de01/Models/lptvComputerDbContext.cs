using Microsoft.EntityFrameworkCore;
using System.Data;
using LePhamTheVu_231220962_de01.Models;

namespace LePhamTheVu_231220962_de01.Models.ComputerDBModels
{
    public class lptvComputerDbContext : DbContext
    {
        public lptvComputerDbContext(DbContextOptions<lptvComputerDbContext> options) : base(options) { }
        public DbSet<lptvComputer> lptvComputer { get; set; } = default!;


    }
}
