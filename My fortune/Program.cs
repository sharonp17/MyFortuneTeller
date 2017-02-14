using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_fortune
{
    class Program
    {
        static void Main(string[] args)
        {
// establishing variables
            string myTransport ="";
            string yearsToRetirement ="";
            string location ="";
            double moneyInBank;

//Part 1: introduction & explanation
            Console.WriteLine("Hello and Welcome to Fortune Teller!");
            Console.WriteLine();
            Console.WriteLine("What is your First name?");
            string firstName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("What is your Last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Hello " + "" + firstName + " " + lastName);
            Console.WriteLine();
      
//Part 2: gathering data
            Console.WriteLine();
            Console.WriteLine("Now let's discover your fortune! Start by typing your age in numbers.");
            Console.WriteLine();
            int userAge = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine("Okay, enter the NUMBER of your birth month \"example: type 1 for January\"");
            Console.WriteLine();
            int birthMonth = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine(@"Alright, what is your favorite ROYGBIV color? Simply type ""red"" ""green"" etc.""");
            Console.WriteLine("If you do not know then type \"help\" for a reference list.");
            string favColor = Console.ReadLine();
           
           if (favColor.ToLower() == "help")
            {
                Console.WriteLine("R = red, O = Orange, Y = Yellow, G = Green, B = Blue, I = Indigo, V = Violet");
                Console.WriteLine("What is your favorite color?");
                favColor = Console.ReadLine();
            }

                Console.WriteLine();
                Console.WriteLine("Okay, last question! How many siblings do you have?");
                int numberOfSibs = int.Parse(Console.ReadLine());


//Part 3: running equations 


// years to retirement

                if (userAge % 2 == 0)
                {
                    yearsToRetirement = "25 years";
                }
                else
                {
                    yearsToRetirement = "30 years";
                }
            

                switch (birthMonth)
                {

//how much will be in the bank when they retire
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        moneyInBank = 200000.00;
                        break;
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        moneyInBank = 170000.00;
                        break;
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                        moneyInBank = 150000.00;
                        break;
                    default:
                        moneyInBank = 0.00; 
                        break;
                }

//What transporation they will have
                switch (favColor.ToLower())
                {
                        case "red":
                            myTransport = "boat";
                            break;
                        case "orange":
                            myTransport = "goat";
                            break;
                        case "yellow":
                            myTransport = "magic swan";
                            break;
                        case "green":
                            myTransport = "mid-size sedan";
                            break;
                        case "blue":
                             myTransport = "teleportation portal";
                            break;
                        case "indigo":
                             myTransport = "camel";
                            break;
                        case "violet":
                            myTransport = "submarine";
                            break;
                        default:
                            Console.WriteLine("I do not recognize that color");
                            break;
                    }

            if (numberOfSibs < 0)
            {

                location = "a terrible shanty next to a garbage dump";
            }
                                 
                switch (numberOfSibs)
                {
                    case 0:
                    location = "South Africa";
                        break;
                    case 1:
                    location = " a base on the moon";
                        break;
                    case 2:
                        location = "Japan";
                        break;
                    case 3:
                        location = "Ireland";
                    break;
                    default:
                    location = "Brazil";
                    break;
            }
 //part 3
            Console.WriteLine(firstName + " " + lastName + " will retire in " + yearsToRetirement + 
                " with $" + moneyInBank + " in the bank, a vacation home in " + location + " and a " + myTransport + ".");

            Console.ReadLine();
            }
        }
    }
