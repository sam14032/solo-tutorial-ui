using System.Collections.Generic;

namespace Solo.Infrastructure.Entity
{
    public class Region
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<Quest> Quests { get; set; }
    }
}