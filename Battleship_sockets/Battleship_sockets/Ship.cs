public class Ship
{
    public string Name { get; set; }
    public int Size { get; set; }
    public Color Color { get; set; }
    public Image Image { get; set; }
    public List<Position> Coords { get; set; }
    public string Orientation { get; set; }

    public Ship(string name, int size, Color color, List<Position> coords, string orientation)
    {
        Name = name;
        Size = size;
        Color = color;
        Coords = coords;
        Orientation = orientation;
    }
}
public class Position
{
    public int Row { get; set; }
    public int Col { get; set; }    
    public bool IsHit { get; set; }

}
