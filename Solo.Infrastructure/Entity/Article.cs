using System.Collections.Generic;

namespace Solo.Infrastructure.Entity
{
    public class Article
    {
        public long Id { get; set; }
        public string Title { get; set; }

        public Quest Quest { get; set;}
        public ICollection<SubTitle> SubTitles { get; set; }
        public ICollection<Paragraph> Paragraphs { get; set; }
    }
}