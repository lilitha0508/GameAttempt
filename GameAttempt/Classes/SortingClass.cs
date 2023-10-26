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
        public void bubbleSort(List<string> list)
        {
            for (int count = 0; count < list.Count; count++)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    int num1 = ExtractNumericPart(list[i]);
                    int num2 = ExtractNumericPart(list[i + 1]);

                    if (num1 > num2)
                    {
                        Swap(list, i, i + 1);
                    }
                    else if (num1 == num2)
                    {
                        if (string.Compare(list[i], list[i + 1]) > 0)
                        {
                            Swap(list, i, i + 1);
                        }
                    }
                }
            }
        }

        private int ExtractNumericPart(string callNumber)
        {
            int numericPart;
            string[] parts = callNumber.Split('.');
            if (parts.Length > 1 && int.TryParse(parts[1], out numericPart))
            {
                return numericPart;
            }
            return 0;
        }

        private void Swap(List<string> list, int index1, int index2)
        {
            string temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| END OF FILE ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||