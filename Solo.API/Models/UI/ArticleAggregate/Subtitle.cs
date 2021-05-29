using DomainSubtitle = Solo.Domain.UI.ArticleAggregate.Subtitle;

namespace Solo.API.Models.UI.ArticleAggregate
{
    public class Subtitle
    {
        public string Text { get; set; }

        public Subtitle(string text)
        {
            Text = text;
        }

        public DomainSubtitle ConvertToDomain()
        {
            return new DomainSubtitle(Text);
        }
    }
}