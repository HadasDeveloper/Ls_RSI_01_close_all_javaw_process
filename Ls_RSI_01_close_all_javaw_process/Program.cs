using System;
using System.Diagnostics;

namespace Ls_RSI_01_close_all_javaw_process
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcessesByName("javaw");
            foreach (Process process in processes)
            {
                Console.WriteLine(process.Id);
                process.Kill();
            }
        }
    }
}
