using GameAttempt.Components;
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

namespace GameAttempt.GeneralScreens
{
    public partial class FindCallInfo : Form
    {
        public static WindowsMediaPlayer play = new WindowsMediaPlayer();

        //-----------------------------------------------------------------------------------------------------------------------
        public FindCallInfo()
        {
            InitializeComponent();

            play.URL = "witchSound.mp3";
        }
        //-----------------------------------------------------------------------------------------------------------------------
        private void IdenAdreaTitle_lbl_Click(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------------------------------------------------------
        private void InfoAreaInfo_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            play.controls.stop();
            StartPageUS.play.controls.play();
        }
        //------------------------------------------------------------------------------------------------------------------------
        private void FindCallInfo_Load(object sender, EventArgs e)
        {
            play.controls.play();
            StartPageUS.play.controls.stop();
        }
    }
}
//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| END OF FILE ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||