using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors
{
    public class Menu
    {
        public void menu()
        {
            int count = 0;
            do
            {
                    RPS rps = new RPS();

                    Console.WriteLine("ROCK, PAPER, SCISSORS!");
                    Console.Write("\nPlease type out your selection!: ");
                    string mainInput = Console.ReadLine();
                    string temp = mainInput.ToLower();

                    if (temp == "rock")
                    {
                        count++;
                        rps.rock(temp);
                    }

                    if (mainInput == "paper")
                    {
                        count++;
                        rps.paper(temp);          
                    }

                    if (mainInput == "scissors")
                    {
                        count++;
                        rps.scissors(temp);
                    }

            } while (count == 0);
        }
    }
}
