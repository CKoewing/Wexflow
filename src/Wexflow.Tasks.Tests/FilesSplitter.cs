﻿using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wexflow.Tasks.Tests
{
    [TestClass]
    public class FilesSplitter
    {
        private static readonly string FilesSplitterFolder = @"C:\WexflowTesting\FilesSplitter\";

        [TestInitialize]
        public void TestInitialize()
        {
            Helper.DeleteFiles(FilesSplitterFolder);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Helper.DeleteFiles(FilesSplitterFolder);
        }

        [TestMethod]
        public void Run()
        {
            string[] files = GetFiles();
            Assert.AreEqual(0, files.Length);
            Helper.StartWorkflow(57);
            files = GetFiles();
            Assert.AreEqual(6, files.Length);
        }

        private string[] GetFiles()
        {
            return Directory.GetFiles(FilesSplitterFolder, "*_*");
        }
    }
}
