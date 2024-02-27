namespace Week1; // namespace is a way to organize code in C#

abstract class Program // class is a blueprint for creating objects
{
    static void Main(string[] args)
    {
        // Reading I/O
        Console.WriteLine("print out whatever i type in the console: ");
        string? input = Console.ReadLine();
        Console.WriteLine("You typed: " + input);

        // type conversions
        int x = 10;
        double y = x; // implicit conversion
        Console.WriteLine(y);

        double a = 10.5;
        int b = (int)a; // explicit conversion
        Console.WriteLine(b);

        // string to number conversion
        string str = "10";
        int num = Convert.ToInt32(str); // or int.Parse(str); - null exception
        Console.WriteLine(num);

        // number to string conversion
        int number = 10;
        string str2 = number.ToString();
        Console.WriteLine(str2);


        // finding the index of a character in a string
        string s = "Hello World";
        int index = s.IndexOf('W');
        Console.WriteLine(index);


        //Q1
        Console.WriteLine("===========================");
        Console.WriteLine("Hello there, welcome to CAB201.");
        Console.WriteLine("===========================");

        //Q2
        Console.WriteLine("===========================");
        Console.WriteLine("Please supply the distance in miles:");
        // string distanceInput = Console.ReadLine();
        // double distance = Convert.ToDouble(distanceInput);
        double miles = double.Parse(Console.ReadLine()!); // or Convert.ToDouble(Console.ReadLine());
        double kilometres = miles * 1.609344;
        Console.WriteLine("{0:F4} miles is the same as {1:F4} kilometres.", miles, kilometres);
        Console.WriteLine("===========================");


        //Q3
        Console.WriteLine("===========================");
        Console.WriteLine("Please enter the width of the room, in metres:");
        double roomWidth = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter the length of the room, in metres:");
        double roomLength = Convert.ToDouble(Console.ReadLine());
        double roomArea = roomWidth * roomLength;
        Console.WriteLine("The floor area of a {0:F7} by {1:F7} metre room is {2:F7} square metres.",
            roomWidth, roomLength, roomArea);
        Console.WriteLine("===========================");
        
        //Q4
        // Keep the following line intact 
        Console.WriteLine("===========================");
        Console.WriteLine("Please enter a line of text:");
        string? text = Console.ReadLine();
        int firstPos = text.IndexOf('@');
        int lastPos = text.LastIndexOf('@');

        Console.WriteLine("The first and last positions of '@' are {0} and {1}, respectively.",
            firstPos, lastPos);
        Console.WriteLine("===========================");
    }
}