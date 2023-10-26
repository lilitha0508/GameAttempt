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
            LoadingScreen loadingScreen = new LoadingScreen();
            loadingScreen.ShowDialog();
            //this.Hide();
            //StoryLine storyLine = new StoryLine();
            //storyLine.Close();
            ((Form)this.Parent).Close();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrStoryLine_Tick(object sender, EventArgs e)
        {
            LoadingScreen loading = new LoadingScreen();
            if (wmpStoryLine.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                // Video playback has ended, open the next form
                loading.ShowDialog();
                this.Hide();
            }
        }
    }
}
//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| END OF FILE ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||