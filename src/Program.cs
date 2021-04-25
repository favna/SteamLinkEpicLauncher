using System;
using System.Diagnostics;


if (args.Length == 0)
{
    Console.Error.WriteLine("ERROR: Needs launch URL");
    return;
}

var epicUrl = args[0];

var ps = new ProcessStartInfo(epicUrl)
{
    UseShellExecute = true,
    Verb = "open"
};

Console.WriteLine($"Starting url: {epicUrl}");
Process.Start(ps);