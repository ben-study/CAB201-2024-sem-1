namespace week5.GrowingSphere;

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    /// <summary>
    /// Creates a new point with the given X, Y and Z coordinates
    /// </summary>
    /// <param name="x">(double) The X coordinate of the point</param>
    /// <param name="y">(double) The Y coordinate of the point</param>
    /// <param name="z">(double) The Z coordinate of the point</param> 
    public Point(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    /// <summary>
    /// Attempts to parse the given string into a point
    /// </summary>
    /// <param name="input">(string) The string to parse</param>
    /// <param name="point">(Point?) The point that was parsed, or null if the parse failed</param>
    /// <returns>(bool) True if the parse succeeded, false otherwise</returns>
    public static bool TryParse(string input, out Point? point)
    {
        // Initialise point to null
        point = null;
        if (input == null) return false;

        // Split the input into parts using the comma as a separator
        string[] coordinates = input.Split(',');

        // If there are not exactly 3 parts, return false
        if (coordinates.Length != 3) return false;

        // Try to parse each part into a double. If any part fails, return false
        if (!double.TryParse(coordinates[0].Trim(), out double x)) return false;
        if (!double.TryParse(coordinates[1].Trim(), out double y)) return false;
        if (!double.TryParse(coordinates[2].Trim(), out double z)) return false;

        point = new Point(x, y, z);
        return true;
    }
}