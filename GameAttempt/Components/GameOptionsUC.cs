using GameAttempt.Games;
using GameAttempt.GeneralScreens;
using GameAttempt.Start;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// ref: https://www.youtube.com/watch?v=iy4JC5yA3B4&t=8s&ab_channel=RohitProgrammingZone
// Game menu that allows the user to pick a game as if it where a player.
// This uses images and a list to accturately pick and display the correct game
namespace GameAttempt.Components
{
    public partial class GameOptionsUC : UserControl
    {
        //image count
        int count = -1;
        //Game name List
        List<string> Game = new List<string>();

        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public GameOptionsUC()
        {
            InitializeComponent();
            
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbRightArrow_Click(object sender, EventArgs e)
        {
            Game.Add("Find Call Numbers");
            Game.Add("Replacing Books");
            Game.Add("Identify Areas");

            if(count < 2)
            {
                count++;
            }
            lblGameTaskGO.Text = Game[count + 1];
            pbGamePick.Image = imlstGameTaskImages.Images[count];

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Left Arrow clicked Arrow will show
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbLeftArrow_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
            }
            lblGameTaskGO.Text = Game[count + 1];
            pbGamePick.Image = imlstGameTaskImages.Images[count];
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Start button method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartGO_Click(object sender, EventArgs e)
        {
            LoadingScreen load = new LoadingScreen();
            GameOptions game = new GameOptions();

            if (count == 0)
            {
                ReplacingBooks replacingBooks = new ReplacingBooks();
                replacingBooks.ShowDialog();
            }
            else if (count == 1)
            {
                IdentifyAreas identifyAreas = new IdentifyAreas();
                identifyAreas.ShowDialog();
            }
            else if (count == 2)
            {
                FindCallNum findCallNum = new FindCallNum();
                findCallNum.ShowDialog();
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameOptionsUC_Load(object sender, EventArgs e)
        {
            StartPageUS.play.controls.play();
        }
    }
}
//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| END OF FILE ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||