using System.Collections.Generic;

namespace Solo.Domain.UI.ArticleAggregate.Write
{
    public class Article
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<Paragraph> Paragraphs { get; set; }
        public IEnumerable<Subtitle> Subtitles { get; set; }

        public Article(long id, string title, IEnumerable<Paragraph> paragraphs, IEnumerable<Subtitle> subtitles)
        {
            Id = id;
            Title = title;
            Paragraphs = paragraphs;
            Subtitles = subtitles;
        }
    }
}