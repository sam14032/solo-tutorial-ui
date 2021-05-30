using System.Collections.Generic;
using Solo.Domain.UI.Game;

namespace Solo.Domain.UI.ArticleAggregate.Write
{
    public class Article
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public Quest Quest { get; set; }
        public IEnumerable<Paragraph> Paragraphs { get; set; }
        public IEnumerable<Subtitle> Subtitles { get; set; }

        public Article(long id, string title, Quest quest, IEnumerable<Paragraph> paragraphs, IEnumerable<Subtitle> subtitles)
        {
            Id = id;
            Title = title;
            Quest = quest;
            Paragraphs = paragraphs;
            Subtitles = subtitles;
        }
    }
}