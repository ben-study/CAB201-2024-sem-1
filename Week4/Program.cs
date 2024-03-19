namespace Week4;

class Program
{
    static void Main(string[] args)
    {
        Q7();
    }

    static void Q1()
    {
        // Keep the following line intact 
        Console.WriteLine("===========================");
        int vowels;
        int consonants;
        Console.WriteLine("Enter a word: ");

        // Insert your solution here
        // Call the TryCount method, outputting the counts of vowels and consonants into the vowels and consonants variables
        // If the TryCount method returns true, display "There are {vowels} vowels and {consonants} consonants in the given word."
        if (Word.TryCount(Console.ReadLine(), out vowels, out consonants))
        {
            Console.WriteLine($"There are {vowels} vowels and {consonants} consonants in the given word.");
        }
        // If the TryCount method returns false, display the prompt "Invalid input. The word must not contain any non-alphabetic characters."
        else
        {
            Console.WriteLine("Invalid input. The word must not contain any non-alphabetic characters.");
        }

        // Keep the following line intact
        Console.WriteLine("===========================");
    }


    /// <summary>
    /// Question 2 
    /// </summary>
    static void Q2()
    {
        // Keep the following lines intact 
        Console.WriteLine("===========================");
        int x = 0, y = 0;
        int distance;
        Console.WriteLine("Enter a path consisting of N, S, E, W: ");
        string path = Console.ReadLine();

        // Insert your solution here
        // Loop through each character in the path
        for (int i = 0; i < path.Length; i++)
        {
            // Call the TryParse method for the current character, providing the character and using out parameters to get the change in position (xDiff, yDiff)
            // If the TryParse method returns true, update the current position (x and y) by adding xDiff to x and yDiff to y
            if (Direction.TryParse(path[i], out int xDiff, out int yDiff))
            {
                x += xDiff;
                y += yDiff;
            }
            // If the TryParse method returns false, display the message "Could not parse a character."
            else
            {
                Console.WriteLine("Could not parse a character.");
            }
        }

        // Calculate the Manhattan distance from the into the variable called distance
        distance = Math.Abs(x) + Math.Abs(y);

        // Keep the following lines intact
        Console.WriteLine($"The Manhattan distance from the origin is {distance}.");
        Console.WriteLine("===========================");
    }

    /// <summary>
    /// Question 3 Median Temperature
    /// </summary>
    static void Q3()
    {
        static void Main(string[] args)
        {
            // Keep the following line intact 
            Console.WriteLine("===========================");

            List<double> temperatures = new List<double>();

            while (true)
            {
                Console.WriteLine("Please enter a temperature reading, or {0} to finish:", "99999999");
                string userInput = Console.ReadLine();

                if (userInput.Trim() == "99999999")
                {
                    break;
                }

                double temp = double.Parse(userInput);
                temperatures.Add(temp);
            }

            if (temperatures.Count == 0)
            {
                Console.WriteLine("Median is not defined for an empty list.");
            }
            else
            {
                temperatures.Sort();

                int n = temperatures.Count;
                List<double> x = temperatures;
                double median;

                if (n % 2 != 0)
                {
                    median = x[n / 2];
                }
                else
                {
                    median = (x[n / 2] + x[n / 2 - 1]) / 2;
                }

                Console.WriteLine("The median is {0:f2} degrees.", median);
            }

            // Keep the following line intact
            Console.WriteLine("===========================");
        }
    }

    /// <summary>
    /// csv parser
    /// </summary>
    static void Q4()
    {
        // Keep the following line intact 
        Console.WriteLine("===========================");

        Console.WriteLine("Please enter a list of integer values separated by commas:");
        string userInput = Console.ReadLine().Trim();

        Console.WriteLine("---------------------------");

        if (userInput.Length == 0)
        {
            Console.WriteLine("The supplied list is empty.");
        }
        else
        {
            string[] parts = userInput.Split(',');
            int[] values = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                values[i] = int.Parse(parts[i]);
            }

            for (int i = 0; i < values.Length; i++)
            {
                int val = values[i];
                Console.WriteLine("The square of {0} is {1}.", val, val * val);
            }
        }

        // Keep the following line intact
        Console.WriteLine("===========================");
    }


    /// <summary>
    /// Commission List
    /// </summary>
    static void Q5()
    {
        // Keep the following line intact 
        Console.WriteLine("===========================");

        // Insert your solution here.
        const string prompt = "Sale value:";
        List<int> sales = new List<int>();
        List<decimal> commissions = new List<decimal>();

        Console.WriteLine("Number of sales:");
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(prompt);
            int sale = int.Parse(Console.ReadLine());
            sales.Add(sale);
        }

        decimal commission = 0;
        foreach (int sale in sales)
        {
            if (sale > -1 && sale <= 15000)
            {
                commission = sale * 0.05M;
            }
            else if (sale > 15000 && sale <= 24000)
            {
                commission = sale * 0.07M;
            }
            else if (sale > 24000)
            {
                commission = sale * 0.10M;
            }

            commissions.Add(commission);
        }

        // Output
        Console.WriteLine("---------------------------");
        Console.WriteLine("Your commissions:");

        for (int z = 0; z < commissions.Count(); z++)
        {
            Console.WriteLine($"Commission on sale {sales[z].ToString("C")} = {commissions[z].ToString("C")}");
        }

        string totalCommission = commissions.Sum().ToString("C");
        Console.WriteLine($"Total commission = {totalCommission}");

        // Keep the following line intact
        Console.WriteLine("===========================");
    }

    /// <summary>
    /// Ph Indicator
    /// </summary>
    static void Q6()
    {
        // Keep the following line intact
        Console.WriteLine("===========================");
        IPHIndicator litmus, turmeric, universal;

        // Insert your solution here.
        // Prompt user for pH value (a double) using the following message:
        // "Enter the pH value of your solution:"
        Console.WriteLine("Enter the pH value of your solution:");

        // If the user enters anything that cannot be parsed to a double,
        // print "Invalid input." and prompt again.
        double ph;
        while (!double.TryParse(Console.ReadLine(), out ph))
        {
            Console.WriteLine("Invalid input.");
        }

        // Create an instance of Litmus, Turmeric and UniversalIndicator.
        litmus = new Litmus();
        turmeric = new Turmeric();
        universal = new UniversalIndicator();

        // Set the pH value of the three instances to the user input.
        litmus.SetPh(ph);
        turmeric.SetPh(ph);
        universal.SetPh(ph);

        // Print the color of the three instances using the following message:
        // "The litmus paper turns {color} under this pH."
        // "The turmeric solution turns {color} under this pH."
        // "The universal indicator turns {color} under this pH."
        Console.WriteLine($"The litmus paper turns {litmus.getColor()} under this pH.");
        Console.WriteLine($"The turmeric solution turns {turmeric.getColor()} under this pH.");
        Console.WriteLine($"The universal indicator turns {universal.getColor()} under this pH.");

        // Keep the following line intact
        Console.WriteLine("===========================");
    }


    static void Q7()
    {
        // Keep the following lines intact
        Console.WriteLine("===========================");
        Shapes.IDrawable square, circle;

        // Insert your solution here
        // Read the canvas size with ReadCanvasSize()
        int canvasSize = ReadCanvasSize();

        // Create a new canvas with the size read from the user
        Shapes.Canvas canvas = new Shapes.Canvas(canvasSize);

        // Read the square x, y, and side length with ReadSquareProperties()
        ReadSquareProperties(canvas, out int squareX, out int squareY, out int squareSize);

        // Read the circle x, y, and radius with ReadCircleProperties()
        ReadCircleProperties(canvas, out int circleX, out int circleY, out int radius);

        // Create a new square with the x, y, and side length above
        square = new Shapes.Square(squareX, squareY, squareSize);

        // Create a new circle with the x, y, and radius above
        circle = new Shapes.Circle(circleX, circleY, radius);

        // Draw the square and circle on the canvas using their Draw() methods
        square.Draw(canvas);
        circle.Draw(canvas);

        // Keep the following lines intact
        canvas.Display();
        Console.WriteLine("===========================");
    }

    public static void ReadSquareProperties(Shapes.Canvas canvas, out int x, out int y, out int size)
    {
        // Insert your solution here
        Shapes.Utils.ReadPosition("Enter the position of the square in the form x,y: ", canvas, out x, out y);
        Shapes.Utils.ReadNonNegativeInteger("Enter the side length of the square: ", out size);
    }

    public static void ReadCircleProperties(Shapes.Canvas canvas, out int x, out int y, out int radius)
    {
        // Insert your solution here
        Shapes.Utils.ReadPosition("Enter the position of the circle in the form x,y: ", canvas, out x, out y);
        Shapes.Utils.ReadNonNegativeInteger("Enter the radius of the circle: ", out radius);
    }

    public static int ReadCanvasSize()
    {
        Console.WriteLine("Enter the canvas size: ");
        int canvasSize;
        while (!int.TryParse(Console.ReadLine(), out canvasSize) || canvasSize <= 0)
        {
            Console.WriteLine("Invalid input. The canvas size must be a positive integer.");
            Console.WriteLine("Enter the canvas size: ");
        }

        return canvasSize;
    }
}