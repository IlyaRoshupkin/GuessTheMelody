using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuessTheMelody
{
    public partial class fSettigs : Form
    {
        public fSettigs()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                string[] music_list = Directory.GetFiles(fbd.SelectedPath, "*.mp3", 
                    cbAllDir.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                Victorina.lastFolder = fbd.SelectedPath;
                lbMusicList.Items.Clear();
                lbMusicList.Items.AddRange(music_list);
                Victorina.playList.Clear();
                Victorina.playList.AddRange(music_list);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Victorina.allDirectories = cbAllDir.Checked;
            Victorina.gameDuration = Convert.ToInt32(cbGameDuration.Text);
            Victorina.musicDuration = Convert.ToInt32(cbMusicDuration.Text);
            Victorina.randomStart = cbRandomStart.Checked;
            Victorina.WriteParam();
            this.Hide();
        }

        void Set()
        {
            cbAllDir.Checked = Victorina.allDirectories;
            cbGameDuration.Text = Victorina.gameDuration.ToString();
            cbMusicDuration.Text = Victorina.musicDuration.ToString();
            cbRandomStart.Checked = Victorina.randomStart;
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            Set();
            this.Hide();
        }

        private void fSettigs_Load(object sender, EventArgs e)
        {
            lbMusicList.Items.Clear();
            lbMusicList.Items.AddRange(Victorina.playList.ToArray());
            Set();
        }
    }
}
