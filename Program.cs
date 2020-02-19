using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {

            bool playAgain = true;
            while (playAgain)
            {
                Console.WriteLine("Choose (1) Rock, (2) Paper or (3) Scissors: ");
                int pick = int.Parse(Console.ReadLine());

                Random randomNumberGenrator = new Random();
                int num = randomNumberGenrator.Next(3) + 1;
                //Console.WriteLine("Press any button for you oppenents choice");



                if (pick == 1 && num == 3)
                {
                    Console.WriteLine("Your opponent picked Scissors, you win!");
                    
                }
                else if (pick == 1 && num == 2)
                {
                    Console.WriteLine("Your opponent picked Paper, you suck!");
                }
                else if (pick == 2 && num == 1)
                {
                    Console.WriteLine("Your opponent picked Rock, you win!");
                }
                else if (pick == 2 && num == 3)
                {
                    Console.WriteLine("Your opponent picked Scissors, you suck!");
                }
                else if (pick == 3 && num == 2)
                {
                    Console.WriteLine("Your opponent picked Paper, you win!");
                }
                else if (pick == 3 && num == 1)
                {
                    Console.WriteLine("Your opponent picked Rock, you suck!");
                }
                else if (pick == 1 && num == 1)
                {
                    Console.WriteLine("TIE");
                }

                else if (pick == 2 && num == 2)
                {
                    Console.WriteLine("TIE");
                }

                else if (pick == 3 && num == 3)
                {
                    Console.WriteLine("TIE");
                }



                else
                {
                    Console.WriteLine("follow the freakig directions idiot");
                }


                Console.WriteLine("Do you want to play again? (y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                
           
            }
        }
    }
}
