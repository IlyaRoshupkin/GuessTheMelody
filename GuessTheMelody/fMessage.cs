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
using Id3;

namespace GuessTheMelody
{
    public partial class fMessage : Form
    {
        int answerTime;
        public fMessage()
        {
            InitializeComponent();
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {
            var mp3 = new Mp3(Victorina.answer);
            Id3Tag tag = mp3.GetTag(Id3TagFamily.Version2X);
            lblAnswer.Text = tag.Artists + " - " + tag.Title;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            answerTime--;
            lblAnswerTime.Text = answerTime.ToString();
            if (answerTime == 0)
            {
                timer1.Stop();
                //SoundPlayer sp = new SoundPlayer("Resources\\TimeIsOut.wmv");
                //sp.Play();

            }
                
        }

        private void fMessage_Load(object sender, EventArgs e)
        {
            answerTime = Victorina.answerTime;
            lblAnswerTime.Text = answerTime.ToString();
            timer1.Start();
        }

        private void fMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
