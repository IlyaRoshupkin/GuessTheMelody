using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GuessTheMelody
{
    public partial class fGame : Form
    {
        Random rnd = new Random();
        int musicDuration;
        bool[] playersSteps = new bool[2];

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
            if (Victorina.playList.Count == 0) EndGame();
            else
            {
                musicDuration = Victorina.musicDuration;
                int n = rnd.Next(0, Victorina.playList.Count);
                WMP.URL = Victorina.playList[n];
                Victorina.playList.RemoveAt(n);
                lblCount.Text = Victorina.playList.Count.ToString();
                timer1.Start();
                lblMusicDuration.Text = musicDuration.ToString();
                Victorina.answer = System.IO.Path.GetFullPath(WMP.URL);
                playersSteps[0] = false;
                playersSteps[1] = false;
            }
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            GamePause();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void GamePause()
        {
            WMP.Ctlcontrols.pause();
            timer1.Stop();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            GamePlay();
        }

        private void GamePlay()
        {
            WMP.Ctlcontrols.play();
            timer1.Start();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lblCount.Text = Victorina.playList.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Victorina.gameDuration;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value == progressBar1.Maximum)
            {
                EndGame();
                return;
            }
            if (musicDuration == 0) PlayNextSong();
            progressBar1.Value++;
            musicDuration--;
            lblMusicDuration.Text = musicDuration.ToString();
        }

        private void EndGame()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (!timer1.Enabled) return;
            if (e.KeyData.ToString() == Victorina.player1Key && !playersSteps[0])
            {
                //SoundPlayer sp = new SoundPlayer("Resources\\1.wav");
                //sp.PlaySync();
                GamePause();
                fMessage fm = new fMessage();
                fm.lblPlayer.Text = "Player 1";
                playersSteps[0] = true;
                if (fm.ShowDialog()== DialogResult.Yes)
                {   
                    lblPlayer1Points.Text = Convert.ToString(Convert.ToInt32(lblPlayer1Points.Text) + 1);
                    PlayNextSong();
                }
                GamePlay();
            }
            if (e.KeyData.ToString() == Victorina.player2Key.ToString() && !playersSteps[1])
            {
                //SoundPlayer sp = new SoundPlayer("Resources\\2.wav");
                //sp.PlaySync();
                GamePause();
                fMessage fm = new fMessage();
                fm.lblPlayer.Text = "Player 2";         
                playersSteps[1] = true;

                if (fm.ShowDialog() == DialogResult.Yes)
                {
                    lblPlayer2Points.Text = Convert.ToString(Convert.ToInt32(lblPlayer2Points.Text) + 1);
                    PlayNextSong();
                }
                GamePlay();
            }
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.randomStart)
                if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    WMP.Ctlcontrols.currentPosition = rnd.Next(0, (int)WMP.currentMedia.duration / 2);
        }

        private void lblPlayer1Points_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) + 1);
            if (e.Button == MouseButtons.Right) (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) - 1);
        }
    }
}
