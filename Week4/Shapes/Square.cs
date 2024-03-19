namespace Week4.Shapes;

class Square : IDrawable
{
    private int x, y, size;

    /// <summary>
    /// Draws the square on the canvas.
    /// </summary>
    /// <param name="canvas">The canvas to draw on.</param>
    public void Draw(Canvas canvas)
    {
        for (int y = this.y; y < this.y + size; y++)
        {
            for (int x = this.x; x < this.x + size; x++)
            {
                if (canvas.ContainsPoint(x, y)) canvas.PlotPoint(x, y);
            }
        }
    }

    /// <summary>
    /// Creates a new square with the given side length.
    /// </summary>
    /// <param name="x">The x coordinate of the square's top left corner.</param>
    /// <param name="y">The y coordinate of the square's top left corner.</param>
    /// <param name="radius">The side length of the square.</param>
    public Square(int x, int y, int size)
    {
        this.x = x;
        this.y = y;
        this.size = size;
    }
}