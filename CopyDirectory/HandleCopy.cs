using System;
using System.IO;

namespace CopyDirectory
{
    public class HandleCopy
    {   
        public void CopyFolder(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
                Console.WriteLine("copying from: " +sourceDirName+ @"\"+ file +
                                           " to: " + destDirName + @"\"+ file);
            }

            // If copying subfolders, copy them and the files to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    //8. recursive call
                    CopyFolder(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
    }
}
