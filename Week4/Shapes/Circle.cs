namespace Week4.Shapes;

class Circle : IDrawable
{
    private int x;
    private int y;
    private int radius;

    /// <summary>
    /// Draws the circle on the canvas.
    /// </summary>
    /// <param name="canvas">The canvas to draw on.</param>
    public void Draw(Canvas canvas) {
        for (int y = this.y - radius; y < this.y + radius; y++) {
            for (int x = this.x - radius; x < this.x + radius; x++) {
                // (x - this.x)^2 + (y - this.y)^2 = radius^2
                if (Math.Pow(x - this.x, 2) + Math.Pow(y - this.y, 2) > Math.Pow(radius - 0.5, 2)) continue; 
                if (canvas.ContainsPoint(x,y)) canvas.PlotPoint(x, y);
            }
        }
    }

    /// <summary>
    /// Creates a new circle with the given radius.
    /// </summary>
    /// <param name="x">The x coordinate of the circle's centre.</param>
    /// <param name="y">The y coordinate of the circle's centre.</param>
    /// <param name="radius">The radius of the circle.</param>
    public Circle(int x, int y, int radius) {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }
}