namespace Solo.Domain.UI.Game
{
    public class Quest
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Region Region { get; set; }

        public Quest(long id, string name, Region region)
        {
            Id = id;
            Name = name;
            Region = region;
        }
    }
}