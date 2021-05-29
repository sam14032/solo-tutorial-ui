using System.Collections.Generic;

namespace Solo.API.Models.UI.ArticleAggregate.Write
{
    public class Article
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<Subtitle> subtitles { get; set; }
        public IEnumerable<Paragraph> paragraphs { get; set; }

        public Article(long id)
        {
            Id = id;
        }

    }
}