using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace _8999680_Hemanshu_patel_assignment_1
    {
        internal class Program
        {
            static void Main(string[] args)
            {



                //choice of pet
                Console.WriteLine("1. Cat ");
                Console.WriteLine("2. Dog ");
                Console.WriteLine("3. Rabbit ");
                Console.WriteLine("\n Please you choose your pet. ");
                int Choice = int.Parse(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("\n \nUser Input: " + Choice + "\n");
                        Console.WriteLine();
                        Console.Write("\n You have to choose cat.");
                        break;


                    case 2:
                        Console.WriteLine("\n \nUser Input: " + Choice);
                        Console.Write("You have to choose Dog. \n");
                        break;


                    case 3:
                        Console.WriteLine("\n \nUser Input: " + Choice);
                        Console.Write("You have to choose Rabbit. \n");
                        break;


                    default:
                        Console.WriteLine("Invalid choice.....");
                        break;

                }


                //name of pet

                Console.WriteLine("\nWhat would you like to name your pet !!???  ");
                String name = Console.ReadLine();
                Console.WriteLine("User Input:" + name + "\n \n");
                Console.WriteLine("Welcome, " + name + "!" + " Let's take good care of him.");

                int hunger = 5, happiness = 5, health = 8;   //declare for see status
                int count = 0, count_feeding = 0, count_feeding_1 = 0; //declare for count feeding






                while (true)
                {
                    Console.WriteLine("\n\nSelect Manu:");
                    Console.WriteLine("1. Feeding");
                    Console.WriteLine("2. Playing ");
                    Console.WriteLine("3. Resting");
                    Console.WriteLine("4. status");
                    Console.WriteLine("5. Exit");

                    Console.Write("Enter choice : ");
                    int choice = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (choice >= 1 && choice <= 4)
                    {


                        switch (choice)
                        {
                            case 1:
                                count++;
                                if (count > 2)
                                {
                                    Console.WriteLine("pet is not hungry now............");


                                }

                                else
                                {
                                    Console.WriteLine("\n \n You fed " + name + " His hunger descrease, and health improve slightly ");
                                    hunger--;
                                    health++;
                                }


                                break;

                            case 2:
                                count_feeding++;
                                if (count_feeding > 2)
                                {
                                    Console.WriteLine("Pet is hungry and also bored from plays game now........");
                                    Console.WriteLine("please feeding", name);
                                }

                                else
                                {
                                    Console.WriteLine("\n \n You played with " + name + " His happiness increase, but he's a bit hungries ");
                                    happiness++;
                                    happiness++;
                                    hunger++;

                                }
                                break;
                            case 3:
                                count_feeding_1++;
                                if (count_feeding_1 > 2)
                                {
                                    Console.WriteLine(name + " is hungry. please feeding " + name + " and also did well rest. so, You can choose other Activity.");

                                }
                                else
                                {
                                    Console.WriteLine("\n \n Resting");
                                    health++;
                                    happiness++;
                                }
                                break;

                            case 4:
                                Console.WriteLine("\n\n" + name + "'s Status");
                                Console.WriteLine(" Hunger    : " + hunger);


                                Console.WriteLine(" Happiness : " + happiness);
                                Console.WriteLine(" Health    : " + health);

                                break;

                        }
                    }

                    else if (choice == 5)
                    {
                        Console.WriteLine("Thank You For playing with " + name + " Goodbye!...");
                        break;
                    }


                    else
                    {
                        Console.WriteLine("Invalid input");
                    }

                }
                Console.ReadLine();

            }
        }

    }


