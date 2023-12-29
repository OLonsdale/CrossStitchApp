namespace CrossStitchApp.Models
{
    public class SaveFile
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public Tile[] Data { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public HashSet<string> Colors { get; set; } = new();
        public DateTime FirstSaved { get; set; }
        public DateTime LastSaved { get; set; }

    }
}
