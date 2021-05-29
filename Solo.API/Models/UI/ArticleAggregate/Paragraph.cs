using DomainParagraph = Solo.Domain.UI.ArticleAggregate.Paragraph;

namespace Solo.API.Models.UI.ArticleAggregate
{
    public class Paragraph
    {
        public string Text { get; set; }

        public Paragraph(string text)
        {
            Text = text;
        }

        public DomainParagraph ConvertToDomain()
        {
            return new DomainParagraph(Text);
        }
    }
}