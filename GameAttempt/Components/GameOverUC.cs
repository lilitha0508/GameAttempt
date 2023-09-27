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

namespace GameAttempt.Components
{
    public partial class GameOverUC : UserControl
    {
        private string text;
        private int count = 0;
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public GameOverUC()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// ref: https://www.youtube.com/watch?v=S5TMFHjrm_4&ab_channel=CodeEM
        /// Text Animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrGameOver_Tick(object sender, EventArgs e)
        {
            if(count < text.Length)
            {
                lblGameOver.Text = lblGameOver.Text + text.ElementAt(count);
                count++;
            }
            else
            {
                tmrGameOver.Stop();
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Text Animation Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameOverUC_Load(object sender, EventArgs e)
        {
            text = lblGameOver.Text;
            lblGameOver.Text = "";
            tmrGameOver.Start();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGOvExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGOvTryAgain_Click(object sender, EventArgs e)
        {
            GameOverScreen gameOver = new GameOverScreen();
            gameOver.Close();
            GameOptions game = new GameOptions();
            game.ShowDialog();
        }
    }
}
//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| END OF FILE ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||