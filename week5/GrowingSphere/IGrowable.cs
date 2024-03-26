namespace week5.GrowingSphere;

public interface IGrowable
{
    // <summary>
    /// The rate at which the shape grows
    /// </summary>
    double GrowthRate { get; set; }

    /// <summary>
    /// The current volume of the shape
    /// </summary>
    double Volume { get; }

    /// <summary>
    /// Increases the size of the shape by the growth rate multiplicatively
    /// </summary>
    void Grow();
}