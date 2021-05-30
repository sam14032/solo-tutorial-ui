using System.Threading.Tasks;
using WriteDomainArticle = Solo.Domain.UI.ArticleAggregate.Write.Article;

namespace Solo.Domain.SoloRepository
{
    public interface ISoloRepository
    {
         Task<WriteDomainArticle> GetArticle(long id);
    }
}