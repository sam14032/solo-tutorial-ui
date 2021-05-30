namespace Solo.Domain.UI.Game
{
    public class Region
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public Region(long id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}