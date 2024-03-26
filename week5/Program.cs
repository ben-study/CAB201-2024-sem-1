using System.Drawing;
using week5.TreasureHunt;
using week5.GrowingSphere;
using Point = week5.GrowingSphere.Point;

namespace week5
{
    class Program
    {
        static void Main(string[] args)
        {
            Q2();
        }

        static void Q1()
        {
            // Keep the following lines intact
            Console.WriteLine("===========================");
            TreasureHunt.Hunter hunter;
            TreasureHunt.Vector velocity, hunterPosition, treasurePosition;
            double distance;

            // Insert your solution here
            // 1. Read the hunter's initial position using the ReadPosition() method, and the prompt:
            // "Enter the hunter's initial position X,Y:"
            hunterPosition = ReadVector("Enter the hunter's initial position X,Y:");

            // 2. Create a new hunter at the given position
            hunter = new TreasureHunt.Hunter(hunterPosition);

            // 3. Read the treasure's position using the ReadPosition() method, and the prompt:
            // "Enter the treasure's position X,Y:"
            treasurePosition = ReadVector("Enter the treasure's position X,Y:");

            // 4. Calculate the initial distance between the hunter and the treasure
            // which is the magnitude of the difference between the hunter's position
            // and the treasure's position
            distance = treasurePosition.Subtract(hunterPosition).Magnitude;

            // 5. Read the hunter's velocity from the console and
            // parse it into a Vector using the prompt:
            // "Enter the hunter's velocity X,Y or 0,0 to stop:"
            velocity = ReadVector("Enter the hunter's velocity X,Y or 0,0 to stop:");
            while (velocity.Magnitude != 0)
            {
                // 6. Update the hunter's velocity and move the hunter
                // using the and Move() method
                hunter.Velocity = velocity;
                hunter.Move();

                // 7. Update distance between the hunter and the treasure
                // and display it to the console using the following format:
                // $"The current distance between the hunter and the treasure is: {distance:0.00}"
                distance = treasurePosition.Subtract(hunter.Position).Magnitude;
                Console.WriteLine($"The current distance between the hunter and the treasure is: {distance:0.00}");

                // 8. Read the hunter's velocity from the console again
                // using the same prompt as before:
                velocity = ReadVector("Enter the hunter's velocity X,Y or 0,0 to stop:");
            }

            // Keep the following lines intact
            Console.WriteLine($"The final distance between the hunter and the treasure is: {distance:0.00}");
            Console.WriteLine("===========================");
        }

        static void Q2()
        {
            // Keep the following lines intact
            Console.WriteLine("===========================");
            Point sphereCentre, collisionPoint;
            Sphere sphere;
            List<double> growthRates;
            int secondsElapsed = 0;

            // Insert your solution here
            // 1. Read the sphere centre's position using the GetPoint() method, and the prompt:
            // "Enter the position of the sphere centre X, Y, Z:"
            sphereCentre = ReadPoint("Enter the position of the sphere centre X, Y, Z:");

            // 2. Read the sphere's radius (positive) from the console using the prompt:
            // "Enter the sphere's radius:"
            // You can use the ReadPositiveDouble() method below to help you with this
            double radius = ReadPositiveDouble("Enter the sphere's radius:");

            // 3. Read and parse the sphere's growth rates from the console using the prompt:
            // "Enter the sphere's growth rates, separated by commas:"
            // You may want to implement the ParsePositiveDoubles() method below to help you with this
            Console.WriteLine("Enter the sphere's growth rates, separated by commas:");
            growthRates = ParsePositiveDoubles(Console.ReadLine(), ',');

            // 4. Create a new sphere at the given position with the given radius and growth rates
            sphere = new Sphere(sphereCentre, radius);

            // 5. Read the collision point from the console using the GetPoint() method, and the prompt:
            // "Enter the collision point X, Y, Z:"
            collisionPoint = ReadPoint("Enter the collision point X, Y, Z:");

            // 6. If the collision point is not inside the sphere, do the following:
            if (!sphere.ContainsPoint(collisionPoint))
            {
                // 7. loop through the growth rates
                foreach (double growthRate in growthRates)
                {
                    // 8. For each growth rate, set the sphere's growth rate and grow the sphere
                    sphere.GrowthRate = growthRate;
                    sphere.Grow();

                    // 9. Increment the number of seconds elapsed by 1
                    secondsElapsed++;

                    // 10. Check for collision again. If the collision point is inside the sphere, break out of the loop
                    if (sphere.ContainsPoint(collisionPoint)) break;
                }
            }

            // 11. If the collision point is inside the sphere, display the following message to the console:
            // "The sphere collided with the point and stopped growing."
            // Otherwise, display the following message to the console:
            // "The sphere did not collide with the point."
            if (sphere.ContainsPoint(collisionPoint))
            {
                Console.WriteLine("The sphere collided with the point and stopped growing.");
            }
            else
            {
                Console.WriteLine("The sphere did not collide with the point.");
            }

            // 12. Display the number of seconds elapsed, the sphere's radius and volume to the console
            // using the following format:
            // $"After {secondsElapsed} seconds, the sphere's volume is {sphere.Volume:0.00}"
            // where X is the number of seconds elapsed, and Y is the sphere's volume at the time of collision
            Console.WriteLine($"After {secondsElapsed} seconds, the sphere's volume is {sphere.Volume:0.00}");

            // Keep the following line intact
            Console.WriteLine("===========================");
        }

        static TreasureHunt.Vector ReadVector(string prompt)
        {
            Console.WriteLine(prompt);
            TreasureHunt.Vector result;
            // Get the position from the user
            while (!TreasureHunt.Vector.TryParse(Console.ReadLine(), out result!))
            {
                Console.WriteLine("Invalid input. Vector must be in the form X, Y:");
            }

            return result;
        }


        //..//..// Question 2 helper methods //..//..//
        /// <summary>
        /// Reads an array of positive doubles from the console.
        /// Invalid inputs are ignored.
        /// </summary>
        /// <param name="input">(string) The input string containing the doubles</param>
        /// <param name="separator">(char) The character that separates the doubles</param>
        /// <returns>(List<double>) The array of doubles entered by the user</returns> 
        static List<double> ParsePositiveDoubles(string? input, char separator)
        {
            // Create a new list to store the doubles
            List<double> result = new List<double>();

            // If the input is null, return the empty list
            if (input == null) return result;

            // Split the input into parts using the separator
            string[] parts = input.Split(separator);

            // For each part, try to parse it into a positive double
            // and add it to the list if successful
            foreach (string part in parts)
            {
                if (double.TryParse(part.Trim(), out double value) && value >= 0)
                {
                    result.Add(value);
                }
            }

            // Return the list of doubles parsed from the input
            return result;
        }

        /* The following methods are provided for you. You do not need to modify them. */

        /// <summary>
        /// Reads a point from the console
        /// </summary>
        /// <param name="prompt">(string) The prompt to display to the user</param>
        static Point ReadPoint(string prompt)
        {
            Console.WriteLine(prompt);
            Point result;
            // Get the position from the user
            while (!Point.TryParse(Console.ReadLine(), out result!))
            {
                Console.WriteLine("Invalid input. Point must be in the form X, Y, Z:");
            }

            return result;
        }

        /// <summary>
        /// Reads a positive double from the console
        /// </summary>
        /// <param name="prompt">(string) The prompt to display to the user</param>
        /// <returns>(double) The double entered by the user</returns>
        static double ReadPositiveDouble(string prompt)
        {
            Console.WriteLine(prompt);
            double result;
            // Get the position from the user
            while (!double.TryParse(Console.ReadLine(), out result) || result <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number:");
            }

            return result;
        }
    }
}