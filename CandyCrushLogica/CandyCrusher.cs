using System;
using System.Globalization;
using System.Threading;

//mcs the CS file to compile mcs Program.cs
//mono the exe file to run mono Program.exe
//do from terminal self note

namespace CandyCrusherLogica
{
    class CandyCrusher
    {
        public static bool ScoreRowPresent(RegularCandies[,] playingField){
            for(int i = 0; i < playingField.GetLength(0); i++){
                for(int j = 0; j < playingField.GetLength(1); j++){
                    if(j > 2){
                        if((int)playingField[i,j] == (int)playingField[i,(j - 1)] && (int)playingField[i,j] == (int)playingField[i,(j - 2)]){
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public static bool ScoreColumnPresent(RegularCandies[,] playingField){
            for(int i = 0; i < playingField.GetLength(0); i++){
                for(int j = 0; j < playingField.GetLength(1); j++){
                    if(i > 2){
                        if((int)playingField[i,j] == (int)playingField[(i - 1),j] && (int)playingField[i,j] == (int)playingField[(i- 2),j]){
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
