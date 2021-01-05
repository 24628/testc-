using System;
using System.Globalization;
using System.Threading;
using System.IO;
using System.Collections.Generic;

//mcs the CS file to compile mcs Program.cs
//mono the exe file to run mono Program.exe
//do from terminal self note


namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1) {
                Console.WriteLine("invalid number of arguments!");
                Console.WriteLine("usage: assignment[3-4] <filename>");
                return;
            }
            string filename = args[0];
            Program myProgram = new Program();
            myProgram.Start(filename);
        }
        void Start(string filename)
        {
            Dictionary<string, string> dictionary = ReadWords(filename);
            string input;
            do {
                input = Console.ReadLine();
                if (input == "listall"){
                    ListAllWords(dictionary);
                } else if (input == "stop"){
                    Console.ReadKey();
                } else {
                    TranslateWords(dictionary, input);
                }
            } while(input != "stop");
        }

        Dictionary<string, string> ReadWords(string filename){
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            using(var reader = new StreamReader(filename))
            {
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    dictionary.Add(values[0], values[1]);
                }
            }
            return dictionary;
        }

        void ListAllWords(Dictionary<string, string> words){
            foreach( KeyValuePair<string, string> w in words ) {
                Console.WriteLine("{0} => {1}", w.Key, w.Value);
            }
        }

        void TranslateWords(Dictionary<string, string> dictionary, string word){
            try {
                Console.WriteLine(word + " => {0}.", dictionary[word]);
            }
            catch (KeyNotFoundException) {
                Console.WriteLine("word "+  word + " not found");
            }
        }
    }
}
