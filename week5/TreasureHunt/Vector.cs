namespace week5.TreasureHunt;

public class Vector
{
    /// <summary>
    /// (double) The X component of the vector
    /// </summary>
    public double X { get; set; }

    /// <summary>
    /// (double) The Y component of the vector
    /// </summary>
    public double Y { get; set; }

    /// <summary>
    /// (double) The Euclidean length of the vector
    /// </summary>
    /// <remarks>
    /// The magnitude of a vector is the square root of the sum of the squares of its components, i.e.:
    /// magnitude = sqrt(x^2 + y^2)
    /// </remarks>
    public double Magnitude 
    {
        get
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }
    
    /// <summary>
    /// Creates a new vector with the given X and Y components
    /// </summary>
    /// <param name="x">(double) The X component of the vector</param>
    /// <param name="y">(double) The Y component of the vector</param>
    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }

    /// <summary>
    /// Adds the given vector to this vector to create a new vector
    /// </summary>
    /// <param name="other">(Vector) The vector to add to this vector</param>
    /// <returns>(Vector) The sum of the two vectors</returns>
    public Vector Add(Vector other)
    {
        return new Vector(X + other.X, Y + other.Y);
    }

    /// <summary>
    /// Subtracts the given vector from this vector to create a new vector
    /// </summary>
    /// <param name="other">(Vector) The vector to subtract from this vector</param>
    /// <returns>(Vector) This vector after the subtraction</returns>
    public Vector Subtract(Vector other)
    {
        return new Vector(X - other.X, Y - other.Y);
    }

    /* The following methods are provided for you. Do not modify it.*/

    /// <summary>
    /// Attempts to parse the given string into a vector
    /// </summary>
    /// <param name="input">(string) The string to parse</param>
    /// <param name="result">(out Vector?) The parsed vector, or null if the string was invalid</param>
    /// <returns>(bool) True if the string was parsed successfully, false otherwise</returns>
    /// <remarks>
    /// The string should be in the format "X,Y" where X and Y are doubles
    /// </remarks>
    public static bool TryParse(string? input, out Vector? result)
    {
        result = null;
        if (input == null) return false;
        string[] parts = input!.Split(',');
        if (parts.Length != 2) return false;
        if (!double.TryParse(parts[0].Trim(), out double x)) return false;
        if (!double.TryParse(parts[1].Trim(), out double y)) return false;
        result = new Vector(x, y);
        return true;
    }
}