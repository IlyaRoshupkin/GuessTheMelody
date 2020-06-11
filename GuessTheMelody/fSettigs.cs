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
                lbMusicList.Items.Clear();
                lbMusicList.Items.AddRange(music_list);
                Victorina.playList.Clear();
                Victorina.playList.AddRange(music_list);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Victorina.WriteParam();
            this.Hide();
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
