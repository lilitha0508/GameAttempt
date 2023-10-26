using GameAttempt.Start;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using GameAttempt.Classes;
using GameAttempt.GeneralScreens;

namespace GameAttempt.Components
{
    public partial class StartPageUS : UserControl
    {

        //object to play music
        public static WindowsMediaPlayer play = new WindowsMediaPlayer(); 

        /// <summary>
        /// 
        /// </summary>
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        public StartPageUS()
        {
            InitializeComponent();

            //intialzizing address for the player to find the music in file with a URL
            play.URL = "GameThemeSong.mp3";
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStrt_Click(object sender, EventArgs e)
        {
            play.controls.pause(); 

            StoryLine story = new StoryLine();
            story.Show();
            this.Hide();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpt_Click(object sender, EventArgs e)
        {
            StartOptions options = new StartOptions();
            options.Show();
            this.Hide();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartPageUS_Load(object sender, EventArgs e)
        {
            //Loop song
            play.settings.setMode("loop", true);
            play.controls.play();
        }
    }
}
//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| END OF FILE ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||