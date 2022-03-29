using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czytanka
{
   public class ShowMenu
    {
        public void ShowMenuBooks()
        {
            ShowBooks showBooks = new ShowBooks();
            Console.WriteLine("Witaj, wybierz co chcesz przeczytać");
            Console.WriteLine("1-Horrory");
            Console.WriteLine("2-Przygody");
            Console.WriteLine("x-Wychodze");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Horrory");
                    showBooks.ShowHorros();
                    break;

                case "2":
                    Console.WriteLine("Przygody");
                    showBooks.ShowJourney();
                    break;

                case "x":
                    break;

                default:
                    break;
            }
        }
    }
}
