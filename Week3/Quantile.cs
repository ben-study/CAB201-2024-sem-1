namespace Week3;

public class Quantile
{
    public static void QuantileActivity()
    {
        // Keep the following line intact 
        Console.WriteLine("===========================");

        // Insert your solution here.
        Console.WriteLine("Enter the number of values: ");
        int len = int.Parse(Console.ReadLine());
        if (len <= 0)
        {
            Console.WriteLine("Error: number of values must be greater than 0.");
        }
        else
        {
            double[] arr = new double[len];
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Enter a value: ", i + 1);
                arr[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the number to find the quantile of: ");
            double num = double.Parse(Console.ReadLine());
            int quantileCount = 0;
            for (int i = 0; i < len; i++)
            {
                if (arr[i] <= num)
                {
                    quantileCount++;
                }
            }

            double quantile = Math.Round((double)quantileCount / len, 2);
            Console.WriteLine("The quantile of {0} for the given values is {1}.", num, quantile);
        }

        // Keep the following line intact
        Console.WriteLine("===========================");
    }
}