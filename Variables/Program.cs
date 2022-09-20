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
            Console.WriteLine("A Totally Original Game and not a poorly coded Space Invaders clone!");
            Console.WriteLine();

            int score; // declaration -- declaring score as an integer.
            score = 0; // initialization -- starting score off at 0.

            int health;
            health = 3; // starting health / lives.

            int healthUp;
            healthUp = 1; // player gained an extra pip of health

            int enemyPoints;
            enemyPoints = 50; // 50 points per enemy killed.

            int enemyDamage;
            enemyDamage = 1; // enemies deal 1 health point of damage.

            int doubleKill;
            doubleKill = 2; // gives bonus points for getting 2 kills in under a few seconds

            float time;
            time = 0.0f; // In game timer, survive as long as you can.

            string gameOver; // Game Over text.

            // ------------------------------------

            Console.WriteLine("Score: " + score); // Displays the current score.
            Console.WriteLine("Time: " + time); // Displays the current time.
            Console.WriteLine();
            Console.WriteLine(" ^ ");
            Console.WriteLine();
            Console.WriteLine("Health: " + health); // Displays the current player health.
            Console.WriteLine(" - - - - - - ");
            Console.WriteLine("(Game Start!)");
            Console.WriteLine(" - - - - - - ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            score = score + enemyPoints; // Player killed an enemy.
            time = 12.44f; // Timer that starts as soon as the game begins.
            Console.WriteLine("Score: " + score); // tells you the score
            Console.WriteLine("Time: " + time); // tells you the time
            Console.WriteLine();
            Console.WriteLine(" ^ ");  // Player Model
            Console.WriteLine();
            Console.WriteLine("Health: " + health); // tells you your health + lives
            Console.WriteLine(" - - - - - - ");
            Console.WriteLine("(Enemy Slain!)");
            Console.WriteLine(" - - - - - - ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            score = score + enemyPoints;
            health = health - enemyDamage; // Player took damage from an enemy.
            time = 23.87f;
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Time: " + time);
            Console.WriteLine();
            Console.WriteLine(" ^ ");
            Console.WriteLine();
            Console.WriteLine("Health: " + health);
            Console.WriteLine(" - - - - - - ");
            Console.WriteLine("(Enemy Slain!)");
            Console.WriteLine("(Watch out, they fight back! Hull Damaged!)");
            Console.WriteLine(" - - - - - - ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            score = score + enemyPoints;
            score = score + enemyPoints * doubleKill; // Player got a double kill and got bonus points.
            health = health - enemyDamage;
            time = 45.66f;
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Time: " + time);
            Console.WriteLine();
            Console.WriteLine("Double Kill!");
            Console.WriteLine();
            Console.WriteLine(" ^ ");
            Console.WriteLine();
            Console.WriteLine("Health: " + health);
            Console.WriteLine(" - - - - - - ");
            Console.WriteLine("(Enemy Slain!)");
            Console.WriteLine("(Missiles! Watch out! Hull Damaged!)");
            Console.WriteLine(" - - - - - - ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            score = score + enemyPoints;
            score = score + enemyPoints * doubleKill; 
            health = health + healthUp; // Player got an extra health point.
            time = 60.63f;
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Time: " + time);
            Console.WriteLine();
            Console.WriteLine("Double Kill!");
            Console.WriteLine();
            Console.WriteLine(" ^ ");
            Console.WriteLine();
            Console.WriteLine("Health: " + health);
            Console.WriteLine(" - - - - - - ");
            Console.WriteLine("(Enemy Slain!)");
            Console.WriteLine("(Shields are recharging! Hull Repair Drones Deployed!)");
            Console.WriteLine(" - - - - - - ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // from here its more or less a loop of the previous steps until you get to the Game Over section.

            score = score + enemyPoints;
            health = health - enemyDamage;
            time = 72.44f;
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Time: " + time);
            Console.WriteLine();
            Console.WriteLine(" ^ ");
            Console.WriteLine();
            Console.WriteLine("Health: " + health);
            Console.WriteLine(" - - - - - - ");
            Console.WriteLine("(Enemy Slain!)");
            Console.WriteLine("(Watch out, they're breaching the shields! Hull Damaged!)");
            Console.WriteLine(" - - - - - - ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            score = score + enemyPoints;
            time = 82.66f;
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Time: " + time);
            Console.WriteLine();
            Console.WriteLine(" ^ ");
            Console.WriteLine();
            Console.WriteLine("Health: " + health);
            Console.WriteLine(" - - - - - - ");
            Console.WriteLine("(Enemy Slain!)");
            Console.WriteLine(" - - - - - - ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            score = score + enemyPoints;
            health = health - enemyDamage;
            time = 89.21f;
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Time: " + time);
            Console.WriteLine();
            Console.WriteLine(" ^ ");
            Console.WriteLine();
            Console.WriteLine("Health: " + health);
            Console.WriteLine(" - - - - - - ");
            Console.WriteLine("(Enemy Slain!)");
            Console.WriteLine("(Hull compromised! Engines are shot! We're going down!)");
            Console.WriteLine(" - - - - - - ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // ------------------------------------

            gameOver = "{> Game Over! <}"; // Game ends, with small animation of player exploding.
            Console.WriteLine(gameOver);
            gameOver = "Restart?";
            Console.WriteLine("* " + gameOver); // Game gives option to begin again or quit. But because this is merely visual studio, you can only quit lol.

            Console.ReadKey(true); // waits for an input to end the program.

        }
    }
}
