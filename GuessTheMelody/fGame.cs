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
            lblCount.Text = Victorina.playList.Count.ToString();
            progressBar1.Value = 0;
            timer1.Start();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            WMP.Ctlcontrols.stop();
            timer1.Stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            WMP.Ctlcontrols.pause();
            timer1.Stop();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            WMP.Ctlcontrols.play();
            timer1.Start();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lblCount.Text = Victorina.playList.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Victorina.musicDuration;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if(progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
            }
        }
    }
}
