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
        Random rnd = new Random();

        public fGame()
        {
            InitializeComponent();
        }

        private void btnNextSong_Click(object sender, EventArgs e)
        {
            PlayNextSong();
        }

        private void PlayNextSong()
        {
            int n = rnd.Next(0, Victorina.playList.Count);
            WMP.URL = Victorina.playList[n];
            Victorina.playList.RemoveAt(n);
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            WMP.Ctlcontrols.stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            WMP.Ctlcontrols.pause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            WMP.Ctlcontrols.play();
        }
    }
}
