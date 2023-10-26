using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAttempt.Classes
{
    public class matchTheColumn
    {
        //Descrption strings
        string desc0 = "General Knowledge";
        string desc1 = "Philosophy and Psychology";
        string desc2 = "Religion";
        string desc3 = "Social Science";
        string desc4 = "Languages";
        string desc5 = "Science";
        string desc6 = "Technology";
        string desc7 = "Arts  and Recreation";
        string desc8 = "Literature";
        string desc9 = "History and Geography";

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method that gets the user input and adds it to a dictionary for comparison
        /// </summary>
        /// <param name="userInputColumnA"></param>
        /// <param name="UserInputColumnB"></param>
        /// <param name="userInputDictionary"></param>
        /// <returns></returns>
        public Dictionary<string, string> getUserInputDictionary(List<string> userInputColumnA, List<string> UserInputColumnB, Dictionary<string, string> userInputDictionary)
        {
            for (int i = 0; i < 4; i++)
            {
                userInputDictionary.Add(userInputColumnA[i], UserInputColumnB[i]);

            }
            return userInputDictionary;
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method that adds call numbers and corresponding catergory to dictionary
        /// </summary>
        /// <param name="correctCallNumOrder"></param>
        /// <returns></returns>
        public Dictionary<string, string> getCorrectCallNumDictionary(List<string> correctCallNumOrder)
        {
            Dictionary<string, string> dictionaryCallNum = new Dictionary<string, string>();
            char firstChar;

            foreach (var item in correctCallNumOrder)
            {
                firstChar = item[0];
                dictionaryCallNum.Add(item, getDesc(firstChar));
            }
            return dictionaryCallNum;
        }


        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// method that will store the correct answer in a dictionary 
        /// </summary>
        /// <param name="correctCallNumOrder"></param>
        /// <returns></returns>
        public Dictionary<string, string> getCorrectDescDic(List<string> correctCallNumOrder)
        {
            Dictionary<string, string> dictionaryCallNum = new Dictionary<string, string>();
            char firstChar;
            Random rnd = new Random();
            List<string> tempList = new List<string>();
            List<string> addToDictionary = new List<string>();

            foreach (var item in correctCallNumOrder)
            {
                tempList.Add(item);
            }

            for (int i = 0; i < 4; i++)
            {
                int index = rnd.Next(tempList.Count);
                addToDictionary.Add(tempList[index]);
                tempList.RemoveAt(index);
            }

            foreach (var item in addToDictionary)
            {
                firstChar = item[0];
                dictionaryCallNum.Add(item, getDesc(firstChar));
            }
            return dictionaryCallNum;
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// method that will add the correct answer to category list
        /// </summary>
        /// <param name="dictionaryCallNum"></param>
        /// <returns></returns>
        public List<string> getCorrectDescOrder(Dictionary<string, string> dictionaryCallNum)
        {
            List<string> tempList = new List<string>();

            foreach (var item in dictionaryCallNum)
            {
                tempList.Add(item.Value);
            }
            return tempList;
        }


        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// switch statement to select correct catergory based on first char
        /// </summary>
        /// <param name="firstChar"></param>
        /// <returns></returns>
        public string getDesc(char firstChar)
        {
            string descrption = null;

            switch (firstChar)
            {
                case '0':
                    descrption = desc0;
                    break;
                case '1':
                    descrption = desc1;
                    break;
                case '2':
                    descrption = desc2;
                    break;
                case '3':
                    descrption = desc3;
                    break;
                case '4':
                    descrption = desc4;
                    break;
                case '5':
                    descrption = desc5;
                    break;
                case '6':
                    descrption = desc6;
                    break;
                case '7':
                    descrption = desc7;
                    break;
                case '8':
                    descrption = desc8;
                    break;
                case '9':
                    descrption = desc9;
                    break;
            };
            return descrption;
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method that will randomize the descrption list
        /// </summary>
        /// <param name="dictionaryCallNum"></param>
        /// <param name="randomCategoryOrder"></param>
        public void randomizeDes(Dictionary<string, string> dictionaryCallNum, List<string> randomCategoryOrder)
        {
            List<string> tempList = new List<string>();
            List<string> categoryTempList = new List<string>();
            Random rnd = new Random();

            foreach (var item in dictionaryCallNum)
            {
                tempList.Add(item.Value);
            }

            //adds all categories that are wrong to list
            foreach (var item in addCategoriesToList())
            {
                if (!tempList.Contains(item))
                {
                    categoryTempList.Add(item);
                }

            }

            //selects 3 random wrong categories from list and adds to list with correct and wrong answers
            for (int i = 0; i < 3; i++)
            {
                int index = rnd.Next(categoryTempList.Count);
                tempList.Add(categoryTempList[index]);
                categoryTempList.RemoveAt(index);
            }

            //for loop to select random index and insert that indexs value into random category list
            for (int i = 0; i < 7; i++)
            {
                int index = rnd.Next(tempList.Count);
                randomCategoryOrder.Add(tempList[index]);
                tempList.RemoveAt(index);
            }

        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// adds categories to list
        /// </summary>
        /// <returns></returns>
        public List<string> addCategoriesToList()
        {
            List<string> categoryTempList = new List<string>();

            categoryTempList.Add(desc0);
            categoryTempList.Add(desc1);
            categoryTempList.Add(desc2);
            categoryTempList.Add(desc3);
            categoryTempList.Add(desc4);
            categoryTempList.Add(desc5);
            categoryTempList.Add(desc6);
            categoryTempList.Add(desc7);
            categoryTempList.Add(desc8);
            categoryTempList.Add(desc9);

            return categoryTempList;
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method that randomizeses the call numbers
        /// </summary>
        /// <param name="correctCallNumOrder"></param>
        /// <param name="randomCallNumOrder"></param>
        public void randomizeCallNum(List<string> correctCallNumOrder, List<string> randomCallNumOrder)
        {
            List<string> tempList = new List<string>();
            Random rnd = new Random();

            foreach (var item in correctCallNumOrder)
            {
                tempList.Add(item);
            }

            //for loop to select random index and insert that indexs value into random call number list
            for (int i = 0; i < 4; i++)
            {
                int index = rnd.Next(tempList.Count);
                randomCallNumOrder.Add(tempList[index]);
                tempList.RemoveAt(index);
            }
        }


        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// generates 7 random numbers
        /// </summary>
        /// <param name="correctCallNumOrder"></param>
        /// <returns></returns>
        public List<string> randomizeSevenCallNum(List<string> correctCallNumOrder)
        {
            List<string> randomCallNumOrder = new List<string>();
            List<string> tempList = new List<string>();
            Random rnd = new Random();

            foreach (var item in correctCallNumOrder)
            {
                tempList.Add(item);

            }

            //for loop to select random index and insert that indexs value into random call number list
            for (int i = 0; i < 7; i++)
            {
                int index = rnd.Next(tempList.Count);
                randomCallNumOrder.Add(tempList[index]);
                tempList.RemoveAt(index);
            }
            return randomCallNumOrder;
        }


        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// method to generates random call numbers
        /// </summary>
        /// <returns></returns>
        public List<string> generateCallNumbers()
        {
            Random rnd = new Random();
            List<string> calls = new List<string>();

            for (int i = 0; i < 4; i++)
            {
                int randomNumber = rnd.Next(900); // Generate a random number between 0 and 999
                calls.Add(randomNumber.ToString("D3")); // Convert it to a 3-digit string with leading zeros if needed
            }
            return calls;
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// method to generate 7 numbers for the call numbers
        /// </summary>
        /// <returns></returns>
        public List<string> generateSevenRandomCallNumbers()
        {
            Random rnd = new Random();
            List<string> calls = new List<string>();

            for (int i = 0; i < 7; i++)
            {
                int randomNumber = rnd.Next(900);
                calls.Add(randomNumber.ToString("D3"));
            }
            return calls;
        }
    }
}
//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| END OF FILE ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
