using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class WriteInFile
    {
        public void Writealltext()
        {
            Console.Write("Please type the file path: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string textfile = Console.ReadLine();
            File.WriteAllText(textfile, "Hello world");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

