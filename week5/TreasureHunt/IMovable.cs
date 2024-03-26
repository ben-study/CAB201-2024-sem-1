namespace week5.TreasureHunt;

public interface IMovable
{
    /// <summary>
    /// The position of the movable object (read-only)
    /// </summary>
    Vector Position { get; }

    /// <summary>
    /// The velocity of the movable object (read-write)
    /// </summary>
    Vector Velocity { get; set; }

    /// <summary>
    /// Moves the object according to its velocity
    /// </summary>
    /// <remarks>
    /// The object's position should be updated by adding its velocity to its position
    /// </remarks>
    void Move();
}