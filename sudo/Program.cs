﻿namespace Sudo
{
    class Program
    {

        static void Main(string[] args)
        {
            RunArgs(args);
        }

        /**
            <summary>
                Executes the CLI arguments passed.
                If an invalid argument is found, it'll notify
                the user and throw an exception.
            </summary>

            <exception cref="ArgumentException">
                Thrown when an <c>invalid argument</c> is found.
            </exception>
        */
        static void RunArgs(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (!args[i].StartsWith("--") && !args[i].StartsWith("-")) { continue; }

                // --version
                if (args[i] == "--version" || args[i] == "-v")
                {
                    Console.WriteLine("sudo v1.0.0");
                    Console.WriteLine("Made by YisusGaming. Copyright (c) YisusGaming 2023.");

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
        }
    }
}