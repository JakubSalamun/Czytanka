using System;
using System.IO;

namespace Czytanka
{
   public class Program
    {      
        static void Main(string[] args)
        {
            ShowMenu showMenu = new ShowMenu();
            showMenu.ShowMenuBooks();                   
        }

    }
}
