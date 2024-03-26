namespace week5.TreasureHunt;

public class Hunter : IMovable
{
    /* Implement the IMovable interface here. Note that the Position property should
    be publicly gettable, but needs to be privately settable. */
    public Vector Position { get; private set; }
    public Vector Velocity { get; set; }
    public void Move()
    {
        Position = Position.Add(Velocity);
    }

    /* Use the XML documentation below to create a constructor */

    /// <summary>
    /// Creates a new hunter at the given position. The hunter's velocity is initially zero in both directions.
    /// </summary>
    /// <param name="position">(Vector) The initial position of the hunter</param>
    public Hunter(Vector position)
    {
        Position = position;
        Velocity = new Vector(0,0);
    }
}