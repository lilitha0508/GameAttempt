using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAttempt.Classes
{
    public class RanGenClass
    {
        private static Random random = new Random();
        ListClass listClass = new ListClass(); 

        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        //Deaukt Constructor
        public RanGenClass() 
        { 

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Publisher: Coding Droplets
        /// Date: 30 March 2021
        /// URL: https://youtu.be/Zql7tz5Pzfg
        /// Generates the random call numbers for books
        /// </summary>
        /// <param name="stringLength"></param>
        /// <returns></returns>
        public List<string> GenerateRandomNumbers(int stringLength, int count)
        {
             const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
              List<string> callNumbers = new List<string>();

              for (int i = 0; i < count; i++)
              {
                    var ranString = new string(Enumerable.Repeat(chars, stringLength)
                        .Select(a => a[random.Next(a.Length)]).ToArray());

                    var ranNum = random.Next(1, 1000); // Generate a random number between 1 and 999 (inclusive).
                    var randNum2 = random.Next(10, 100); // Generate a random number between 10 and 99 (inclusive).

                    string callNum = $"{ranNum:D3}.{randNum2:D2} {ranString}";
                    callNumbers.Add(callNum);
              }

              return callNumbers;
        }
    }
}
//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| END OF FILE ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||