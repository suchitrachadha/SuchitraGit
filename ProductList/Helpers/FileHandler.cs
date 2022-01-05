using System.IO;
using System.Collections;
using System.Collections.Generic;

/*****************************************************
 * File Handler class that creates and returns a file name
 * 
 *  Developed by Suchitra Chadha 
 *  Developed on 23 December 2021
 * ***************************************************/


namespace ProductList.Helpers
{
    public class FileHandler
    {
        public static string WriteToFile()
        {
            Console.WriteLine("Please enter the file path you want to save the file in, ex: C:\\UserTemp");
            string FilePath = Console.ReadLine().ToString();
            Directory.CreateDirectory(FilePath);
            var timeStamp = DateTime.Now.ToFileTime();
            FilePath = FilePath + @"\" + timeStamp + ".txt";
            return FilePath;

        }
    }
}