using week5.GrowingSphere;

namespace week5.TreasureHunt;

class Sphere : IContainer, IGrowable
{
    private Point centre;
    private double radius;
    public double GrowthRate { get; set; }

    public double Volume
    {
        get { return 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3); }
    }

    public bool ContainsPoint(Point point)
    {
        return Math.Pow(point.X - centre.X, 2) + Math.Pow(point.Y - centre.Y, 2) + Math.Pow(point.Z - centre.Z, 2) <=
               Math.Pow(radius, 2);
    }

    public void Grow()
    {
        radius *= GrowthRate;
    }

    /// <summary>
    /// Creates a new sphere with the given centre and radius
    /// </summary>
    /// <param name="centre">The centre of the sphere</param>
    /// <param name="radius">The radius of the sphere</param>
    public Sphere(Point centre, double radius)
    {
        this.centre = centre;
        this.radius = radius;
        GrowthRate = 0;
    }
}