﻿using System;
using System.IO;

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
                    var helpString = "IT";
                    BookTome(helpString);
                    CheckReadBook(helpString);
                    CheckReadTome(helpString);
                    break;




                case "2":
              
                    Console.WriteLine("Obecność");
                    var helpString2 = "Obecność";
                    BookTome(helpString2);
                    CheckReadTome(helpString2);
                    break;




                case "3":
                    Console.WriteLine("Egzorcysta");
                    var helpString3 = "Egzorcysta";
                    BookTome(helpString3);
                    CheckReadTome(helpString3);
                    break;


                case "x":
                    ShowMenu();
                    break;


                default:
                    break;
            }


        }

        static void CheckReadTome(string bookTom)
        {
            Console.WriteLine("Co już przeczytałeś? (Podaj numer rozdziału)");
            var chapter = Console.ReadLine();
            var oldChapter = "{Rozdział x}";
            var newChapter = oldChapter.Replace('x',Convert.ToChar(chapter));
            var templat = File.ReadAllText($"D:/Czytanka/{bookTom}/{bookTom}.txt");
            var document = templat.Replace(newChapter, "Przeczytałem");
            File.WriteAllText($"D:/Czytanka/{bookTom}-{chapter}.txt", document);

        }
        static void CheckReadBook(string bookName)
        {
            Console.WriteLine("Co już przeczytałeś? (Podaj numer rozdziału)");
            var chapter = Console.ReadLine();
            var oldChapter = "{Rozdział x}";
            var newChapter = oldChapter.Replace('x', Convert.ToChar(chapter));
            var templat = File.ReadAllText($"D:/Czytanka/{bookName}/{bookName}.txt");
            var document = templat.Replace(newChapter, "Przeczytałem");
            File.WriteAllText($"D:/Czytanka/{bookName}/{bookName}.txt", document);

        }

        static void BookTome(string bookName)
        {
            var files = Directory.GetFiles($"D:/Czytanka/{bookName}/", "*.txt", SearchOption.AllDirectories);
            foreach (var item in files)
            {
                Console.WriteLine(String.Join(Environment.NewLine, files));
            }
            var documen1 = File.ReadAllText($"D:/Czytanka/{bookName}/{bookName}.txt");
            Console.WriteLine(documen1);
        }
    }
}
