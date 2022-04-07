// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.IO;
class Test
{
    public static void Main()
    {
        int i = 1;// присваиваем переменной значение 1
        while (i > 0)// задаем циикл (пока и больше 0, а она всегда больше нуля, делать что ниже
        {
            Console.WriteLine("1.Fibonacchi line");// выводим в консоль 
            Console.WriteLine("2.Write in file");
            Console.WriteLine("3.Read in file");
            Console.WriteLine("4.Exit");
            Console.WriteLine("5.Get HTML.");
            Console.Write("Please select (1-5): ");
            try // проверка если сделай то, что внизу до иначе.
            {
                int commandNumber = Convert.ToInt32(Console.ReadLine());// конверируем и присваиваем значение переменной
                if (commandNumber == 1) // если значение равно 1, то
                {   Fibonacci f = new Fibonacci();
                    f.Calculate();
                }
                else if (commandNumber == 2)// если значение введенного равно 2, то
                {   
                    WriteInFile m = new WriteInFile();
                    m.Writealltext();
                }
                else if (commandNumber == 3)//если значение введенного равно 2, то
                {
                    ReadFromFile n = new ReadFromFile();
                    n.StreamReader();
                }
                else if (commandNumber >= 5)
                {
                    Console.WriteLine("Input path");
                    string Path = Console.ReadLine();
                    Uri.IsWellFormedUriString(Path, UriKind.RelativeOrAbsolute);
                    GetHTTP g = new GetHTTP();
                    g.GetHtml(Path);
                }

                else if (commandNumber == 4)
                {
                    return;
                }
            }
            catch (Exception ex) 
            {
                GroundColor(ex.Message,ConsoleColor.Red);
            }
        }
    }
    public static void GroundColor(string x,ConsoleColor b)
    {
        Console.ForegroundColor = b;
        Console.WriteLine(x);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
public class Fibonacci

{
    public void Calculate()
    {
        Console.Write("Please type Fibonacci line max number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int perv = 1;
        int vtor = 1;
        int sum = 0;
        Console.ForegroundColor = ConsoleColor.Green;
        while (number >= sum)
        {
            sum = perv + vtor;
            Console.Write("{0} ", sum);
            perv = vtor;
            vtor = sum;
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
    }
}
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
public class ReadFromFile
{
    public void StreamReader()
    {
        Console.Write("Please enter the number of lines: ");// пишем в консоль
        int lines = Convert.ToInt32(Console.ReadLine());//считываем из консоли,кинвертируем и присваиваем значение
        StreamReader sr = new StreamReader("d://123//zc.txt"); // задаем переменную и указваем тип и путь файла
        int StrokeNumber = 0;
        int i = 1;
        while (i > 0) // еще один цикл
        {
            while (StrokeNumber < lines) // пока номер строк меньше 
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
class GetHTTP
{
    readonly HttpClient client = new HttpClient();
            public async Task GetHtml(string path)
        {
        try
        {
            HttpResponseMessage response = await client.GetAsync(path);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ", e.Message);
        }
    }
}



