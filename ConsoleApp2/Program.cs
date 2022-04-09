
using System;
using System.IO;
using System.Data.SqlClient;
class Test
{
    public static void Main()
    {   SqlConnection sqlConnection = new SqlConnection("Server = localhost\\SqlExpress; Database = Homework; Trusted_Connection = True;");
        sqlConnection.Open();

        sqlConnection.Close();
        int i = 1;
        while (i > 0)
        {
            Console.WriteLine("1.Fibonacchi line");
            Console.WriteLine("2.Write in file");
            Console.WriteLine("3.Read in file");
            Console.WriteLine("4.Exit");
            Console.WriteLine("5.Get HTML.");
            Console.Write("Please select (1-5): ");
            try
            {
                int commandNumber = Convert.ToInt32(Console.ReadLine());
                if (commandNumber == 1)
                {   Fibonacci f = new Fibonacci();
                    f.Calculate();
                }
                else if (commandNumber == 2)
                {   
                    WriteInFile m = new WriteInFile();
                    m.Writealltext();
                }
                else if (commandNumber == 3)
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