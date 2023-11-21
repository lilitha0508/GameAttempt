using GameAttempt.Classes;
<<<<<<< HEAD
using GameAttempt.Games;
using GameAttempt.GeneralScreens;
using GameAttempt.Properties;
=======
using GameAttempt.GeneralScreens;
>>>>>>> 52ac0c188cfa70f943d1dd1d9413ca3caf5e6d50
using GameAttempt.Start;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
<<<<<<< HEAD
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
=======
using System.Drawing;
using System.Linq;
>>>>>>> 52ac0c188cfa70f943d1dd1d9413ca3caf5e6d50
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

// Majority button related code is a combination of Chat,youtube and projects found on github.
// Due to some methods having more than one refrence ill list those links here
// https://github.com/VeronicaCucamonga/DeweyDecimalClassification
// https://www.youtube.com/watch?v=EbEm5kohPfE&t=97s&ab_channel=MooICT
// https://github.com/Acearino5/Dewey_Decimal_System_Trainer/tree/main

namespace GameAttempt.Components
{
    public partial class IdentifyAreaUC : UserControl
    {
        //objects
        DispatcherTimer timer = new DispatcherTimer();
        matchTheColumn match = new matchTheColumn();

        //Variables
        List<string> correctCallNumOrder = new List<string>();
        List<string> correctDesOrder = new List<string>();
        List<string> randomCallNumOrder = new List<string>();
        List<string> randomDesOrder = new List<string>();
        Dictionary<string, string> dictionaryCallNum = new Dictionary<string, string>();
        Dictionary<string, string> userInputDictionary = new Dictionary<string, string>();
        List<string> userInputColumnA = new List<string>();
        List<string> userInputColumnB = new List<string>();
        bool alternateColumns;
        int buttonClicked;

        /// <summary>
        /// ref: https://www.youtube.com/watch?v=Xdcqj-YT5jQ&ab_channel=DivitJoshi
        /// author: Divit Joshi
        /// methos that allows a dekay before the help menu pops up
        /// </summary>
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        public IdentifyAreaUC()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(waiting);
            timer.Interval = new TimeSpan(0, 0, 2);
            timer.Start();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// method for when the app loads calls the numbers and letters from the match column class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IdentifyAreaUC_Load(object sender, EventArgs e)
        {
            alternateColumns = true;
            correctCallNumOrder = match.generateCallNumbers();
            dictionaryCallNum = match.getCorrectCallNumDictionary(correctCallNumOrder);
            match.randomizeCallNum(correctCallNumOrder, randomCallNumOrder);
            match.randomizeDes(dictionaryCallNum, randomDesOrder);

            setButtonTextNumLeft();
            setUserText();
            resetCorrectButtonText();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// ref: https://www.youtube.com/watch?v=jB8q__utFwA&ab_channel=C%23UiAcademy
        /// author: C# Ui Academy
        /// methos that allows a a pop up window and adds a delay in when it pops up 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void waiting(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (IdenAreaInfo info = new IdenAreaInfo())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .60d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = false;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();
                    info.Owner = formBackground;
                    info.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
            timer.Stop();
        }
<<<<<<< HEAD
=======

>>>>>>> 52ac0c188cfa70f943d1dd1d9413ca3caf5e6d50
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// button 1 on click method that houses the case for all clicked buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void columnAButton1_Click(object sender, EventArgs e)
        {
            var Button = (Button)sender;
            switch (Button.Name)
            {
                case "columnAButton1":
                    columnAButton1.Enabled = false;
                    userInputColumnA.Add(columnAButton1.Text);
                    setUserText();
                    limitUserInput(userInputColumnA, userInputColumnB);
                    break;
                case "columnAButton2":
                    columnAButton2.Enabled = false;
                    userInputColumnA.Add(columnAButton2.Text);
                    setUserText();
                    limitUserInput(userInputColumnA, userInputColumnB);
                    break;
                case "columnAButton3":
                    columnAButton3.Enabled = false;
                    userInputColumnA.Add(columnAButton3.Text);
                    setUserText();
                    limitUserInput(userInputColumnA, userInputColumnB);
                    break;
                case "columnAButton4":
                    columnAButton4.Enabled = false;
                    userInputColumnA.Add(columnAButton4.Text);
                    setUserText();
                    limitUserInput(userInputColumnA, userInputColumnB);
                    break;

                case "columnBButton1":
                    columnBButton1.Enabled = false;
                    userInputColumnB.Add(columnBButton1.Text);
                    setUserText();
                    limitUserInput(userInputColumnA, userInputColumnB);
                    break;
                case "columnBButton2":
                    columnBButton2.Enabled = false;
                    userInputColumnB.Add(columnBButton2.Text);
                    setUserText();
                    limitUserInput(userInputColumnA, userInputColumnB);
                    break;
                case "columnBButton3":
                    columnBButton3.Enabled = false;
                    userInputColumnB.Add(columnBButton3.Text);
                    setUserText();
                    limitUserInput(userInputColumnA, userInputColumnB);
                    break;
                case "columnBButton4":
                    columnBButton4.Enabled = false;
                    userInputColumnB.Add(columnBButton4.Text);
                    setUserText();
                    limitUserInput(userInputColumnA, userInputColumnB);
                    break;
                case "columnBButton5":
                    columnBButton5.Enabled = false;
                    userInputColumnB.Add(columnBButton5.Text);
                    setUserText();
                    limitUserInput(userInputColumnA, userInputColumnB);
                    break;
                case "columnBButton6":
                    columnBButton6.Enabled = false;
                    userInputColumnB.Add(columnBButton6.Text);
                    setUserText();
                    limitUserInput(userInputColumnA, userInputColumnB);
                    break;
                case "columnBButton7":
                    columnBButton7.Enabled = false;
                    userInputColumnB.Add(columnBButton7.Text);
                    setUserText();
                    limitUserInput(userInputColumnA, userInputColumnB);
                    break;
                default:

                    break;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///  method that checks the users answer against the correct list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAnswer_Click(object sender, EventArgs e)
        {
            orderUserInput(alternateColumns);

            try
            {
                if (alternateColumns == true)
                {
                    match.getUserInputDictionary(userInputColumnA, userInputColumnB, userInputDictionary);
                }
                else
                {
                    match.getUserInputDictionary(userInputColumnB, userInputColumnA, userInputDictionary);
                }
            }
            catch (Exception)
            {
                checkErrorProvider.SetError(checkAnswer, "Please select 4 Call Numbers and 4 categories!");
            }

            checkErrorProvider.Clear();

            if (userInputColumnA.Count() < 4 && userInputColumnB.Count() < 4)
            {
                checkErrorProvider.SetError(checkAnswer, "Please select 4 Call Numbers and 4 categories!");
            }
            else
            {
                if (userInputDictionary.OrderBy(r => r.Key).SequenceEqual(dictionaryCallNum.OrderBy(r => r.Key)))
                {
                    //if user input is correct: Changes label and updates total wins
                    answerLabel.Visible = true;
                    answerLabel.Text = "Correct!";
                    answerLabel.ForeColor = Color.Green;
                    succPictureBox.Visible = true;
                    setCorrectButtonText();

                    //disables check button so user cant submit same answer twice
                    checkAnswer.Enabled = false;

                    setCorrectButtonText();
<<<<<<< HEAD

                    MessageBox.Show("Congratulations! You won! You will no proceed to level 2, Find Call Number");

                    FindCallNum findingCall = new FindCallNum();
                    findingCall.ShowDialog();
=======
>>>>>>> 52ac0c188cfa70f943d1dd1d9413ca3caf5e6d50
                }
                else
                {
                    //if user input is incorrect: changes label and updates total losses 
                    answerLabel.Visible = true;
                    answerLabel.Text = "Incorrect!";
                    answerLabel.ForeColor = Color.Red;
                    setCorrectButtonText();

                    //disables check button so user cant submit same answer twice
                    checkAnswer.Enabled = false;

                    setCorrectButtonText();
                }
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///  method that resets all the columns to allow for restart
        ///  https://www.youtube.com/watch?v=R56vwLCoWZ8&ab_channel=FlowingEdge 
        ///  used to keep track of the amount of times a button was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playAgainButtons_Click(object sender, EventArgs e)
        {
            buttonClicked++;

            if (buttonClicked == 2)
            {
                GameOverScreen gameOver = new GameOverScreen();
                gameOver.ShowDialog();
            }
            else
            {
                correctCallNumOrder.Clear();
                randomCallNumOrder.Clear();
                randomDesOrder.Clear();
                dictionaryCallNum.Clear();
                userInputDictionary.Clear();
                userInputColumnA.Clear();
                userInputColumnB.Clear();

                answerLabel.Visible = false;
                succPictureBox.Visible = false;
                checkAnswer.Enabled = true;

                if (alternateColumns == false)
                {
                    alternateColumns = true;

                    correctCallNumOrder = match.generateCallNumbers();
                    dictionaryCallNum = match.getCorrectCallNumDictionary(correctCallNumOrder);

                    match.randomizeCallNum(correctCallNumOrder, randomCallNumOrder);
                    match.randomizeDes(dictionaryCallNum, randomDesOrder);
                    setButtonTextNumLeft();
                }
                else
                {
                    alternateColumns = false;
                    correctCallNumOrder = match.generateSevenRandomCallNumbers();
                    dictionaryCallNum = match.getCorrectDescDic(correctCallNumOrder);
                    randomCallNumOrder = match.randomizeSevenCallNum(correctCallNumOrder);
                    correctDesOrder = match.getCorrectDescOrder(dictionaryCallNum);
                    setButtonTextNumRight();
                }

                resetCorrectButtonText();
                setUserText();
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// method to set the text for the rows
        /// </summary>
        private void setButtonTextNumLeft()
        {
            //sets column A button text
            columnAButton1.Text = randomCallNumOrder.ElementAt(0).ToString();
            columnAButton2.Text = randomCallNumOrder.ElementAt(1).ToString();
            columnAButton3.Text = randomCallNumOrder.ElementAt(2).ToString();
            columnAButton4.Text = randomCallNumOrder.ElementAt(3).ToString();

            //reenables buttons
            columnAButton1.Enabled = true;
            columnAButton2.Enabled = true;
            columnAButton3.Enabled = true;
            columnAButton4.Enabled = true;

            //sets column B button text
            columnBButton1.Text = randomDesOrder.ElementAt(0).ToString();
            columnBButton2.Text = randomDesOrder.ElementAt(1).ToString();
            columnBButton3.Text = randomDesOrder.ElementAt(2).ToString();
            columnBButton4.Text = randomDesOrder.ElementAt(3).ToString();
            columnBButton5.Text = randomDesOrder.ElementAt(4).ToString();
            columnBButton6.Text = randomDesOrder.ElementAt(5).ToString();
            columnBButton7.Text = randomDesOrder.ElementAt(6).ToString();

            //reenables buttons
            columnBButton1.Enabled = true;
            columnBButton2.Enabled = true;
            columnBButton3.Enabled = true;
            columnBButton4.Enabled = true;
            columnBButton5.Enabled = true;
            columnBButton6.Enabled = true;
            columnBButton7.Enabled = true;
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// method to set the text for the rows
        /// </summary>
        private void setButtonTextNumRight()
        {
            //sets column A button text
            columnAButton1.Text = correctDesOrder.ElementAt(0).ToString();
            columnAButton2.Text = correctDesOrder.ElementAt(1).ToString();
            columnAButton3.Text = correctDesOrder.ElementAt(2).ToString();
            columnAButton4.Text = correctDesOrder.ElementAt(3).ToString();

            //reenables buttons
            columnAButton1.Enabled = true;
            columnAButton2.Enabled = true;
            columnAButton3.Enabled = true;
            columnAButton4.Enabled = true;

            //sets column B button text
            columnBButton1.Text = randomCallNumOrder.ElementAt(0).ToString();
            columnBButton2.Text = randomCallNumOrder.ElementAt(1).ToString();
            columnBButton3.Text = randomCallNumOrder.ElementAt(2).ToString();
            columnBButton4.Text = randomCallNumOrder.ElementAt(3).ToString();
            columnBButton5.Text = randomCallNumOrder.ElementAt(4).ToString();
            columnBButton6.Text = randomCallNumOrder.ElementAt(5).ToString();
            columnBButton7.Text = randomCallNumOrder.ElementAt(6).ToString();

            //reenables buttons
            columnBButton1.Enabled = true;
            columnBButton2.Enabled = true;
            columnBButton3.Enabled = true;
            columnBButton4.Enabled = true;
            columnBButton5.Enabled = true;
            columnBButton6.Enabled = true;
            columnBButton7.Enabled = true;

        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// methos to set the correct table
        /// </summary>
        //sets the button text for the correct answer
        private void setCorrectButtonText()
        {

            List<string> tempCorrectColumnA = new List<string>(this.dictionaryCallNum.Keys);
            List<string> tempCorrectColumnB = new List<string>(this.dictionaryCallNum.Values);

            //sets button text to specific index in random call numbers list
            firstCorrectColumnAB.Text = tempCorrectColumnA.ElementAt(0).ToString();
            secondCorrectColumnAB.Text = tempCorrectColumnA.ElementAt(1).ToString();
            thirdCorrectColumnAB.Text = tempCorrectColumnA.ElementAt(2).ToString();
            fourthCorrectColumnAB.Text = tempCorrectColumnA.ElementAt(3).ToString();

            firstCorrectColumnBB.Text = tempCorrectColumnB.ElementAt(0).ToString();
            secondCorrectColumnBB.Text = tempCorrectColumnB.ElementAt(1).ToString();
            thirdCorrectColumnBB.Text = tempCorrectColumnB.ElementAt(2).ToString();
            fourthCorrectColumnBB.Text = tempCorrectColumnB.ElementAt(3).ToString();

        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// method to set the button text to hide correct answer
        /// https://www.youtube.com/watch?v=EbEm5kohPfE&t=97s&ab_channel=MooICT
        /// </summary>
        private void resetCorrectButtonText()
        {
            firstCorrectColumnAB.Text = "***";
            secondCorrectColumnAB.Text = "***";
            thirdCorrectColumnAB.Text = "***";
            fourthCorrectColumnAB.Text = "***";
            firstCorrectColumnBB.Text = "***";
            secondCorrectColumnBB.Text = "***";
            thirdCorrectColumnBB.Text = "***";
            fourthCorrectColumnBB.Text = "***";
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// method to set user input button text
        /// </summary>
        private void setUserText()
        {
            try
            {
                firstInputColumnAB.Text = userInputColumnA.ElementAt(0).ToString();
            }
            catch (Exception)
            {
<<<<<<< HEAD
                firstInputColumnAB.Text = "1";
=======
                firstInputColumnAB.Text = "???";
>>>>>>> 52ac0c188cfa70f943d1dd1d9413ca3caf5e6d50
            }

            try
            {
                secondInputColumnAB.Text = userInputColumnA.ElementAt(1).ToString();
            }
            catch (Exception)
            {
<<<<<<< HEAD
                secondInputColumnAB.Text = "2";
=======
                secondInputColumnAB.Text = "???";
>>>>>>> 52ac0c188cfa70f943d1dd1d9413ca3caf5e6d50
            }

            try
            {
                thirdInputColumnAB.Text = userInputColumnA.ElementAt(2).ToString();
            }
            catch (Exception)
            {
<<<<<<< HEAD
                thirdInputColumnAB.Text = "3";
=======
                thirdInputColumnAB.Text = "???";
>>>>>>> 52ac0c188cfa70f943d1dd1d9413ca3caf5e6d50
            }

            try
            {
                fourthInputColumnAB.Text = userInputColumnA.ElementAt(3).ToString();
            }
            catch (Exception)
            {
<<<<<<< HEAD
                fourthInputColumnAB.Text = "4";
=======
                fourthInputColumnAB.Text = "???";
>>>>>>> 52ac0c188cfa70f943d1dd1d9413ca3caf5e6d50
            }

            try
            {
                firstInputColumnBB.Text = userInputColumnB.ElementAt(0).ToString();
            }
            catch (Exception)
            {
<<<<<<< HEAD
                firstInputColumnBB.Text = "1";
=======
                firstInputColumnBB.Text = "???";
>>>>>>> 52ac0c188cfa70f943d1dd1d9413ca3caf5e6d50
            }

            try
            {
                secondInputColumnBB.Text = userInputColumnB.ElementAt(1).ToString();
            }
            catch (Exception)
            {
<<<<<<< HEAD
                secondInputColumnBB.Text = "2";
=======
                secondInputColumnBB.Text = "???";
>>>>>>> 52ac0c188cfa70f943d1dd1d9413ca3caf5e6d50
            }

            try
            {
                thirdInputColumnBB.Text = userInputColumnB.ElementAt(2).ToString();
            }
            catch (Exception)
            {
<<<<<<< HEAD
                thirdInputColumnBB.Text = "3";
=======
                thirdInputColumnBB.Text = "???";
>>>>>>> 52ac0c188cfa70f943d1dd1d9413ca3caf5e6d50
            }

            try
            {
                fourthInputColumnBB.Text = userInputColumnB.ElementAt(3).ToString();
            }
            catch (Exception)
            {
<<<<<<< HEAD
                fourthInputColumnBB.Text = "4";
=======
                fourthInputColumnBB.Text = "???";
>>>>>>> 52ac0c188cfa70f943d1dd1d9413ca3caf5e6d50
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// sets the order of User input buttons
        /// </summary>
        /// <param name="alt"></param>
        private void orderUserInput(bool alt)
        {
<<<<<<< HEAD
            try
            {
                if (alt == true)
                {
                    firstInputColumnAB.Text = userInputColumnA.ElementAt(0).ToString();
                    secondInputColumnAB.Text = userInputColumnA.ElementAt(1).ToString();
                    thirdInputColumnAB.Text = userInputColumnA.ElementAt(2).ToString();
                    fourthInputColumnAB.Text = userInputColumnA.ElementAt(3).ToString();

                    firstInputColumnBB.Text = userInputColumnB.ElementAt(0).ToString();
                    secondInputColumnBB.Text = userInputColumnB.ElementAt(1).ToString();
                    thirdInputColumnBB.Text = userInputColumnB.ElementAt(2).ToString();
                    fourthInputColumnBB.Text = userInputColumnB.ElementAt(3).ToString();
                }
                else
                {
                    firstInputColumnAB.Text = userInputColumnB.ElementAt(0).ToString();
                    secondInputColumnAB.Text = userInputColumnB.ElementAt(1).ToString();
                    thirdInputColumnAB.Text = userInputColumnB.ElementAt(2).ToString();
                    fourthInputColumnAB.Text = userInputColumnB.ElementAt(3).ToString();

                    firstInputColumnBB.Text = userInputColumnA.ElementAt(0).ToString();
                    secondInputColumnBB.Text = userInputColumnA.ElementAt(1).ToString();
                    thirdInputColumnBB.Text = userInputColumnA.ElementAt(2).ToString();
                    fourthInputColumnBB.Text = userInputColumnA.ElementAt(3).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Make sure all boxes are filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
=======
            if (alt == true)
            {
                firstInputColumnAB.Text = userInputColumnA.ElementAt(0).ToString();
                secondInputColumnAB.Text = userInputColumnA.ElementAt(1).ToString();
                thirdInputColumnAB.Text = userInputColumnA.ElementAt(2).ToString();
                fourthInputColumnAB.Text = userInputColumnA.ElementAt(3).ToString();

                firstInputColumnBB.Text = userInputColumnB.ElementAt(0).ToString();
                secondInputColumnBB.Text = userInputColumnB.ElementAt(1).ToString();
                thirdInputColumnBB.Text = userInputColumnB.ElementAt(2).ToString();
                fourthInputColumnBB.Text = userInputColumnB.ElementAt(3).ToString();
            }
            else
            {
                firstInputColumnAB.Text = userInputColumnB.ElementAt(0).ToString();
                secondInputColumnAB.Text = userInputColumnB.ElementAt(1).ToString();
                thirdInputColumnAB.Text = userInputColumnB.ElementAt(2).ToString();
                fourthInputColumnAB.Text = userInputColumnB.ElementAt(3).ToString();

                firstInputColumnBB.Text = userInputColumnA.ElementAt(0).ToString();
                secondInputColumnBB.Text = userInputColumnA.ElementAt(1).ToString();
                thirdInputColumnBB.Text = userInputColumnA.ElementAt(2).ToString();
                fourthInputColumnBB.Text = userInputColumnA.ElementAt(3).ToString();
>>>>>>> 52ac0c188cfa70f943d1dd1d9413ca3caf5e6d50
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// method to disable buttons once correct number of answers inputted
        /// </summary>
        /// <param name="userInputColumnA"></param>
        /// <param name="userInputColumnB"></param>
        private void limitUserInput(List<string> userInputColumnA, List<string> userInputColumnB)
        {
            if (userInputColumnA.Count() == 4 && userInputColumnB.Count() == 4)
            {
                columnBButton1.Enabled = false;
                columnBButton2.Enabled = false;
                columnBButton3.Enabled = false;
                columnBButton4.Enabled = false;
                columnBButton5.Enabled = false;
                columnBButton6.Enabled = false;
                columnBButton7.Enabled = false;
            }

            if (userInputColumnB.Count() == 4)
            {
                columnBButton1.Enabled = false;
                columnBButton2.Enabled = false;
                columnBButton3.Enabled = false;
                columnBButton4.Enabled = false;
                columnBButton5.Enabled = false;
                columnBButton6.Enabled = false;
                columnBButton7.Enabled = false;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void columnAButton2_Click(object sender, EventArgs e)
        {
            columnAButton1_Click((object)sender, e);
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void columnAButton3_Click(object sender, EventArgs e)
        {
            columnAButton1_Click((object)sender, e);
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void columnAButton4_Click(object sender, EventArgs e)
        {
            columnAButton1_Click((object)sender, e);
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void columnBButton1_Click(object sender, EventArgs e)
        {
            columnAButton1_Click((object)sender, e);
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void columnBButton2_Click(object sender, EventArgs e)
        {
            columnAButton1_Click((object)sender, e);
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void columnBButton3_Click(object sender, EventArgs e)
        {
            columnAButton1_Click((object)sender, e);
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void columnBButton4_Click(object sender, EventArgs e)
        {
            columnAButton1_Click((object)sender, e);
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void columnBButton5_Click(object sender, EventArgs e)
        {
            columnAButton1_Click((object)sender, e);
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void columnBButton6_Click(object sender, EventArgs e)
        {
            columnAButton1_Click((object)sender, e);
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void columnBButton7_Click(object sender, EventArgs e)
        {
            columnAButton1_Click((object)sender, e);
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void exitButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Form1 start = new Form1();
            start.ShowDialog();
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The books on the floating shelves are the options you have, the table with numbered books is where your choses will appear and the correct answer will appear in the table labeled correct answer. Click on the book of choice for it to appear in the table of books", "How to Play", MessageBoxButtons.OK);
=======
            Application.Exit();
>>>>>>> 52ac0c188cfa70f943d1dd1d9413ca3caf5e6d50
        }
    }
}
//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| END OF FILE ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||