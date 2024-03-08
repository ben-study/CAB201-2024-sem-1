namespace Week2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Week 2 Content");
        // just uncomment the function name in the main function to run the code
        // Q1();
        // Q2();
        // Q3();
        Q4();
    }

    static void Q1()
    {
        // Keep the following lines intact 
        Console.WriteLine("===========================");

        const string prompt = "Please enter the wind speed (km/h):";
        const string outFormat = "If the wind speed is {0} then {1}.";

        Console.WriteLine(prompt);
        string? userInput = Console.ReadLine();
        int windSpeed = int.Parse(userInput!);

        string message = "";

        if (windSpeed >= 252) message = "cataclysmic damage will occur";
        else if (windSpeed >= 209) message = "catastrophic damage will occur";
        else if (windSpeed >= 178) message = "devastating damage will occur";
        else if (windSpeed >= 154) message = "extremely dangerous winds cause extensive damage";
        else if (windSpeed >= 119) message = "very dangerous winds will produce some damage";
        else message = "the damage from winds is minimal";

        // If you want to use a switch statement, you can use the following code
        // switch (windSpeed)
        // {
        //     case var n when (n >= 252):
        //         message = "cataclysmic damage will occur";
        //         break;
        //     case var n when (n >= 209):
        //         message = "catastrophic damage will occur";
        //         break;
        //     case var n when (n >= 178):
        //         message = "devastating damage will occur";
        //         break;
        //     case var n when (n >= 154):
        //         message = "extremely dangerous winds cause extensive damage";
        //         break;
        //     case var n when (n >= 119):
        //         message = "very dangerous winds will produce some damage";
        //         break;
        //     default:
        //         message = "the damage from winds is minimal";
        //         break;
        // }
        // Keep the following lines intact
        Console.WriteLine(outFormat, windSpeed, message);
        Console.WriteLine("===========================");
    }

    static void Q2()
    {
        // Keep the following line intact 
        Console.WriteLine("===========================");

        const string prompt = "Please enter the result code, an integer between 1 and 7:";
        const string outFormat = "Result code {0} is classified as '{1}'.";

        Console.WriteLine(prompt);
        string? userInput = Console.ReadLine();
        int resultCode = int.Parse(userInput!);

        string description = "";

        switch (resultCode)
        {
            case 7:
                description = "High Distinction";
                break;
            case 6:
                description = "Distinction";
                break;
            case 5:
                description = "Credit";
                break;
            case 4:
                description = "Pass";
                break;
            case 3:
                description = "Failure";
                break;
            case 2:
                description = "Failure";
                break;
            case 1:
                description = "Failure";
                break;
            default:
                description = "Invalid";
                break;
        }

        // Keep the following line intact
        Console.WriteLine(outFormat, resultCode, description);
        Console.WriteLine("===========================");
    }

    static void Q3()
    {
        // Keep the following lines intact 
        Console.WriteLine("===========================");

        const int sentinel = 999;
        string prompt = $"Please enter a value to process, or {sentinel} to finish:";
        const string outFormat = "The sum is {0}.";

        long runningTotal = 0;

        while (true)
        {
            Console.WriteLine(prompt);
            string? userInput = Console.ReadLine();

            if (userInput == sentinel.ToString()) break;

            if (int.TryParse(userInput, out var currentVal))
            {
                runningTotal += currentVal; // runningTotal = runningTotal + currentVal
            }
        }

        // Keep the following lines intact
        Console.WriteLine(outFormat, runningTotal);
        Console.WriteLine("===========================");
    }

    static void Q4()
    {
        // Keep the following lines intact 
        Console.WriteLine("===========================");

        const string PROMPT = "Enter a value between 1 and 27:";
        const string OUT_FORMAT = "{0} factorial is {1}.";

        Console.WriteLine(PROMPT);
        string? userInput = Console.ReadLine();
        decimal limit = decimal.Parse(userInput!);

        // decimal factorial = 1;
        //
        // for (decimal i = limit - 1; i > 0; i--)
        // {
        //     factorial *= i;
        // }


        // or //
        decimal factorial = Factorial(limit); // call the Factorial function    
        


        // Keep the following lines intact
        Console.WriteLine(OUT_FORMAT, userInput, limit);
        Console.WriteLine("===========================");
    }

    static decimal Factorial(decimal n)
    {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }
}