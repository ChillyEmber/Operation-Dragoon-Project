using System;
using System.Diagnostics;
using System.Runtime;
using System.Runtime.InteropServices;

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
                Console.WriteLine("Please enter a query to get information based on the war, Operation Dragoon!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Avaiable entries are \"who\", \"what\", \"where\", \"when\", \"why\", and \"how\". You can also type \"quit\" to quit, and \"about\" to see who this was made by!");
                Console.ForegroundColor = ConsoleColor.White;
                string entry = Console.ReadLine();
                switch (entry)
                {
                    case "who":
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("The countries that fought in the war are...");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case "when":
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Operation Dragoon started on August 15th, 1944, and came to an end on September 14th 1944.");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case "quit":
                        exit = true;
                        Console.WriteLine("Goodbye!");
                        System.Threading.Thread.Sleep(2000);
                        break;

                    case "about":
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Made by.... Well, somebody");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("Would you like me to open up a link to the source code?");
                        string aboutanswer = Console.ReadLine();
                        if (aboutanswer == "y") OpenURL("https://github.com/lXxMangoxXl/Operation-Dragoon-Project/blob/master/Operation%20Dragoon/Program.cs");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case "where":
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Operation Dragoon happened in one spot, happening in Côte d'Azur, South France.");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Would you like me to open a picture depecting a map before the war? (y/n)");
                        Console.ForegroundColor = ConsoleColor.White;
                        string answer = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        if (answer == "y")
                        {
                            OpenURL("https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/Operation_Dragoon_-_map.jpg/450px-Operation_Dragoon_-_map.jpg");
                            Console.WriteLine("As mentioned above, this is a image...");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Would you like to see a picture of where the landings were? (y/n)");
                        Console.ForegroundColor = ConsoleColor.White;
                        answer = Console.ReadLine();
                        if(answer == "y")
                        {
                            OpenURL("https://upload.wikimedia.org/wikipedia/commons/thumb/f/f5/Anvildragoon.png/330px-Anvildragoon.png");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("This image depicts all of the landing spots");
                        }
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
    }
}
