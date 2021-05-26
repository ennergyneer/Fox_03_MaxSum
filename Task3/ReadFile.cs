﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class ReadFile
    {

        public static string[] Processing(string path)
        {
            try
            {
                return File.ReadAllLines(path);
            }
            catch
            {
                Console.WriteLine("Error file reading");
                return new string[] { "" };
            }
        }
    }
}
