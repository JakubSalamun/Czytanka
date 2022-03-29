using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czytanka
{
  public class CheckReadingTomes
    {
        public void CheckReadTome(string bookTom)
        {
            Console.WriteLine("Co już przeczytałeś? (Podaj numer rozdziału utworzony zostanie w kopii)/(podaj 'nic' byt wyjść");
            var chapter = Console.ReadLine();
            if (chapter == "nic")
            {
                Console.WriteLine("Pamiętaj do mnie wrócić ;)");
            }
            else
            {
                var oldChapter = "{Rozdział x}";
                var newChapter = oldChapter.Replace('x', Convert.ToChar(chapter));
                var templat = File.ReadAllText($"D:/Czytanka/{bookTom}/{bookTom}.txt");
                var document = templat.Replace(newChapter, "Przeczytałem");
                File.WriteAllText($"D:/Czytanka/{bookTom}-{chapter}.txt", document);
            }


        }
        public void CheckReadBook(string bookName)
        {
            Console.WriteLine("Co już przeczytałeś? (Podaj numer rozdziału w orginale)/(podaj 'nic' byt wyjść");
            var chapter = Console.ReadLine();
            if (chapter == "nic")
            {
                Console.WriteLine("Pamiętaj do mnie wrócić ;)");
            }
            else
            {
                var oldChapter = "{Rozdział x}";
                var newChapter = oldChapter.Replace('x', Convert.ToChar(chapter));
                var templat = File.ReadAllText($"D:/Czytanka/{bookName}/{bookName}.txt");
                var document = templat.Replace(newChapter, "Przeczytałem");
                File.WriteAllText($"D:/Czytanka/{bookName}/{bookName}.txt", document);
            }



        }
    }
}
