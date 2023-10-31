using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Виберіть опцію:");
        Console.WriteLine("1. Запустити дочірній процес і чекати його завершення");
        Console.WriteLine("2. Примусово завершити дочірній процес");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            StartChildProcessAndWait();
        }
        else if (choice == "2")
        {
            StartChildProcessAndKill();
        }
        else
        {
            Console.WriteLine("Невірний варіант");
        }
    }

    static void StartChildProcessAndWait()
    {
        Process process = new Process();
        process.StartInfo.FileName = "\"C:\\Windows\\notepad.exe\"";
        process.Start();

        process.WaitForExit();

        int exitCode = process.ExitCode;
        Console.WriteLine($"Дочірній процес завершив роботу з кодом {exitCode}");
    }

    static void StartChildProcessAndKill()
    {
        Process process = new Process();
        process.StartInfo.FileName = "\"C:\\Windows\\notepad.exe\"";
        process.Start();

        System.Threading.Thread.Sleep(5000);
        process.Kill();

        Console.WriteLine("Дочірній процес було примусово завершено");
    }
}