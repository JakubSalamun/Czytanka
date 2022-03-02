using System;
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
                    var files =Directory.GetFiles("D:/Czytanka/IT/","*.txt",SearchOption.AllDirectories);
                    foreach (var item in files)
                    {
                        Console.WriteLine(String.Join(Environment.NewLine,files));
                    }
                    Console.WriteLine("Podaj rozdział gdzie skończyłaś/łeś czytać (gdy zaczynasz podaj wartość 1)");
                    var chapter = Console.ReadLine();
                    var documen1= File.ReadAllText($"D:/Czytanka/IT/IT-{chapter}.txt");
                    Console.WriteLine(documen1);
                    CheckReadTome(helpString);
                    break;




                case "2":
              
                    Console.WriteLine("Obecność");
                    var helpString2 = "Obecność";
                    var files2 = Directory.GetFiles("D:/Czytanka/Obecność/", "*.txt", SearchOption.AllDirectories);
                    foreach (var item in files2)
                    {
                        Console.WriteLine(String.Join(Environment.NewLine, files2));
                    }
                    Console.WriteLine("Podaj rozdział gdzie skończyłaś/łeś czytać (gdy zaczynasz podaj wartość 1)");
                    var chapter2 = Console.ReadLine();
                    var documen2 = File.ReadAllText($"D:/Czytanka/Obecność/Obecność-{chapter2}.txt");
                    Console.WriteLine(documen2);
                    CheckReadTome(helpString2);
                    break;




                case "3":
                    Console.WriteLine("Egzorcysta");
                    var helpString3 = "Egzorcysta";
                    var files3 = Directory.GetFiles("D:/Czytanka/Egzorcysta/", "*.txt", SearchOption.AllDirectories);
                    foreach (var item in files3)
                    {
                        Console.WriteLine(String.Join(Environment.NewLine, files3));
                    }
                    Console.WriteLine("Podaj rozdział gdzie skończyłaś/łeś czytać (gdy zaczynasz podaj wartość 1)");
                    var chapter3 = Console.ReadLine();
                    var documen3 = File.ReadAllText($"D:/Czytanka/Egzorcysta/Egzorcysta-{chapter3}.txt");
                    Console.WriteLine(documen3);
                    CheckReadTome(helpString3);
                    break;


                case "x":
                    ShowMenu();
                    break;


                default:
                    break;
            }


        }

        static void CheckReadTome(string book)
        {
            Console.WriteLine("Co już przeczytałeś? (Podaj numer rozdziału)");
            var chapter = Console.ReadLine();
            var oldChapter = "{Rozdział x}";
            var newChapter = oldChapter.Replace('x',Convert.ToChar(chapter));
            var templat = File.ReadAllText($"D:/Czytanka/{book}.txt");
            var document = templat.Replace(newChapter, "Przeczytałem");
            File.WriteAllText($"D:/Czytanka/{book}-{chapter}.txt", document);

        }
    }
}
