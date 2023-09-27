using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAttempt.Classes
{
    public class SortingClass
    {
        ListClass listClass = new ListClass();

        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        //Deaukt Constructor
        public SortingClass() 
        {
            
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///----------CODE ATTRIBUTION----------
        /// Publisher: W3Resources
        /// Date: 19 August 2022
        /// URL: https://www.w3resource.com/csharp-exercises/string/csharp-string-exercise-12.php
        /// This code preforms a bubble sorting algorithm with the call list
        /// </summary>
        public void bubbleSort()
        {
            string temp;

            for (int count = 0; count < listClass.GetCallNumList().Count; count++)
            {
                for (int i = 0; i < listClass.GetCallNumList().Count - 1; i++)
                {
                    if (listClass.GetCallNumList()[i].CompareTo(listClass.GetCallNumList()[i + 1]) > 0)
                    {
                        temp = listClass.GetCallNumList()[i];
                        listClass.GetCallNumList()[i] = listClass.GetCallNumList()[i + 1];
                        listClass.GetCallNumList()[i + 1] = temp;
                    }
                }
            }
        }
    }
}
//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| END OF FILE ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||