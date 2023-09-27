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
    public partial class StartOptionsUC : UserControl
    {

        
        /// <summary>
        /// 
        /// </summary>
        public StartOptionsUC()
        {
            InitializeComponent();

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartOptionsUC_Load(object sender, EventArgs e)
        {
            
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method to control the volume of the music 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            StartPageUS.play.controls.play();
            btnSound.Image = Properties.Resources.sound_on;
            StartPageUS.play.settings.volume = tbVolume.Value;

            if(tbVolume.Value == 0)
            {
                btnSound.Image = Properties.Resources.sound_off;
            }
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
        private void btnOptStart_Click(object sender, EventArgs e)
        {
            StartOptions options = new StartOptions();
            options.Close();
            StoryLine story = new StoryLine();
            story.ShowDialog();
        }
    }
} //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| END OF FILE ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
