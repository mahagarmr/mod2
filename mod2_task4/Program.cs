using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        const string filePath = "\"D:\\file.txt\"";
        const string word = "bicycle";

        Process process = new Process();
        process.StartInfo.FileName = "\"C:\\Users\\ashku\\source\\repos\\mod2_task1\\mod2_task4_2\\bin\\Debug\\net6.0\\mod2_task4_2.exe\"";
        process.StartInfo.Arguments = $"{filePath} {word}";

        process.Start();
        process.WaitForExit();

        Console.ReadLine();
    }
}