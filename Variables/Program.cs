using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");
            Console.WriteLine();

            // integers -- Whole Numbers. Nothing Else.
            int score; // declaration -- declare "score" as an integer
            score = 0; // initialization -- starting "score" off at 0
            int health;
            health = 3;
            int enemyPoints;
            enemyPoints = 50; // 100 points per enemy killed
            Console.WriteLine("Score: " + score); // display score
            Console.WriteLine("Health: " + health);
            Console.WriteLine();

            score = score + enemyPoints;
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + health);
            Console.WriteLine();

            // floating points -- integer but can take decimals up to the 7th decimal place
            float lapTime;
            lapTime = 0.0f;
            Console.WriteLine("Lap Time: " + lapTime);
            lapTime = 33.294f;
            Console.WriteLine("Lap Time: " + lapTime);
            Console.WriteLine();

            // string -- text
            string name;
            name = "Serena";
            Console.WriteLine("Name: " + name);
            name = "Serena Burnett";
            Console.WriteLine("Name: " + name);
            Console.WriteLine();

            Console.ReadKey(true);

        }
    }
}
