using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Process process = new Process();

        try
        {
            process.StartInfo.FileName = "\"C:\\Windows\\notepad.exe\"";
            process.StartInfo.Arguments = "";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            process.Exited += ProcessExited;

            process.Start();

            process.WaitForExit();

            int exitCode = process.ExitCode;

            Console.WriteLine("Дочірній процес завершився з кодом: " + exitCode);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Сталася помилка при виконанні дочірнього процесу: " + ex.Message);
        }
        finally
        {
            process.Close();
            process.Dispose();
        }
    }

    static void ProcessExited(object sender, EventArgs e)
    {
        Console.WriteLine("Дочірній процес завершився.");
    }
}