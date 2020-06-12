﻿using System;
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
        int musicDuration;

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
            musicDuration = Victorina.musicDuration;
            int n = rnd.Next(0, Victorina.playList.Count);
            WMP.URL = Victorina.playList[n];
            Victorina.playList.RemoveAt(n);
            lblCount.Text = Victorina.playList.Count.ToString();
            timer1.Start();
            lblMusicDuration.Text = musicDuration.ToString();
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
            if(e.KeyData == Keys.A)
            {
                GamePause();
                if(MessageBox.Show("Is the answer right?","Player 1",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lblPlayer1Points.Text = Convert.ToString(Convert.ToInt32(lblPlayer1Points)+1);
                    return;
                }
                GamePlay();
                if (MessageBox.Show("Is the answer right?", "Player 2", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lblPlayer2Points.Text = Convert.ToString(Convert.ToInt32(lblPlayer2Points) + 1);
                    return;
                }
                GamePlay();
            }
        }
    }
}
