﻿//Entire tree declaration from GitProject
// https://github.com/VeronicaCucamonga/DeweyDecimalClassification
// https://www.youtube.com/watch?v=EbEm5kohPfE&t=97s&ab_channel=MooICT
// https://github.com/Acearino5/Dewey_Decimal_System_Trainer/tree/main
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GameAttempt;
using GameAttempt.Classes;
using GameAttempt.Components;
using GameAttempt.Games;
using GameAttempt.GeneralScreens;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GameAttempt.Components
{
    public partial class ReplacingBooksUC : UserControl
    {
        private static Random random = new Random();
        ListClass listClass = new ListClass();
        RanGenClass ranGen = new RanGenClass(); // Added this line

        // Declarations
        public List<string> sortedNum = new List<string>();
        public List<string> userInput = new List<string>();
        public List<string> rndCallNum = new List<string>();

        private SortingClass bubbleSort = new SortingClass();
        private List<string> randomGen = new List<string>();

        private int attemptsLeft = 2;
        private static int score = 0;

        public ReplacingBooksUC()
        {
            InitializeComponent();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        private void ReplacingBooksUC_Load(object sender, EventArgs e)
        {
            GenerateRandomCallNumbers();
            setButtonText();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        #region AnswerButtons
        //checks if answer is correct or incorrect and updates DB
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (userInput.Count < 10)
            {
                MessageBox.Show("Please select 10 Call Numbers!");
            }
            else
            {
                // if statement to check if user answer is correct
                if (userInput.SequenceEqual(sortedNum))
                {
                    // if user input is correct
                    DisplayResult("Congratulations! You won! You will no proceed to level 2, Identifying Areas");
                    score += 10; // Increase score by 10 for each correct call number
                    IdentifyAreas identifyAreas = new IdentifyAreas();
                    identifyAreas.ShowDialog();
                }
                else
                {
                    // if user input is incorrect
                    DisplayResult("Sorry, you lost. Try again!");
                    ResetForNextAttempt();
                }

                attemptsLeft--;

                if (attemptsLeft == 0)
                {
                    GameOverScreen gameOver = new GameOverScreen(); 
                    gameOver.ShowDialog();
                }
            }
        }
        #endregion
        //---------------------------------------------------------------------------------------------------------------------------------------------//
        #region ButtonEvents
        //-----------------------------------------------------------------------------------------------------------------------------------
        private void exitButton_Click(object sender, EventArgs e)
        {
            Form1 start = new Form1();
            start.ShowDialog();
        }
        //------------------------------------------------------------------------------------------------------------------------------------
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on the books one by won to form the order, you only get 2 attempt", "How to Play", MessageBoxButtons.OK);
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        private void btnBook1_Click(object sender, EventArgs e)
        {
            //Disables button once clicked
            btnBook1.Enabled = false;


            //adds button text to userInput list
            userInput.Add(btnBook1.Text);

            setUserText();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        private void btnBook2_Click(object sender, EventArgs e)
        {
            //Disables button once clicked
            btnBook2.Enabled = false;


            //adds button text to userInput list
            userInput.Add(btnBook2.Text);

            //sets user input button text
            setUserText();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        private void btnBook3_Click(object sender, EventArgs e)
        {
            //Disables button once clicked
            btnBook3.Enabled = false;

            //adds button text to userInput list
            userInput.Add(btnBook3.Text);

            //sets user input button text
            setUserText();
        }
        private void btnBook4_Click(object sender, EventArgs e)
        {
            //Disables button once clicked
            btnBook4.Enabled = false;

            //adds button text to userInput list
            userInput.Add(btnBook4.Text);

            //sets user input button text
            setUserText();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        private void btnBook5_Click(object sender, EventArgs e)
        {
            //Disables button once clicked
            btnBook5.Enabled = false;

            //adds button text to userInput list
            userInput.Add(btnBook5.Text);

            //sets user input button text
            setUserText();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        private void btnBook6_Click(object sender, EventArgs e)
        {
            //Disables button once clicked
            btnBook6.Enabled = false;

            //adds button text to userInput list
            userInput.Add(btnBook6.Text);

            //sets user input button text
            setUserText();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        private void btnBook7_Click(object sender, EventArgs e)
        {
            //Disables button once clicked
            btnBook7.Enabled = false;

            //adds button text to userInput list
            userInput.Add(btnBook7.Text);

            //sets user input button text
            setUserText();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        private void btnBook8_Click(object sender, EventArgs e)
        {
            //Disables button once clicked
            btnBook8.Enabled = false;


            //adds button text to userInput list
            userInput.Add(btnBook8.Text);

            //sets user input button text
            setUserText();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        private void btnBook9_Click(object sender, EventArgs e)
        {
            //Disables button once clicked
            btnBook9.Enabled = false;


            //adds button text to userInput list
            userInput.Add(btnBook9.Text);

            //sets user input button text
            setUserText();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        private void btnBook10_Click(object sender, EventArgs e)
        {
            //Disables button once clicked
            btnBook10.Enabled = false;


            //adds button text to userInput list
            userInput.Add(btnBook10.Text);

            //sets user input button text
            setUserText();
        }
        #endregion
        //--------------------------------------------------------------------------------------------------------------------------------------------
        #region HelperMethods
        private void GenerateRandomCallNumbers()
        {
            RanGenClass gen = new RanGenClass();
            rndCallNum = gen.GenerateRandomNumbers(3, 10);
            sortedNum.AddRange(rndCallNum); // Copy random call numbers for later comparison
            bubbleSort.bubbleSort(sortedNum); // Sort the random call numbers using SortingClass
        }

        private void setButtonText()
        {
            try
            {
                // Sets button text to specific index in random call numbers list
                btnBook1.Text = rndCallNum[0];
                btnBook2.Text = rndCallNum[1];
                btnBook3.Text = rndCallNum[2];
                btnBook4.Text = rndCallNum[3];
                btnBook5.Text = rndCallNum[4];
                btnBook6.Text = rndCallNum[5];
                btnBook7.Text = rndCallNum[6];
                btnBook8.Text = rndCallNum[7];
                btnBook9.Text = rndCallNum[8];
                btnBook10.Text = rndCallNum[9];
            }
            catch 
            {
                GameOverScreen gameOver = new GameOverScreen();
                gameOver.ShowDialog();
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void setUserText()
        {
            // Sets button text or leaves blank
            for (int i = 0; i < 10; i++)
            {
                var sortBook = Controls.Find($"sortBook{i + 1}", true).FirstOrDefault();

                if (sortBook is Button button)
                {
                    button.Text = (i < userInput.Count) ? userInput[i] : "???";
                }
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void DisplayResult(string message)
        {
            MessageBox.Show(message);
            btnCheck.Enabled = false; // Disable check button so the user can't submit the same answer twice
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void ResetForNextAttempt()
        {
            rndCallNum.Clear();
            sortedNum.Clear();
            userInput.Clear();
            
            setUserText();

            btnCheck.Enabled = true;
            btnBook1.Enabled = true;
            btnBook2.Enabled = true;
            btnBook3.Enabled = true;
            btnBook4.Enabled = true;
            btnBook5.Enabled = true;
            btnBook6.Enabled = true;
            btnBook7.Enabled = true;
            btnBook8.Enabled = true;
            btnBook9.Enabled = true;
            btnBook10.Enabled = true;

            GenerateRandomCallNumbers();
        }
        #endregion
    }
}
//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| END OF FILE ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||