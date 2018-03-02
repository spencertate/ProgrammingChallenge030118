using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingChallenge030118
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] output = AddFillers("Mr John Smith    ".ToArray<char>(), 13);
            foreach(char c in output)
            {
                Console.Write(c);
            }
            Console.Read();
        }

        public static char[] AddFillers(char[] iArray, int trueLength)
        {
            int trueTrack = trueLength - 1;
            for(int i = iArray.Length-1; i >= 0; i--)
            {
                if(iArray[trueTrack] != ' ')
                {
                    iArray[i] = iArray[trueTrack];    
                }
                else
                {
                    iArray[i] = '0';
                    i--;
                    iArray[i] = '2';
                    i--;
                    iArray[i] = '%';
                }
                trueTrack--;
            }
            return iArray;
        }
    }
}
