﻿using System;

namespace Czytanka
{
    class Program
    {
        static void Main(string[] args)
        {
            //uzytkownik wybiera czytankę
            //uzytkownik wybiera rozdział do czytania
            //uzytkownik moze dodac recenzje po przeczytaniu

            ShowMenu();

            

        }

        static void ShowMenu()
        {
            Console.WriteLine("Witaj, wybierz co chcesz przeczytać");
            Console.WriteLine("1-Horrory");
            Console.WriteLine("2-Przygody");
            Console.WriteLine("3-Romans");
            Console.WriteLine("x-Wychodze");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Horrory");
                    ShowHorros();

                    break;




                case "2":
                    Console.WriteLine("Przygody");
                    break;




                case "3":
                    Console.WriteLine("Romans");
                    break;


                case "x":
                    break;


                default:
                    break;
            }
        }

        static void ShowHorros()
        {
            Console.WriteLine("1-IT");
            Console.WriteLine("2-Obecność");
            Console.WriteLine("3-Egzorcysta");
            Console.WriteLine("x-Wychodze");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("IT");

                    break;




                case "2":
                    Console.WriteLine("Obecność");
                    break;




                case "3":
                    Console.WriteLine("Egzorcysta");
                    break;


                case "x":
                    ShowMenu();
                    break;


                default:
                    break;
            }


        }
    }
}