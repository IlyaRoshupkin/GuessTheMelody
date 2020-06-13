namespace GuessTheMelody
{
    partial class fMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnswerTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(293, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "No";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(23, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 79);
            this.button2.TabIndex = 1;
            this.button2.Text = "Yes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Lucida Calligraphy", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(178, 135);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(174, 62);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Did the player guess the melody? ";
            // 
            // lblAnswerTime
            // 
            this.lblAnswerTime.AutoSize = true;
            this.lblAnswerTime.Font = new System.Drawing.Font("Blackadder ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerTime.Location = new System.Drawing.Point(253, 346);
            this.lblAnswerTime.Name = "lblAnswerTime";
            this.lblAnswerTime.Size = new System.Drawing.Size(45, 63);
            this.lblAnswerTime.TabIndex = 4;
            this.lblAnswerTime.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 580);
            this.Controls.Add(this.lblAnswerTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "fMessage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMessage_FormClosed);
            this.Load += new System.EventHandler(this.fMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblAnswerTime;
        private System.Windows.Forms.Timer timer1;
    }
}