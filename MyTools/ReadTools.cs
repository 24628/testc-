using System;
using System.Globalization;
using System.Threading;

//mcs the CS file to compile mcs Program.cs
//mono the exe file to run mono Program.exe
//do from terminal self note

namespace MyTools
{
    class ReadTools
    {
        public static int ReadInt(string question){
            Console.WriteLine(question);
            return Int32.Parse(Console.ReadLine());
        }

        public static int ReadInt(string question, int min, int max){

            int waarde = ReadInt(question); 
            while ((waarde < min) || (waarde > max)) { 
                waarde = ReadInt(question);
            } 
            return waarde;
        }

        public static string ReadString(string question){
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
