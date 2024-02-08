using System.Net.Sockets;

namespace Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int space, star, count = 1, rows;
            Console.WriteLine("Entered number will draw half of a diamond, the program will finish it");
            Console.Write("Enter a number: ");
            rows = int.Parse(Console.ReadLine());
            //asks the user to input a number that signifies the size of the first half

            //code below draws a triangle
            count = rows - 1;
            for (star = 1; star <= rows; star++)
            //loop controls number of rows in the triangle, where 'rows' is the maximum number
            {
                for (space = 1; space <= count; space++)
                    Console.Write(" ");
                //prints spaces before stars, decreasing with the variable 'count'
                count--;
                //the number of spaces decreases with the help of 'count' variable
                for (space = 1; space <= 2 * star - 1; space++)
                    Console.Write("*");
                //this prints the stars
                Console.WriteLine();
                //line break
            }
            

            //code below draws the second half of the triangle, making a diamond
            count = 1;
            //changes the variable from 'count = rows - 1' to count = 1
            for (star = 1; star <= rows - 1; star++)
            //does the same as before, but rows changes from '1' to '-1' to be able to make an inverse triangle
            {
                for (space = 1; space <= count; space++)
                    Console.Write(" ");
                //prints spaces before stars in each row, increasing with the variable 'count'
                count++;
                //the number of spaces increases with the help of 'count' variable
                for (space = 1; space <= 2 * (rows - star) - 1; space++)
                    Console.Write("*");
                //this prints the stars
                Console.WriteLine();
                //line break
            }
            Console.ReadLine();

        }
    }
}
