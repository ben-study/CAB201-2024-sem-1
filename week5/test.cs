using System;

enum ShapeType
{
    Square, // 0
    Triangle // 1
}

namespace week5
{
    // public class Shape
    // {
    //     public void Draw(int size, int shapetype)
    //     {
    //         // for (int i = 0; i < size; i++)
    //         // {
    //         //     for (int j = 0; j < size; j++)
    //         //     {
    //         //         if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
    //         //             Console.Write("*");
    //         //         else
    //         //             Console.Write(" ");
    //         //     }
    //         //
    //         //     Console.WriteLine();
    //         // }
    //
    //         // if its a square we can use the following code
    //         if (shapetype == (int)ShapeType.Square)
    //         {
    //             for (int i = 0; i < size; i++)
    //             {
    //                 for (int j = 0; j < size; j++)
    //                 {
    //                     if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
    //                         Console.Write("*");
    //                     else
    //                         Console.Write(" ");
    //                 }
    //
    //                 Console.WriteLine();
    //             }
    //         }
    //         else if (shapetype == (int)ShapeType.Triangle)
    //         {
    //             for (int i = 0; i < size; i++)
    //             {
    //                 for (int j = 0; j < size; j++)
    //                 {
    //                     if (i == size - 1 || j == 0 || j == i)
    //                         Console.Write("*");
    //                     else
    //                         Console.Write(" ");
    //                 }
    //
    //                 Console.WriteLine();
    //             }
    //         }
    //     }
    // }
    
    public interface Shape
    {
        void Draw(int size);
    }
    

    public class Square : Shape
    {
        public int size;

        public Square(int size)
        {
            this.size = size;
        }

        // public void Draw()
        // {
        //     Console.WriteLine("Drawing a square:");
        //     Draw(size, (int)ShapeType.Square);
        // }

        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }

    public class Triangle : Shape
    {
        public int size;

        public Triangle(int size)
        {
            this.size = size;
        }

        // public void Draw()
        // {
        //     Console.WriteLine("Drawing a triangle:");
        //     Draw(size, (int)ShapeType.Triangle);
        // }
        
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == size - 1 || j == 0 || j == i)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(10);
            square.Draw(5);

            Triangle triangle = new Triangle(5);
            triangle.Draw(15);
        }
    }
}