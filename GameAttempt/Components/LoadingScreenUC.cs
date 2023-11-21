using GameAttempt.Games;
using GameAttempt.GeneralScreens;
using GameAttempt.Start;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameAttempt.Components
{
    public partial class LoadingScreenUC : UserControl
    {   
        public string choice = string.Empty;

       // GameOptions gameOptions;

        /// <summary>
        /// Video Screen
        /// </summary>
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        public LoadingScreenUC()
        {
            InitializeComponent();
            wmpLoading.uiMode = "none";
            //string path = "C:\\Users\\Lilitha-Marubelela\\Downloads\\flying_books_in_library_motion_graphics_h264_76073.mp4";
            wmpLoading.URL = "loadingScreen.mp4";
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Starts the video when the screen loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadingScreenUC_Load(object sender, EventArgs e)
        {
            wmpLoading.Ctlcontrols.play();
            timrLoadingBar.Start();
            
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Publisher: Procode
        /// Date: 3 March 2021
        /// URL: https://www.youtube.com/watch?v=Yx1ZVHKWB78&ab_channel=Procode
        /// Timer method that loads the progress bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timrLoadingBar_Tick(object sender, EventArgs e)
        {           

            if(pbLoading.Value < 100)
            {
                pbLoading.Value += 1;
                lblLoadingPertge.Text = pbLoading.Value.ToString() + " %"; 
            }
            else
            {
                timrLoadingBar.Stop();
                //open game below
                //replacingBooks.Show();

            }

            while(pbLoading.Value == 100)
            {
                timrLoadingBar.Stop();
                
                GameOptions game = new GameOptions();
                game.ShowDialog();

                this.Hide();   
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
<<<<<<< HEAD
            StartPageUS.play.settings.setMode("loop", true);
=======
>>>>>>> 52ac0c188cfa70f943d1dd1d9413ca3caf5e6d50
            StartPageUS.play.controls.play();
        }
    }
}
//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| END OF FILE ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||