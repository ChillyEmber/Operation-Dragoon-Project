using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Operation_Dragoon
{
    class Program
    {
        static void Main()
        {
            bool exit = false;
            while(!exit)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                WriteLineWordWrap("Please enter a query to get information based on the war, Operation Dragoon!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                WriteLineWordWrap("Avaiable entries are \"who\", \"what\", \"where\", \"when\", \"why\", and \"how\"." +
                    " You could also do \"result\", to see what the result of the war was, and \"effects\" to learn more about the long term effects of the war. " +
                    "You can also type \"quit\" to quit, and \"about\" to see who made this!");
                Console.ForegroundColor = ConsoleColor.White;
                string entry = Console.ReadLine();
                entry = entry.ToLower(); //Moves everything to lowercase, so that entry could be something like "WhErE" and still register what it needs to.
                switch (entry)
                {
                    case "who":
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        WriteLineWordWrap("The ground forces on the Allied side were the United States, France, United Kingdom, and Canada. The Allies Air Support was Australia, and South Africa. The Allies Naval Support was Greece, and New Zealand. The people the Allies were fighting against were the Germans.");
                        System.Threading.Thread.Sleep(4000);
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case "what":
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        WriteLineWordWrap("On August 14th a heavy naval bombardment, carried on for an hour before the first landings at approximately 8:00. Destroyers provided gunfire support throughout the operation, and the  U.S. Navy and Royal Navy carrier aircraft provided air support, all ending up in a success for the Allies with minimal resistance.");
                        System.Threading.Thread.Sleep(4000);
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case "where":
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        WriteLineWordWrap("Operation Dragoon happened in one spot, happening in Côte d'Azur, South France.");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine();
                        Console.WriteLine();
                        WriteLineWordWrap("Would you like me to open a picture depecting a map before the war? (y/n)");
                        Console.ForegroundColor = ConsoleColor.White;
                        string whereanswer = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        if (whereanswer.Equals("y", StringComparison.OrdinalIgnoreCase)) //If either y or Y is detected, act on whatever is in the if statement
                        {
                            OpenURL("https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/Operation_Dragoon_-_map.jpg/450px-Operation_Dragoon_-_map.jpg");
                            WriteLineWordWrap("As mentioned above, this is a image...");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        WriteLineWordWrap("Would you like to see a picture of where the landings were? (y/n)");
                        Console.ForegroundColor = ConsoleColor.White;
                        whereanswer = Console.ReadLine();
                        if (whereanswer.Equals("y", StringComparison.OrdinalIgnoreCase))
                        {
                            OpenURL("https://upload.wikimedia.org/wikipedia/commons/thumb/f/f5/Anvildragoon.png/330px-Anvildragoon.png");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            WriteLineWordWrap("This image depicts all of the landing spots");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case "when":
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        WriteLineWordWrap("Operation Dragoon started on August 13th, 1944, and came to a end on September 14th 1944, lasting a total of about 30 days.");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case "why":
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        WriteLineWordWrap("The cause of Operation Dragoon was the Allied Forces wanting to help liberate France, and also give themselves an advantage over the Germans in the form of Southern Frances Ports, and Railroads.");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case "how":
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        WriteLineWordWrap("The battle resulted in a swift victory for the Allies, with things like communication lines from the Germans going silent, which forced commanders to act separately, and ultimately resulting in the German groups retreating.");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case "result":
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        WriteLineWordWrap("The result of Operation Dragoon was an Allied Victory. It enabled the Allies to liberate most of Southern France in only four weeks. In the process, they inflicted heavy casualties on the German forces.");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case "effects":
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        WriteLineWordWrap("Operation Dragoon led to the Allied Forces being able to use Southern Frances Ports to launch their battleships. They were also able to use Southern Frances Railroads so they could deliver supplies to the Allies on the front lines. ");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case "quit":
                        exit = true;
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine();
                        Console.WriteLine("Goodbye!");
                        System.Threading.Thread.Sleep(2000);
                        break;

                    case "about":
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        WriteLineWordWrap("Made by.... Well, somebody");
                        System.Threading.Thread.Sleep(2000);
                        WriteLineWordWrap("Would you like me to open up a link to the source code? (y/n)");
                        string aboutanswer = Console.ReadLine();
                        if (aboutanswer.Equals("y", StringComparison.OrdinalIgnoreCase)) OpenURL("https://github.com/lXxMangoxXl/Operation-Dragoon-Project/blob/master/Operation%20Dragoon/Program.cs");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("You didn't enter a valid query!");
                        break;
                        
                }
            }
        }

        static void OpenURL(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    //Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true }); //Commandline method
                    Process.Start("explorer.exe", url); //Explorer.exe method (probably more usable on other devices)
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
            return;
        }

        public static void WriteLineWordWrap(string paragraph, int tabSize = 8)
        {
            string[] lines = paragraph
                .Replace("\t", new String(' ', tabSize))
                .Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            for (int i = 0; i < lines.Length; i++)
            {
                string process = lines[i];
                List<String> wrapped = new List<string>();

                while (process.Length > Console.WindowWidth)
                {
                    int wrapAt = process.LastIndexOf(' ', Math.Min(Console.WindowWidth - 1, process.Length));
                    if (wrapAt <= 0) break;

                    wrapped.Add(process.Substring(0, wrapAt));
                    process = process.Remove(0, wrapAt + 1);
                }

                foreach (string wrap in wrapped)
                {
                    Console.WriteLine(wrap);
                }

                Console.WriteLine(process);
            }
        }
    }
}
