using DomainArticle = Solo.Domain.UI.ArticleAggregate.Read.Article;

namespace Solo.API.Models.UI.ArticleAggregate.Read
{
    public class Article
    {
        public long Id { get; set; }

        public Article(long id)
        {
            Id = id;
        }

        public DomainArticle ConvertToDomain()
        {
            return new DomainArticle(Id);
        }
    }
}