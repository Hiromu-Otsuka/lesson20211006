using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static int Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                string blank = "";

                StreamReader reader = null;
                try
                {
                    reader = new StreamReader($"txtfiles/{args[i]}.txt");
                    string text = reader.ReadToEnd();
                    string[] line = text.Replace("\r\n", "\n").Split(new[] { '\n', '\r' });
                    for (int bp = 0; bp < 4 - args[i].Length; bp++) { blank += "　"; }
                    Console.Write($"{args[i]}{blank}：");
                    for (int j = 0; j < line.Length; j++)
                    {
                        Console.Write($"{line[j]}　");
                        if (j == line.Length - 1) { Console.Write("\n"); }
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e.Message + "\n");
                    return -1;
                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                }
            }
            return 0;
        }
    }
}
