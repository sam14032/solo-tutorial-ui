using System.Threading.Tasks;
using WriteDomainArticle = Solo.Domain.UI.ArticleAggregate.Write.Article;
using DomainParagraph = Solo.Domain.UI.ArticleAggregate.Paragraph;
using DomainSubtitle = Solo.Domain.UI.ArticleAggregate.Subtitle;
using Solo.Domain.SoloRepository;
using Solo.Infrastructure.Context;
using Solo.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Solo.Infrastructure.Repository
{
    public class SoloRepository : ISoloRepository
    {
        ISoloContext _context;
        public SoloRepository(ISoloContext context)
        {
            _context = context;
        }

        public async Task<WriteDomainArticle> GetArticle(long id)
        {
            var article = await _context.Articles.FirstOrDefaultAsync(x => x.Id == id);

            return new WriteDomainArticle(
                article.Id, 
                article.Title, 
                article.Paragraphs.Select(x => new DomainParagraph(x.Text)).ToList(),
                article.SubTitles.Select(x => new DomainSubtitle(x.Text)).ToList());
        }
    }
}