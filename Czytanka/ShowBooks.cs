using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czytanka
{
    public class ShowBooks
    {
        ReadBooks readBooks = new ReadBooks();
        CheckReadingTomes checkReadingTomes = new CheckReadingTomes();
        ShowMenu showMenu = new ShowMenu();
        public void ShowJourney()
        {


            Console.WriteLine("1-Indiana Jones 1");
            Console.WriteLine("2-Indiana Jones 2");
            Console.WriteLine("3-Indiana Jones 3");
            Console.WriteLine("x-Wychodze");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Indiana Jones 1");
                    var helpString = "Indiana Jones 1";
                    readBooks.BookTome(helpString);
                    checkReadingTomes.CheckReadBook(helpString);
                    checkReadingTomes.CheckReadTome(helpString);
                    break;




                case "2":

                    Console.WriteLine("Indiana Jones 2");
                    var helpString2 = "Indiana Jones 2";
                    readBooks.BookTome(helpString2);
                    checkReadingTomes.CheckReadBook(helpString2);
                    checkReadingTomes.CheckReadTome(helpString2);
                    break;




                case "3":
                    Console.WriteLine("Indiana Jones 3");
                    var helpString3 = "Indiana Jones 3";
                    readBooks.BookTome(helpString3);
                    checkReadingTomes.CheckReadBook(helpString3);
                    checkReadingTomes.CheckReadTome(helpString3);
                    break;


                case "x":
                    showMenu.ShowMenuBooks();
                    break;


                default:
                    break;
            }
        }
        public void ShowHorros()
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
                    readBooks.BookTome(helpString);
                    checkReadingTomes.CheckReadBook(helpString);
                    checkReadingTomes.CheckReadTome(helpString);
                    break;




                case "2":

                    Console.WriteLine("Obecność");
                    var helpString2 = "Obecność";
                    readBooks.BookTome(helpString2);
                    checkReadingTomes.CheckReadBook(helpString2);
                    checkReadingTomes.CheckReadTome(helpString2);
                    break;




                case "3":
                    Console.WriteLine("Egzorcysta");
                    var helpString3 = "Egzorcysta";
                    readBooks.BookTome(helpString3);
                    checkReadingTomes.CheckReadBook(helpString3);
                    checkReadingTomes.CheckReadTome(helpString3);
                    break;


                case "x":
                    showMenu.ShowMenuBooks();
                    break;


                default:
                    break;
            }


        }
    }
}
