using System.Threading.Tasks;
using ReadDomainArticle = Solo.Domain.UI.ArticleAggregate.Read.Article;

namespace Solo.Domain.SoloRepository
{
    public interface ISoloRepository
    {
         Task<ReadDomainArticle> GetArticle(long id);
    }
}