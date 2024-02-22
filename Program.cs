using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.CompilerServices;


namespace PythonChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int iOpt = 0;
            do
            {
                iOpt = Menu();
                switch (iOpt)
                {
                    case 0:
                        Console.WriteLine("Goodbye");
                        break;
                    case 1:
                        Challenge1();
                        break;
                    case 2:
                        Challenge2();
                        break;
                    case 3:
                        Challenge3();
                        break;
                    case 6:
                        Challenge6();
                        break;
                    case 7:
                        Challenge7();
                        break;
                    case 8:
                        Challenge8();
                        break;
                    case 10:
                        Challenge10();
                        break;
                    case 11:
                        Challenge11();
                        break;
                    case 20:
                        Challenge20();
                        break;
                    case 28:
                        Challenge28();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }
            } while (iOpt != 0);
        }
        static void Challenge1()
        {
            Console.WriteLine("Please enter your age");
            String age = Console.ReadLine();
            Console.WriteLine("Your age is:" + age);
        }

        static void Challenge2()
        {
            String outline;
            Console.Write("Enter Number 1>");
            Double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Number 2>");
            Double n2 = Convert.ToDouble(Console.ReadLine());
            Double avg = (n1 + n2) / 2;
            outline = $"The average of {n1} and {n2} is {avg}";
            Console.WriteLine(outline);

        }

        static void Challenge3()
        {
            String outline;
            Console.Write("Enter width >");
            Double wid = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter length >");
            Double len = Convert.ToDouble(Console.ReadLine());
            Double area = wid * len;
            outline =$"A rectangle of {wid} and {len} is {area}";
            Console.WriteLine(outline);
        }


        static void Challenge6()
        {
            String name;
            Console.Write("Hi, what's your name>");
            name = Console.ReadLine();
            if (name == "James")
            {
                Console.WriteLine("You're cool!");
            }
            else
            {
                Console.WriteLine("Nice to meet you");
            }
        }

        static void Challenge7()
        {
            int hours = 24;
            while (hours >= 24)
            {
                Console.WriteLine("On, Average how many hours a day do you watch TV");
                hours = Convert.ToInt16(Console.ReadLine());
                if (hours < 2)
                {
                    Console.WriteLine("That shouldnt rot your brain too much");
                }
                else if (hours > 24)
                {
                    Console.WriteLine("Don't lie");
                }
                else if (hours >= 2)
                {
                    Console.WriteLine("Arent you getting square eyes?");
                }
                else
                {
                    Console.WriteLine("Fresh air beats channel flicking");
                }
            }
        }
        
        static void Challenge8()
        {
            int grade;
            grade = Convert.ToInt32(Console.ReadLine());
            if (grade >= 75)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 35)
            {
                Console.WriteLine("C");
            }
            else if (grade < 35)
            {
                Console.WriteLine("D");
            }
        }

        static void Challenge10()
        {
            string compguess = "error";
            string playguess;
            int randval;
            int condition = 2;

            Random rnd = new    Random();
            randval = rnd.Next(0,4);

            switch (randval)
            {
                case 1:
                    compguess = "rock";
                    break;
                case 2:
                    compguess = "scissors";
                    break;
                case 3:
                    compguess = "paper";
                    break;
            }

            Console.WriteLine("'rock' 'paper' or 'scissors'");
            playguess = Console.ReadLine();
            string playguessnew = playguess.ToLower();
            
            Console.WriteLine(compguess);

            if (playguessnew == "rock")
            {
                if (compguess == "paper"){
                    condition = 0;
                }
                else if (compguess == "scissors"){
                    condition = 1;
                }
            }
            else if (playguessnew == "paper")
            {
                if (compguess == "scissors"){
                    condition = 0;
                }
                else if (compguess == "rock"){
                    condition = 1;
                }
            }
            else if (playguessnew == "scissors")
            {
                if (compguess == "paper"){
                    condition = 1;
                }
                else if (compguess == "rock"){
                    condition = 0;
                }
            }
            else{
                Console.WriteLine("Error. Computer guess was: ", compguess);
            }

            switch (condition)
            {
                case 0:
                    Console.WriteLine("You Lose");
                break;
                case 1:
                    Console.WriteLine("You Win");
                break;
                case 2:
                    Console.WriteLine("Draw");
                break;
            }
        }

        static void Challenge11()
        {
            Console.WriteLine("Input a sentence");
            string sentence = Console.ReadLine();
            int len = sentence.Length;
            Console.WriteLine($"Your sentence is {len} characters long.");
            Console.ReadKey();
        } 

        static void Challenge20()
        {
            int guess=-1, target=7;
            do
            {
                Console.Write("Guess Number>");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == target)
                {
                    Console.WriteLine("Well done!");
                }
                else Console.WriteLine("Sorry wrong");

            } while (guess != target);
            
        }

        static void Challenge28()
        {
            Random rnum = new Random();
            String[] names = new String[5];
            String name;
            int x;
            bool cont = true;
            for (int n=0; n < 5; n++)
            {
                Console.Write("Enter name>");
                name = Console.ReadLine();
                names[n] = name;
            }
            do
            {
                x = rnum.Next(0, 5);
                Console.WriteLine($"name is {names[x]}");
                Console.Write("Another>");
                if (Console.ReadKey().Key != ConsoleKey.Y)
                {
                    cont = false;
                }
                else Console.WriteLine();
            } while (cont);

        }
        
        static int Menu()
        {
            String opt="";
            int rval=-1;
            Console.WriteLine("Menu");
            Console.WriteLine("--------------");
            Console.WriteLine(" 1) Challenge 1");
            Console.WriteLine(" 2) Challenge 2");
            Console.WriteLine(" 3) Challenge 3");
            Console.WriteLine(" 6) Challenge 6");
            Console.WriteLine(" 7) Challenge 7");
            Console.WriteLine(" 8) Challenge 8");
            Console.WriteLine("10) Challenge 10");
            Console.WriteLine("11) Challenge 11");
            Console.WriteLine("20) Challenge 20");
            Console.WriteLine("28) Challenge 28");
            Console.WriteLine(" Q) Quit");
            Console.WriteLine("");
            Console.Write("Enter Option>");
            opt = Console.ReadLine();
            if (opt=="q" || opt=="Q")
            {
                rval = 0;
            } else
            {
                try
                {
                    rval = Convert.ToInt32(opt);
                }
                catch
                {
                    rval = -1;
                }
                
            }
            return rval;

        }
    }
}