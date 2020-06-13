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
    public partial class fMessage : Form
    {
        int answerTime = Victorina.answerTime;
        public fMessage()
        {
            InitializeComponent();
        }

        private void fMessage_Load(object sender, EventArgs e)
        {
            lblAnswerTime.Text = Victorina.answerTime.ToString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            answerTime--;
            lblAnswerTime.Text = answerTime.ToString();
            if(answerTime == 0)
            {
                timer1.Stop();
                SoundPlayer sp = new SoundPlayer("");
                sp.Play();
            }
        }

        private void fMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
