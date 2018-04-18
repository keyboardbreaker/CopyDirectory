using NUnit.Framework;
using System;

namespace CopyDirectory.Test
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(@"C:\temp\someFile.txt", @"C:\temp1\someFile.txt")]
        public void BasicFileCopy(string input, string output)
        {
            HandleCopy hc = new HandleCopy();
            Assert.AreEqual("Copy Successful" , hc.CopyFolder(input, output), 
                "Convertion error");
        }

    }
}
