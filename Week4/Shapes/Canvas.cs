namespace Week4.Shapes;

/// <summary>
/// Represents a pixel-based canvas where shapes can be drawn by plotting points.
/// </summary>
public class Canvas
{
    private char[,] canvas;
    public int Size;    

    /// <summary>
    /// Plots a point on the canvas at the given coordinates.
    /// </summary>
    /// <param name="x">The x coordinate</param>
    /// <param name="y">The y coordinate</param>
    public void PlotPoint(int x, int y)
    {
        canvas[y, x] = '#';
    }

    /// <summary>
    /// Creates a new canvas of the given size.
    /// </summary>
    /// <param name="size">The size of the canvas</param>
    public Canvas(int size)
    {
        canvas = new char[size, size];
        for (int y = 0; y < canvas.GetLength(0); y++)
        {
            for (int x = 0; x < canvas.GetLength(1); x++)
            {
                canvas[y, x] = '.';
            }
        }

        Size = size;
    }

    /// <summary>
    /// Checks if the given point is within the canvas.
    /// </summary>
    /// <param name="x">The x coordinate</param>
    /// <param name="y">The y coordinate</param>
    /// <returns>True if the point is within the canvas, false otherwise</returns>
    public bool ContainsPoint(int x, int y)
    {
        return x >= 0 && y >= 0 && x < canvas.GetLength(1) && y < canvas.GetLength(0);
    }

    /// <summary>
    /// Displays the canvas on the console.
    /// </summary>
    public void Display()
    {
        Console.WriteLine("The canvas looks like this:");
        Console.WriteLine(new string('-', canvas.GetLength(1)));
        for (int y = 0; y < canvas.GetLength(0); y++)
        {
            for (int x = 0; x < canvas.GetLength(1); x++)
            {
                Console.Write(canvas[y, x]);
            }

            Console.WriteLine();
        }

        Console.WriteLine(new string('-', canvas.GetLength(1)));
    }
}