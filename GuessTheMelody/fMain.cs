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
    public partial class fMain : Form
    {
        fGame fGame = new fGame();
        fSettigs fSettigs = new fSettigs();
        
        public fMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            fSettigs.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            fGame.ShowDialog();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            Victorina.ReadParam();
            Victorina.ReadMusic();
        }
    }
}
