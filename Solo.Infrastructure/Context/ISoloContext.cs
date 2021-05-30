using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Solo.Infrastructure.Entity;

namespace Solo.Infrastructure.Context
{
    public interface ISoloContext
    {
        DbSet<Article> Articles { get; set; }
        DbSet<SubTitle> SubTitles { get; set; }
        DbSet<Paragraph> Paragraphs { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}