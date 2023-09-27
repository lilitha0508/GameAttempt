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
        public string GenerateRandomNo(int stringLength)
        {
            //generates random String
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var ranString = new string(Enumerable.Repeat(chars, stringLength)
                .Select(a => a[random.Next(a.Length)]).ToArray());

            //generates random numbers
            var ranNum = random.Next(001, 999);
            var randNum2 = random.Next(10, 99);

            //joins the random string and number to make a call number
            string callNum = ranNum + "." + randNum2 + " " + ranString;
            //adds the call number to the list
            listClass.GetCallNumList().Add(callNum);

            return callNum;
        }
    }
}
//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| END OF FILE ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||