using System;
using System.Collections.Generic;
using System.IO;

namespace Studio3
{
    class Program
    {
        static void Main()
        {
            //string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            //Console.WriteLine("Enter a string of text: ");
            //string text = Console.ReadLine();
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader("TestFile.txt.txt"))
                {
                    // Read the stream as a string, and write the string to the console.
                    string text = sr.ReadToEnd();
                    Console.WriteLine(text);

                    Dictionary<char, int> countedCharacters = Count.CountChars(text);
                    foreach (KeyValuePair<char, int> item in countedCharacters)
                    {
                        Console.WriteLine($"{item.Key} : {item.Value}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }


           

            //super bonus
            //https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-read-text-from-a-file
        }
    }
}
