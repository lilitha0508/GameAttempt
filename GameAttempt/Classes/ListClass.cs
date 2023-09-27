using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAttempt.Classes
{
    public class ListClass
    {
        //Lists 
        private List<string> ranNum = new List<string>();
        private List<string> userSrt = new List<string>();
        private List<string> correctNum = new List<string>();

        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        //Deaukt Constructor
        public ListClass() 
        {
            
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> GetCallNumList()
        {
            return ranNum;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> GetUserSrtList()
        {
            return userSrt;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> GetCorrectList()
        {
            return correctNum;
        }
    }
}
//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| END OF FILE ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||