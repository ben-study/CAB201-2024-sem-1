namespace Week4.Shapes;

static class Utils
{
    /// <summary>
    /// Reads a position x, y from the user, ensuring that it is a valid position on the canvas.
    /// </summary>
    /// <param name="prompt">The prompt to display to the user.</param>
    /// <param name="canvas">The canvas to check the position against.</param>
    /// <param name="x">The x coordinate of the position.</param>
    /// <param name="y">The y coordinate of the position.</param>
    public static void ReadPosition(string prompt, Canvas canvas, out int x, out int y)
    {
        Console.WriteLine(prompt);
        // Get the position from the user
        while (!ParsePosition(Console.ReadLine(), out x, out y) || !canvas.ContainsPoint(x, y))
        {
            Console.WriteLine("Invalid input. The position must be a valid (x,y) point on the canvas.");
            Console.WriteLine("Enter the position in the form x, y: ");
        }
    }

    /// <summary>
    /// Reads a non-negative integer from the user.
    /// </summary>
    /// <param name="prompt">The prompt to display to the user.</param>
    /// <param name="value">The integer value.</param>
    public static void ReadNonNegativeInteger(string prompt, out int value)
    {
        Console.WriteLine(prompt);
        while (!int.TryParse(Console.ReadLine(), out value) || value < 0)
        {
            Console.WriteLine("Invalid input. The value must be a non-negative integer.");
            Console.WriteLine(prompt);
        }
    }

    /// <summary>
    /// Parses a position in the form "x, y" into two integers.
    /// </summary>
    /// <param name="input">The string containing the coordinates</param>
    /// <param name="x">The x coordinate</param>
    /// <param name="y">The y coordinate</param>
    /// <returns>true if the position was successfully parse, false otherwise.</returns>
    /// </summary>
    public static bool ParsePosition(string? input, out int x, out int y)
    {
        string[] parts = input.Split(',');
        x = 0;
        y = 0;
        // There must be two parts
        if (parts.Length != 2) return false;
        // Both parts must be integers
        if (!int.TryParse(parts[0].Trim(), out x)) return false;
        if (!int.TryParse(parts[1].Trim(), out y)) return false;
        return true;
    }
}