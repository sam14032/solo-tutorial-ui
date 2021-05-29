namespace Solo.Domain.UI.ArticleAggregate.Read
{
    public class Article
    {
        public long Id { get; set; }

        public Article(long id)
        {
            Id = id;
        }
    }
}