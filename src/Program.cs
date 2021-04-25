using System;
using System.Diagnostics;

namespace SteamLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                System.Console.WriteLine("ERROR: Needs launch URL");
                return;
            }

            var epicUrl = args[0];

            var ps = new ProcessStartInfo(epicUrl)
            {
                UseShellExecute = true,
                Verb = "open"
            };

            System.Console.WriteLine($"Starting url: {epicUrl}");
            Process.Start(ps);
        }
    }
}