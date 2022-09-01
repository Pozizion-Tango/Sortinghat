using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sortinghat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SordingHat sordinghat = new SordingHat(); 
            while(true)
            {
                Console.WriteLine("Insert The Student's Name");
                string name = sordinghat.StudentIdentity(Console.ReadLine());
                if (name != "null")//If the name is rejected, then it will do a simple reset
                {
                    Console.Clear();
                    Console.Write("Very well '");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(name); Console.ResetColor();
                    Console.WriteLine("' you're accepted, wonderful name.");
                    Console.WriteLine("'Press Any Key To Continue");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Let us see what house you belong to\r\n ");
                    for (int i = 0; i < 5; i++)//just because i find it cool
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }
                    sordinghat.House(name);//now let's see what house you belong to
                    sordinghat.Status();//shows the status of houses, what student is in what.
                }
                else
                {
                }
            }
        }
    }
}
