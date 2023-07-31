using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sudo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parsedArgs = {};
            try { parsedArgs = RunArgs(args); } catch (ArgumentException exception) { Console.Error.WriteLine(exception.Message); }
            if (parsedArgs.Length == 0) { return; }
            string program = parsedArgs[0];

            ProcessStartInfo info = new ProcessStartInfo(program);
            info.UseShellExecute = true;
            info.Verb = "runas";

            try { Process.Start(info); } catch (System.ComponentModel.Win32Exception winException) { Console.Error.WriteLine("[ERR!]: " + winException.Message); }
        }

        /**
            <summary>
                Executes the CLI arguments passed.
                If an invalid argument is found, it'll notify
                the user and throw an exception.
            </summary>

            <returns>
                A new array of strings based on the original <c>args</c>
                without any options, only arguments.
            </returns>

            <exception cref="ArgumentException">
                Thrown when an <c>invalid argument</c> is found.
            </exception>
        */
        static string[] RunArgs(string[] args)
        {
            List<string> noOptions = new List<string>(args);

            for (int i = 0; i < args.Length; i++)
            {
                if (!args[i].StartsWith("--") && !args[i].StartsWith("-")) { continue; }

                // --version
                if (args[i] == "--version" || args[i] == "-v")
                {
                    Console.WriteLine("sudo v1.0.0");
                    Console.WriteLine("Made by YisusGaming. Copyright (c) YisusGaming 2023.");

                    noOptions.Remove(args[i]);
                    continue;
                }
                // --help
                if (args[i] == "--help" || args[i] == "-h") 
                {
                    Console.WriteLine("Runs a program as Adiministrator.\n(Implementation of Linux's sudo command)\n");
                    Console.WriteLine("Usage:\n    sudo [options] <program>\n");
                    Console.WriteLine("Replace <program> with the program you want to execute.");
                    Console.WriteLine("Replace [options] with one of the following (not required):\n");
                    Console.WriteLine("    -v, --version -> Prints a label with the current version.");
                    Console.WriteLine("    -h, --help -> Prints this message.");
                    Console.WriteLine("\n");

                    noOptions.Remove(args[i]);
                    continue;
                }

                // If the argument didn't match any of the above
                // we run this.
                // The program normally wouldn't reach this code
                // since the cases above "continue" at the end.
                // The condition at the start ensures that anything
                // without the format of an option is skipped.
                // So if we reach this code is because something
                // unknow was passed as an option.
                Console.Error.WriteLine("[ERR!] Unknow Option!");
                throw new ArgumentException("Invalid argument: " + args[i]);
            }

            return noOptions.ToArray();
        }
    }
}