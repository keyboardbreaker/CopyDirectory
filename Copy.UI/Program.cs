using System;
using CopyDirectory;
using System.IO;

namespace Copy.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            HandleCopy hc = new HandleCopy();
            //var path = @"C:\temp\newfolder";
            //var newPath = @"C:\temp\newfolder1";

            do
            {

                //6. Users must be able to pick or specify a source and target directory.
                Console.WriteLine("Please specify source to copy: ");
                var userSource = Console.ReadLine().Trim();
                if (Directory.Exists(userSource))
                {
                    Console.WriteLine("Please specify target to copy to: ");
                    var userTarget = Console.ReadLine().Trim();

                    try
                    {
                        hc.CopyFolder(userSource, userTarget, true);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid paths");
                        Console.WriteLine(e.Message);
                    }
                }

                else
                {
                    Console.WriteLine("The source directory does not exist. ");
                }

                Console.WriteLine("Do you wish to continue y/n");
                var again = Console.ReadLine().Trim();
                if (again == "n")
                    break;
                else if(again == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("I dont know that command, continue");
                }
            }
            while (true);
        }
    }
}
