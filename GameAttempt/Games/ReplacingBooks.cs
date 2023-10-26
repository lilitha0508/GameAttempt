using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameAttempt.Games
{
    public partial class ReplacingBooks : Form
    {
        public ReplacingBooks()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Stops the flickering when dragging
        /// link: https://stackoverflow.com/questions/14281085/moving-overlapping-pictureboxes-at-runtime-causes-lag-in-repaint/14282467#14282467
        /// date: 2023
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}
