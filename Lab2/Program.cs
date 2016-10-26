using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Lab2
    {
        static void Main(string[] args)
        {
            int state = 1;
            string name = "";
            bool playGame = true;
            while (playGame == true)
            {
                switch (state)
                {
                    case 1:
                        Console.WriteLine("What is your name");
                        name = Console.ReadLine();
                        state = 2;
                        break;

                    case 2:
                        Console.WriteLine($"Hi {name}, Do you want to play the game? y/n");
                        string answer = Console.ReadLine();
                        if (answer == "y")
                        {
                            state = 3;
                        }
                        else if (answer == "n")
                        {
                            state = 7;
                        }
                        break;

                    case 3:
                        Console.WriteLine($"Excellent {name}, you are walking across a field and you encounter a fire-breathing dragon!\nWill you face the beast or run away?");
                        Console.WriteLine("Please enter your choice. (fight or run)");
                        answer = Console.ReadLine();
                        if (answer == "fight")
                        {
                            state = 4;
                        }
                        else if (answer == "run")
                        {
                            Console.WriteLine($"Wow {name}, I thought you had it in you.");
                            state = 7;
                        }
                        break;

                    case 4:
                        Console.WriteLine("As you get closer you see that this dragon has multiple heads\nHow many heads do you think this thing has?");
                        Console.WriteLine("Enter your guess:");
                        Int32 heads = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Wow, you're actually right. The dragon has {heads} heads");
                        state = 5;
                        break;

                    case 5:
                        Console.WriteLine("Now you must choose your weapon.\nYour options are:\nSlingshot\nBow\nSword");
                        string weapon = Console.ReadLine();
                        if (weapon == "Slingshot")
                        {
                            Console.WriteLine("I think you're probably going to die with that.");
                            state = 7;
                        }
                        else if (weapon == "Bow")
                        {
                            Console.WriteLine("Good Choice.");
                            state = 6;
                        }
                        else if (weapon == "Sword")
                        {
                            Console.WriteLine("Good Choice.");
                            state = 6;
                        }
                        else
                        {
                            Console.WriteLine("That's not going to work.");
                            state = 7;
                        }
                        break;
                    case 6:
                        Console.WriteLine("Does the dragon have red or blue eyes? (r/b)");
                        string eyes = Console.ReadLine();
                        if (eyes == "r" || eyes =="R")
                        {
                            Console.WriteLine("Oh thank goodness, red-eyed dragons are friendly. What do you want to name it?");
                            string dragonName = Console.ReadLine();
                            Console.WriteLine($"{name} and {dragonName} live happily ever after");
                            playGame = false;
                        }
                        else if (eyes == "b" || eyes =="B")
                        {
                            Console.WriteLine("Blue eyed dragons are extremely dangerous, it looks like you're going to be eaten.");
                            state = 7;
                        }
                        break;

////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    case 7:
                            Console.WriteLine("Game Over");
                            playGame = false;
                            break;                      
                }
            }
            // Keeps the console window open in debug mode
            Console.ReadKey();
        }
    }
}
