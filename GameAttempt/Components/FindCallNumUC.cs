//Entire tree declaration from GitProject
// https://github.com/VeronicaCucamonga/DeweyDecimalClassification
// https://www.youtube.com/watch?v=EbEm5kohPfE&t=97s&ab_channel=MooICT
// https://github.com/Acearino5/Dewey_Decimal_System_Trainer/tree/main
using GameAttempt.Classes;
using GameAttempt.GeneralScreens;
using GameAttempt.Start;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace GameAttempt.Components
{
    public partial class FindCallNumUC : UserControl
    {
        //declarations
        FindingCallNum findingCallNum = new FindingCallNum();
        DispatcherTimer timer = new DispatcherTimer();
        Tree treeList;

        List<string> correctAnswer = new List<string>();
        List<string> topLevelRandom = new List<string>();
        List<string> secondLevelRandom = new List<string>();
        List<string> thirdLevelRandom = new List<string>();
        int questionLevel = 1;

        private int score = 0;

        public FindCallNumUC()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(waiting);
            timer.Interval = new TimeSpan(0, 0, 2);
            timer.Start();
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
            StartPageUS.play.controls.pause();
            Form formBackground = new Form();
            try
            {
                using (FindCallInfo info = new FindCallInfo())
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
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //set lists
            treeList = findingCallNum.loadNumbers();
            correctAnswer = findingCallNum.generateFindCallNum();
            topLevelRandom = findingCallNum.generateTopLevel(correctAnswer);
            secondLevelRandom = findingCallNum.generateSecondLevel(correctAnswer);
            thirdLevelRandom = findingCallNum.generateThirdLevel(correctAnswer);
            questionLabel.Text = correctAnswer[1].ToString();

            //method calls
            SetTopLevelButtonText();
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// methods that handle button events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region ButtonEvents
        //calls methods to check answer on button click
        private void btnCallNo1_Click(object sender, EventArgs e)
        {
            var Button = (Button)sender;
            switch (Button.Name)
            {
                case "btnCallNo1":

                    checkAnswer(btnCallNo1);
                    checkLevel2Answer(btnCallNo1);
                    checkLevel3Answer(btnCallNo1);
                    DisableAllButtons();
                    break;
                case "btnCallNo2":

                    checkAnswer(btnCallNo2);
                    checkLevel2Answer(btnCallNo2);
                    checkLevel3Answer(btnCallNo2);
                    DisableAllButtons();
                    break;
                case "btnCallNo3":

                    checkAnswer(btnCallNo3);
                    checkLevel2Answer(btnCallNo3);
                    checkLevel3Answer(btnCallNo3);
                    DisableAllButtons();
                    break;
                case "btnCallNo4":

                    checkAnswer(btnCallNo4);
                    checkLevel2Answer(btnCallNo4);
                    checkLevel3Answer(btnCallNo4);
                    DisableAllButtons();
                    break;

                default:

                    break;
            }

        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //sends user to the next level if answered correct
        private void nextLevelButtons1_Click(object sender, EventArgs e)
        {
            questionLevel = questionLevel + 1;
            nextLevelButtons1.Visible = false;

            if (questionLevel == 2)
            {
                //hides answer labels
                successLabel.Visible = false;
                levelLabel.Text = "Level 2:";

                // Enable all buttons
                EnableAllButtons();

                //resets button color
                btnCallNo1.BackColor = Color.SaddleBrown;
                btnCallNo2.BackColor = Color.DarkGoldenrod;
                btnCallNo3.BackColor = Color.Peru;
                btnCallNo4.BackColor = Color.Brown;

                //sets button text
                btnCallNo1.Text = secondLevelRandom.ElementAt(0).ToString();
                btnCallNo2.Text = secondLevelRandom.ElementAt(1).ToString();
                btnCallNo3.Text = secondLevelRandom.ElementAt(2).ToString();
                btnCallNo4.Text = secondLevelRandom.ElementAt(3).ToString();
            }

            if (questionLevel == 3)
            {
                //hides answer labels
                successLabel.Visible = false;
                levelLabel.Text = "Level 3:";

                // Enable all buttons
                EnableAllButtons();

                //resets button color
                btnCallNo1.BackColor = Color.SaddleBrown;
                btnCallNo2.BackColor = Color.DarkGoldenrod;
                btnCallNo3.BackColor = Color.Peru;
                btnCallNo4.BackColor = Color.Brown;

                //sets button text
                btnCallNo1.Text = thirdLevelRandom.ElementAt(0).ToString();
                btnCallNo2.Text = thirdLevelRandom.ElementAt(1).ToString();
                btnCallNo3.Text = thirdLevelRandom.ElementAt(2).ToString();
                btnCallNo4.Text = thirdLevelRandom.ElementAt(3).ToString();
            }


        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //resets all variables and lets user start again
        private void playAgainButton_Click(object sender, EventArgs e)
        {

            //clears lists
            correctAnswer.Clear();
            topLevelRandom.Clear();
            secondLevelRandom.Clear();
            thirdLevelRandom.Clear();

            //resets question level
            questionLevel = 1;

            //hides answer labels
            successLabel.Visible = false;
            nextLevelButtons1.Visible = false;
            playAgainButton.Visible = false;

            /// Enable all buttons
            EnableAllButtons();

            //resets button color
            btnCallNo1.BackColor = Color.SaddleBrown;
            btnCallNo2.BackColor = Color.DarkGoldenrod;
            btnCallNo3.BackColor = Color.Peru;
            btnCallNo4.BackColor = Color.Brown;

            //set lists
            treeList = findingCallNum.loadNumbers();
            correctAnswer = findingCallNum.generateFindCallNum();
            topLevelRandom = findingCallNum.generateTopLevel(correctAnswer);
            secondLevelRandom = findingCallNum.generateSecondLevel(correctAnswer);
            thirdLevelRandom = findingCallNum.generateThirdLevel(correctAnswer);
            questionLabel.Text = correctAnswer[1].ToString();

            //method calls
            SetTopLevelButtonText();
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        private void EnableAllButtons()
        {
            foreach (Button button in new[] { btnCallNo1, btnCallNo2, btnCallNo3, btnCallNo4 })
            {
                button.Enabled = true;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        private void DisableAllButtons()
        {
            foreach (Button button in new[] { btnCallNo1, btnCallNo2, btnCallNo3, btnCallNo4 })
            {
                button.Enabled = false;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        private void homeButtons_Click(object sender, EventArgs e)
        {
            GameOptions game = new GameOptions();
            game.ShowDialog();
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guess the correct call number accroding to the description given in the scroll, win three times to win the over all game.", "How to Play", MessageBoxButtons.OK);
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        private void exitButton_Click(object sender, EventArgs e)
        {
            Form1 start = new Form1();
            start.ShowDialog();
        }
        #endregion
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Points label updates
        /// </summary>
        #region Points
        private void UpdateScoreLabel()
        {
            // Update your score label with the current score
            scoreLabel.Text = $"{score}";
        }
        #endregion
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Methods to check the answers for each level
        /// </summary>
        /// <param name="buttonText"></param>
        /// <param name="level"></param>
        #region checkAnswers
        public void CheckAnswer(Button buttonText, int level)
        {
            // StringBuilder for constructing substrings
            StringBuilder sb = new StringBuilder();

            // Get correct and user input strings
            string answerTemp = correctAnswer.ElementAt(0).ToString();
            string inputTemp = buttonText.Text.ToString();

            // Build substrings based on the current level
            for (int i = 0; i < level; i++)
            {
                sb.Append(answerTemp[i]);
            }

            string answerHolder = sb.ToString();
            sb.Clear();

            for (int i = 0; i < level; i++)
            {
                sb.Append(inputTemp[i]);
            }

            string inputHolder = sb.ToString();
            sb.Clear();

            // Check if the substrings match
            if (answerHolder == inputHolder)
            {
                // Display success message and update UI
                successLabel.Visible = true;
                successLabel.Text = "Correct!";
                nextLevelButtons1.Visible = level < 3;
                playAgainButton.Visible = level == 3;
                buttonText.BackColor = Color.Green;
                score += 10;
                UpdateScoreLabel();
            }
            else
            {
                // Display failure message and update UI
                successLabel.Visible = true;
                successLabel.Text = "Incorrect!";
                nextLevelButtons1.Visible = false;
                playAgainButton.Visible = true;
                buttonText.BackColor = Color.Red;
                HighlightCorrectAnswer();
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------
        // Check answer for the first level
        public void checkAnswer(Button buttonText)
        {
            if (questionLevel == 1)
            {
                CheckAnswer(buttonText, 1);
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        // Check answer for the second level
        public void checkLevel2Answer(Button buttonText)
        {
            if (questionLevel == 2)
            {
                CheckAnswer(buttonText, 2);
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        // Check answer for the third level
        public void checkLevel3Answer(Button buttonText)
        {
            if (questionLevel == 3)
            {
                CheckAnswer(buttonText, 3);
                if(successLabel.Text == "Incorrect!")
                {
                    GameOverScreen game = new GameOverScreen();
                    game.ShowDialog();
                }
                else
                {
                    WinningScreen winning = new WinningScreen();
                    winning.ShowDialog();
                }
            }
        }
        #endregion
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Methods for buttons
        /// </summary>
        #region ButtonMethods
        // Sets button text
        public void SetTopLevelButtonText()
        {
            SetButtonLabelText(topLevelRandom);
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        // Sets the button color of the correct answer
        public void HighlightCorrectAnswer()
        {
            string answer = correctAnswer.ElementAt(0).ToString();
            StringBuilder sb = new StringBuilder();

            if (questionLevel > 0 && questionLevel <= 3)
            {
                for (int i = 0; i < answer.Length; i++)
                {
                    sb.Append(answer[i]);

                    // Use LINQ to find buttons with matching substrings
                    var matchingButtons = Controls.OfType<Button>().Where(btn => btn.Text.Length > i && btn.Text.Substring(0, i + 1) == sb.ToString());

                    foreach (Button btn in matchingButtons)
                    {
                        btn.BackColor = questionLevel == 1 ? Color.Green : Color.Red;
                    }
                }
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        private void SetButtonLabelText(List<string> buttonTexts)
        {
            btnCallNo1.Text = buttonTexts.ElementAt(0).ToString();
            btnCallNo2.Text = buttonTexts.ElementAt(1).ToString();
            btnCallNo3.Text = buttonTexts.ElementAt(2).ToString();
            btnCallNo4.Text = buttonTexts.ElementAt(3).ToString();
        }
        #endregion
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| END OF FILE ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||