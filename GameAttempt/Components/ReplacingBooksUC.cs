using GameAttempt.Classes;
using GameAttempt.Games;
using GameAttempt.GeneralScreens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameAttempt.Components
{
    public partial class ReplacingBooksUC : UserControl
    {

        private static Random random = new Random();
        Classes.RanGenClass ranGen = new Classes.RanGenClass();
        ListClass listClass = new ListClass();
        Classes.SortingClass bubbleSort = new Classes.SortingClass();
        
        List<string> randomGen = new List<string>();

        private static int score = 0;

        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public ReplacingBooksUC()
        {
            InitializeComponent();

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Numbers display when the page loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReplacingBooksUC_Load(object sender, EventArgs e)
        {
            // Generate random 10 call numbers
            var randomNumbers = ranGen.GenerateRandomNumbers(3, 10);

            // Create an array of buttons
            Button[] buttons = new Button[]
            {
                btnBook1, btnBook2, btnBook3, btnBook4, btnBook5, btnBook6, btnBook7, btnBook8, btnBook9, btnBook10
            };

            for (int i = 0; i < Math.Min(randomNumbers.Count, buttons.Length); i++)
            {
                buttons[i].Text = randomNumbers[i];
            }

            //Drag and Drop
            ControlExtension.Draggable(btnBook1, true);
            ControlExtension.Draggable(btnBook2, true);
            ControlExtension.Draggable(btnBook3, true);
            ControlExtension.Draggable(btnBook4, true);
            ControlExtension.Draggable(btnBook5, true);
            ControlExtension.Draggable(btnBook6, true);
            ControlExtension.Draggable(btnBook7, true);
            ControlExtension.Draggable(btnBook8, true);
            ControlExtension.Draggable(btnBook9, true);
            ControlExtension.Draggable(btnBook10, true);

            //plays music
            StartPageUS.play.controls.play();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            listClass.GetCorrectList().Clear();

            bubbleSort.bubbleSort();

            //error handling
            if (panBookRowSortList.Controls.Count == 0)
            {
                //MessageBox.Show("Please Rearrange the Numbers");
                panBookRowSortList.BackColor = System.Drawing.Color.Red;
            }
            else if (panBookRowRanList.Controls.Count == 0)
            {
                MessageBox.Show("Please Click the Check Button");
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    //converts users reordered items to string and stores them into the list
                    listClass.GetUserSrtList().Add(btnBook1.Text[i].ToString());
                    listClass.GetUserSrtList().Add(btnBook2.Text[i].ToString());
                    listClass.GetUserSrtList().Add(btnBook3.Text[i].ToString());
                    listClass.GetUserSrtList().Add(btnBook4.Text[i].ToString());
                    listClass.GetUserSrtList().Add(btnBook5.Text[i].ToString());
                    listClass.GetUserSrtList().Add(btnBook6.Text[i].ToString());
                    listClass.GetUserSrtList().Add(btnBook7.Text[i].ToString());
                    listClass.GetUserSrtList().Add(btnBook8.Text[i].ToString());
                    listClass.GetUserSrtList().Add(btnBook9.Text[i].ToString());
                    listClass.GetUserSrtList().Add(btnBook10.Text[i].ToString());
                }

                //checks if the two lists sequences are the same
                bool equal = Enumerable.SequenceEqual(listClass.GetUserSrtList(), listClass.GetCorrectList());

                if (equal)
                {
                    //user gets it right they receive 10 points
                    WinningScreen winning = new WinningScreen();
                    winning.Show();
                    this.Hide();
                    StartPageUS.play.controls.stop();


                    score += 10;
                    lblScore.Text = Convert.ToString(score);

                    //clear lists
                    listClass.GetUserSrtList().Clear();
                    listClass.GetCorrectList().Clear();
                    listClass.GetCallNumList().Clear();

                    //generate new 10 numbers
                    var randomNumbers = ranGen.GenerateRandomNumbers(3, 10);

                    // Create an array of buttons
                    Button[] buttons = new Button[]
                    {
                        btnBook1, btnBook2, btnBook3, btnBook4, btnBook5, btnBook6, btnBook7, btnBook8, btnBook9, btnBook10
                    };

                    for (int i = 0; i < Math.Min(randomNumbers.Count, buttons.Length); i++)
                    {
                        buttons[i].Text = randomNumbers[i];
                    }
                }
                else
                {
                    //user gets it wrong 
                    GameOverScreen gameOver = new GameOverScreen();
                    gameOver.Show();
                    this.Hide();
                }
            }
            //lists are cleared after each test
            listClass.GetUserSrtList().Clear();
            listClass.GetCorrectList().Clear();

        }
    }
}
//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| END OF FILE ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||