namespace ConsoleApp2;
internal class TacoBell
{
    public TacoBell()
    {
            
    }

    public TacoBell(string name, Point location)
    {
        Name = name;
        Location = location;
    }

    public string Name { get; set; }
    public Point Location { get; set; }
}
