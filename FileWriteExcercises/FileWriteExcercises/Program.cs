using System;
using System.IO;

namespace FileWriteExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using the following code:
            //string[] lines = { "Hello", "World", "!" };
            //File.WriteAllText(@"C:\Users\YOURUSER\YOURWORKINGDIR\file.txt", lines);
            //string readText = File.ReadAllText(@"C:\Users\YOURUSER\YOURWORKINGDIR\file.txt");
            //Console.WriteLine(readText);
            //Add a conditional check with the File.Exists() method to make sure the file exists before writing to it
            //Use any of the other File methods to explore and introduce additional functionality, record your findings

            string path = $@"C:\Users\Admin\Desktop\TDP-CSharp-Wednesday\C-FileWrite-test\file.txt";
            string[] lines = { "Hello", "World", "!" };

            Console.WriteLine(File.Exists(path));

            File.WriteAllLines(path, lines);

            string readText = File.ReadAllText(@"C:\Users\Admin\Desktop\TDP-CSharp-Wednesday\C-FileWrite-test\file.txt");

            Console.WriteLine(readText);

            //=================Excercise 2=================//
            //Select some ASCII art that you like from the following site: https://www.asciiart.eu/
            //Use the File IO methods to select your art and print it to the console

            //string pathAscii = $@"C:\Users\Admin\Desktop\C-FileWrite-test\ascii.txt";

            string readAscii = File.ReadAllText($@"C:\Users\Admin\Desktop\TDP-CSharp-Wednesday\C-FileWrite-test\ascii.txt");

            Console.WriteLine(readAscii);

        }
    }
}
