namespace CrossStitchApp.Models
{
    public class Tile
    {
        public string? Color { get; set; }
        public bool Stitched { get; set; } = false;

        public Tile(string Color, bool Stitched) 
        {
            this.Color = Color;
            this.Stitched = Stitched;
        }

        public Tile() { }
    }
}
