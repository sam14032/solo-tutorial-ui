using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Solo.Infrastructure.Entity;

namespace Solo.Infrastructure.Context
{
    public class SoloContext : DbContext, ISoloContext
    {
        public SoloContext(DbContextOptions<SoloContext> options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<SubTitle> SubTitles { get; set; }
        public DbSet<Paragraph> Paragraphs { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().HasKey(x => x.Title);
        }
    }
}