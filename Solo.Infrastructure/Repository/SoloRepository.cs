using System.Threading.Tasks;
using WriteDomainArticle = Solo.Domain.UI.ArticleAggregate.Write.Article;
using DomainParagraph = Solo.Domain.UI.ArticleAggregate.Paragraph;
using DomainSubtitle = Solo.Domain.UI.ArticleAggregate.Subtitle;
using DomainQuest = Solo.Domain.UI.Game.Quest;
using DomainRegion = Solo.Domain.UI.Game.Region;
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
            var article = await _context.Articles
                .Include(x => x.Quest)
                    .ThenInclude(x => x.Region)
                    .FirstOrDefaultAsync(x => x.Id == id);
                    
            var region = new DomainRegion(article.Quest.Region.Id, article.Quest.Region.Name);
            var quest = new DomainQuest(article.Quest.Id, article.Quest.Name, region);

            return new WriteDomainArticle(
                article.Id,
                article.Title,
                quest,
                article.Paragraphs.Select(x => new DomainParagraph(x.Text)).ToList(),
                article.SubTitles.Select(x => new DomainSubtitle(x.Text)).ToList());
        }
    }
}