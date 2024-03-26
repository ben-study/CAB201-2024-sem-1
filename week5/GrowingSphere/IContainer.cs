namespace week5.GrowingSphere;

public interface IContainer
{
    /// <summary>
    /// Returns true if the given point is inside the shape
    /// </summary>
    bool ContainsPoint(Point point);
}