using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheMelody
{
    public partial class fGame : Form
    {
        public fGame()
        {
            InitializeComponent();
        }

        private void btnNextSong_Click(object sender, EventArgs e)
        {
            WMP.URL = Victorina.playList[1];
        }
    }
}
