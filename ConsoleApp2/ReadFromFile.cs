using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReadFromFile
{
    public void StreamReader()
    {
        Console.Write("Please enter the number of lines: ");
        int lines = Convert.ToInt32(Console.ReadLine());
        StreamReader sr = new StreamReader("d://123//zc.txt");
        int StrokeNumber = 0;
        int i = 1;
        while (i > 0)
        {
            while (StrokeNumber < lines)
            {
                Test.GroundColor(sr.ReadLine(), ConsoleColor.Blue);
                Console.WriteLine(sr.ReadLine());
                StrokeNumber++;
            }
            StrokeNumber = 0;
            Console.Write("Print another block of text?: ");
            string answer = Console.ReadLine();
            if (answer == "n")
            {
                break;
            }
        }
    }
}