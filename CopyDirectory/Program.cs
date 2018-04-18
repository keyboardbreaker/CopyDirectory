using System;


namespace CopyDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            HandleCopy hc = new HandleCopy();
            var path = @"C:\temp\newfolder";
            var newPath = @"C:\temp\newfolder1";

            //6. Users must be able to pick or specify a source and target directory.
            Console.WriteLine("Please specify source to copy: " );
            var userSource = Console.ReadLine().Trim();
            Console.WriteLine("Please specify target to copy: ");
            var userTarget = Console.ReadLine().Trim();

            try
            {
                hc.CopyFolder(path, newPath, true);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
