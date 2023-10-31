using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string pathToChildProgram = "\"C:\\Users\\ashku\\source\\repos\\mod2_task1\\mod2_task3_2\\bin\\Debug\\net6.0\\mod2_task3_2.exe\"";
        string[] childProgramArgs = { "7", "3", "+" };

        Process process = new Process();
        process.StartInfo.FileName = pathToChildProgram;
        process.StartInfo.Arguments = string.Join(" ", childProgramArgs);
        process.StartInfo.RedirectStandardOutput = false;
        process.StartInfo.UseShellExecute = true;

        process.Start();
        process.WaitForExit();

        Console.ReadLine();
    }
}