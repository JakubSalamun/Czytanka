using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czytanka
{
   public class ReadBooks 
    {
        public void BookTome(string _bookHelp)
        {
            var files = Directory.GetFiles($"D:/Czytanka/{_bookHelp}/", "*.txt", SearchOption.AllDirectories);
            foreach (var item in files)
            {
                Console.WriteLine(String.Join(Environment.NewLine, files));
            }
            var documen1 = File.ReadAllText($"D:/Czytanka/{_bookHelp}/{_bookHelp}.txt");
            Console.WriteLine(documen1);
        }
    }
}
