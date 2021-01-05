using System;
using System.Globalization;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

//mcs the CS file to compile mcs Program.cs
//mono the exe file to run mono Program.exe
//do from terminal self note

using Assignment4;

namespace Assignment4
{
    class Program
    {

        private string secretWord;
        private string geussedWord;
        private int attemptsattempts = 1;

        static void Main(string[] args){
            if (args.Length != 1) {
                Console.WriteLine("invalid number of arguments!");
                Console.WriteLine("usage: assignment[2-3] <filename>");
                return;
            }
            string filename = args[0];
            Program myProgram = new Program();
            myProgram.Start(filename);
        }

        void Start(string filename) {
            secretWord = SelectWord(ListOfWords(filename));

            do{
                Console.Write("Enter a 5 letter word, attempts: " + attempts + " : ");
                geussedWord = Console.ReadLine();

                DisplayWord(geussedWord.ToUpper());
                    
                attempts++;
                
            } while(!IsGuessed()); 

            if(IsGuessed())
                Console.WriteLine("You Won!");
            else 
                Console.WriteLine("You lost");    

        }

        void DisplayWord(string word){

            char[] charsWord = word.ToCharArray();
            char[] charsSecretWord = secretWord.ToCharArray();

            if(charsWord.Length != 5)
                return false;
            
            for(int i = 0; i < charsWord.Length; i++ ){
                if(charsWord[i] == charsSecretWord[i]){
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(charsWord[i]);
                } else {
                    Console.Write(charsWord[i]);
                }
                Console.ResetColor();  
            }
            Console.WriteLine();
        }

        List<string> ListOfWords(string filename){
            return System.IO.File.ReadLines(filename).ToList();
        }

        string SelectWord(List<string> words){
            Random ran = new Random();
            return words[ran.Next(0, words.Count)];
        }

        public bool IsGuessed(){
            return geussedWord == secretWord;
        }
    }
}
