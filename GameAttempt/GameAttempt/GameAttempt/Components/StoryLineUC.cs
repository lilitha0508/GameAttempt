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
    public partial class StoryLineUC : UserControl
    {
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public StoryLineUC()
        {
            InitializeComponent();
            wmpStoryLine.uiMode = "none";
            //string path = "C:\\Users\\Lilitha-Marubelela\\source\\repos\\GameAttempt\\GameAttempt\\Resources\\GameStoryLine.mp4";
            wmpStoryLine.URL = "GameStoryLine.mp4";
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StoryLineUC_Load(object sender, EventArgs e)
        {
            wmpStoryLine.Ctlcontrols.play();

            GameOptions game = new GameOptions();
            if (wmpStoryLine.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                // Video playback has ended, open the next form
                game.Show();

            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// skip story button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSkipStory_Click(object sender, EventArgs e)
        {
            wmpStoryLine.Ctlcontrols.stop();
            GameOptions game = new GameOptions();
            game.Show();
            this.Hide();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrStoryLine_Tick(object sender, EventArgs e)
        {
            GameOptions game = new GameOptions();
            if (wmpStoryLine.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                // Video playback has ended, open the next form
                    game.Show();
                
            }
        }
    }
}
//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| END OF FILE ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||