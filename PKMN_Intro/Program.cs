using System;
using System.Runtime.ConstrainedExecution;

namespace PKMN_Intro
{
    internal class Program
    {


        public static void Main(string[] args)
        {
            // Variables
            bool nameIsValid = false;
            bool rivalNameIsValid = false;
            int counter = 0;
            string name = null;
            string rivalname = null;

            List<String> dialogue = new List<String>();
            dialogue.Add("Hello there! Welcome to the world of POKEMON!");
            dialogue.Add("My name is OAK! People call me the POKEMON PROF!");
            dialogue.Add("This is a world inhabited by creatures called POKEMON");
            dialogue.Add("For some people, POKEMON are pets, Others use them for fights.");
            dialogue.Add("Myself... I study POKEMON as a profession.");
            dialogue.Add("First, what is your name?");

            dialogue.Add("Right so your name is ");
            dialogue.Add("This is my grandson. He's been your rival since you were a baby.");
            dialogue.Add("...Erm, what is his name again?");

            dialogue.Add("That's right! I remember now! His name is ");
            dialogue.Add("Your very own POKEMON legend is about to unfold!");
            dialogue.Add("A world of dreams and adventures with POKEMON awaits! Let's go!");



            foreach (string s in dialogue) {
                counter++;

                if (counter == 6) {
                        Console.WriteLine("\nOptions: 1) Red, 2) Blue, 3) Ash, Custom_Name");
                        Console.WriteLine("Please type the number of the option you'd like: ");
                        string temp = Console.ReadLine();

                        switch (temp){

                        case "1":
                        name = "Red";
                            break;


                        case "2":
                            name = "Blue";
                            break;

                        case "3":
                            name = "Ash";
                            break;

                        case "4":
                        while (nameIsValid == false)
                        {
                            Console.Write("Please type your name: ");
                            name = Console.ReadLine(); // length == 0
                            if (name.Length <= 0 || name.Length > 16)
                            {
                                Console.WriteLine("Invalid Try Again ");
                            }
                            else 
                            {
                                nameIsValid = true;
                            }

                        }
                            break;
                        }
                    
                    

                }

                else if (counter == 7) {
                    Console.WriteLine(s + name);
                }

                else if (counter == 9) {
                    Console.WriteLine("\nOptions: Blue, Green, Gary, Custom_Name");
                    Console.WriteLine("Please type the number of the option you'd like: ");
                    string temp2 = Console.ReadLine();
                    if (temp2 == "1"){
                        rivalname = "Blue";
                    }
                    if (temp2 == "2") {
                        rivalname = "Green";
                    }
                    if (temp2 == "3") {
                        rivalname = "Gary";
                    }
                    if (temp2 == "4") {
                    while (rivalNameIsValid == false) 
                        {
                            Console.Write("Please type your rival's name: ");
                            rivalname = Console.ReadLine();
                            if (rivalname.Length <= 0 || rivalname.Length > 16)
                            {
                                Console.WriteLine("Invalid Try Again ");
                            }
                            else
                            {
                                rivalNameIsValid = true;
                            }

                        }
                    }

                }
                else if (counter == 10) {
                    Console.WriteLine(s + rivalname);
                }
                else
                {
                    Console.WriteLine(s);
                }

                Console.ReadKey();
            }
        }


    }
}