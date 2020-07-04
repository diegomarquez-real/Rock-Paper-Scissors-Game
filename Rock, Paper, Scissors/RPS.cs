using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors
{
    public class RPS
    {
        public void rock(string input)
        {
            string[] ran = new string[] { "rock", "paper", "scissors" };

            Menu m = new Menu();

            Random random = new Random();

            bool temps = true;

            int r = random.Next(0, 2);

            string rps = ran[r];

            if (rps == "paper")
            {
                Console.WriteLine("\n" + input + " < " + rps + ": You lost!");
            }

            if (rps == "scissors")
            {
                Console.WriteLine("\n" + input + " > " + rps + ": You won!");
            }

            if (rps == "rock")
            {
                Console.WriteLine("\n" + input + " = " + rps + ": It's a tie!");
            }

            do 
            { 
            Console.WriteLine("\nWant to play again?");
            Console.WriteLine("\nEnter 'Y' for yes, 'N' for no!");
            Console.Write("\n'Y' or 'N': ");
            string yesorno = Console.ReadLine();
            string temp2 = yesorno.ToLower();
            
            
            if (temp2 == "y")
            {
                temps = false;
                Console.WriteLine();
                m.menu();
                
            }
            if (temp2 == "n")
            {
                temps = false;
                Console.WriteLine("\nPlay again soon!");
                Console.WriteLine("\nPress enter once to exit.");
            }
            else
            {
                Console.WriteLine("\nPlease input one of the options.");
            }
            }
            while (temps == true);
        }

        public void paper(string input)
        {
            string[] ran = new string[] { "rock", "paper", "scissors" };

            Menu m = new Menu();

            Random random = new Random();

            bool temps = true;

            int r = random.Next(0, 2);

            string rps = ran[r];

            if (rps == "paper")
            {   
                Console.WriteLine("\n" + input + " = " + rps + ": It's a tie!");
            }

            if (rps == "scissors")
            {
                Console.WriteLine("\n" + input + " < " + rps + ": You lost!");               
            }

            if (rps == "rock")
            {
                Console.WriteLine("\n" + input + " > " + rps + ": You won!");
            }

            Console.WriteLine("\nWant to play again?");
            Console.WriteLine("\nEnter 'Y' for yes, 'N' for no!");
            Console.Write("\n'Y' or 'N': ");
            string yesorno = Console.ReadLine();
            string temp2 = yesorno.ToLower();

            do 
            { 
            if (temp2 == "y")
            {
                Console.WriteLine();
                m.menu();
             }
            if (temp2 == "n")
            {
                temps = false;
                Console.WriteLine("\nPlay again soon!");
                Console.WriteLine("\nPress enter once to exit.");
            }
            else
            {
                Console.WriteLine("\nPlease input one of the options.");
            }
            }
            while (temps == true);
        }

        public void scissors(string input)
        {
            string[] ran = new string[] { "rock", "paper", "scissors" };

            Menu m = new Menu();

            Random random = new Random();

            bool temps = true;

            int r = random.Next(0, 2);

            string rps = ran[r];

            if (rps == "paper")
            {
                Console.WriteLine("\n" + input + " > " + rps + ": You won!");
            }

            if (rps == "scissors")
            {
                Console.WriteLine("\n" + input + " = " + rps + ": It's a tie!");
            }

            if (rps == "rock")
            {
                Console.WriteLine("\n" + input + " < " + rps + ": You lost!");
            }

            do
            {
                Console.WriteLine("\nWant to play again?");
                Console.WriteLine("\nEnter 'Y' for yes, 'N' for no!");
                Console.Write("\n'Y' or 'N': ");
                string yesorno = Console.ReadLine();
                string temp2 = yesorno.ToLower();

                if (temp2 == "y")
                {
                    Console.WriteLine();
                    m.menu();
                }
                if (temp2 == "n")
                {
                    temps = false;
                    Console.WriteLine("\nPlay again soon!");
                    Console.WriteLine("\nPress enter once to exit.");
                }
                else
                {
                    Console.WriteLine("\nPlease input one of the options.");
                }
            }
            while (temps == true);
        }
    }
}
