﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace POST_DAL
{
    public class BaseDAL
    {
        internal void Save(string text, string fileName)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory,
                fileName);
            StreamWriter sw = new StreamWriter(filePath, append: true);
            sw.WriteLine(text);
            sw.Close();
        }
        internal void CopyFile(string sourceFile, string destinationFile)
        {
            File.Copy(sourceFileName: sourceFile, destFileName: destinationFile, overwrite: true);
        }
        internal List<string> Read(string fileName)
        {
            List<string> list = new List<string>();
            string filePath = Path.Combine(Environment.CurrentDirectory,
                fileName);
            StreamReader sr = new StreamReader(filePath);
            string line = String.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                list.Add(line);
            }
            return list;
        }
    }
}
