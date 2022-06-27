using System;
using Beeline.Recorders;

namespace Beeline 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.IsNullOrEmpty()) 
            {
                Console.WriteLine("Specify the folder");
                return;
            }

            if (!Directory.Exists(args[0]))
            {
                Console.WriteLine($"Directory {args[0]} not exist");
                return;
            }
            
            using var watcher = new FileWatcher(args[0], new FileRecorder());
            Console.WriteLine("Press any key to exit.");
            Console.Read();
        }
    }
}