namespace Week3;

public class Triangle
{
    private double side1;
    private double side2;
    private double side3;

    /// <summary>
    /// This method returns the type of the triangle based on the lengths of its sides.
    /// e.g. if all sides are equal, it returns "Equilateral"
    /// e.g. if two sides are equal, it returns "Isosceles"
    /// e.g. if no sides are equal, it returns "Scalene"
    /// </summary>
    /// <returns></returns>
    public string GetType()
    {
        if (side1 == -1 || side2 == -1 || side3 == -1) return "Invalid";
        if (side1 == side2 && side2 == side3)
        {
            return "Equilateral";
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }

    /// <summary>
    /// This method returns the Area of the triangle
    /// e.g. if the sides are 3, 4, 5, it returns 6
    /// </summary>
    /// <returns></returns>
    public double GetArea()
    {
        if (side1 == -1 || side2 == -1 || side3 == -1) return -1;
        if (side1 == 0 || side2 == 0 || side3 == 0) return 0;
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    /// <summary>
    /// the first constructor sets all sides to 1
    /// meaning it creates an equilateral triangle
    /// </summary>
    /// <param name="side1"></param>
    public Triangle(double side1)
    {
        this.side1 = side1;
        side2 = side1;
        side3 = side1;
    }

    /// <summary>
    /// the second constructor sets a base side, a height and the other two sides are calculated
    /// meaning it creates an isosceles triangle
    /// </summary>
    /// <param name="baseSide"></param>
    /// <param name="height"></param>
    public Triangle(double baseSide, double height)
    {
        side1 = baseSide;
        side2 = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(baseSide / 2, 2));
        side3 = side2;
    }

    /// <summary>
    /// the third constructor sets all sides
    /// meaning it creates a scalene triangle
    /// </summary>
    /// <param name="side1"></param>
    /// <param name="side2"></param>
    /// <param name="side3"></param>
    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }
}