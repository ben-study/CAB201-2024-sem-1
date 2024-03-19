namespace Week4;

public class Direction
{
    // Insert your solution here, using the XML comments provided as a guide.
    /// <summary>
    /// Parses the specified character and outputs the change in position.
    /// </summary>
    /// <param name="ch">The character to parse.</param>
    /// <param name="xDiff">The change in the horizontal (x) direction.</param>
    /// <param name="yDiff">The change in the vertical (y) direction.</param>
    /// <returns>True if the character is valid; otherwise, false.</returns>
    public static bool TryParse(char ch, out int xDiff, out int yDiff)
    {
        xDiff = 0;
        yDiff = 0;

        switch (char.ToLower(ch))
        {
            case 'n':
                yDiff = 1;
                break;
            case 's':
                yDiff = -1;
                break;
            case 'e':
                xDiff = 1;
                break;
            case 'w':
                xDiff = -1;
                break;
            default:
                return false;
        }

        return true;
    }
}