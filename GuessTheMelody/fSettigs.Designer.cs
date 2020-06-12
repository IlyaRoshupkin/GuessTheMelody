namespace GuessTheMelody
{
    partial class fSettigs
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
            this.lbMusicList = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCansel = new System.Windows.Forms.Button();
            this.cbAllDir = new System.Windows.Forms.CheckBox();
            this.gbParams = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRandomStart = new System.Windows.Forms.CheckBox();
            this.cbMusicDuration = new System.Windows.Forms.ComboBox();
            this.cbGameDuration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMusicList
            // 
            this.lbMusicList.FormattingEnabled = true;
            this.lbMusicList.ItemHeight = 16;
            this.lbMusicList.Location = new System.Drawing.Point(0, 0);
            this.lbMusicList.Name = "lbMusicList";
            this.lbMusicList.Size = new System.Drawing.Size(799, 260);
            this.lbMusicList.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.Location = new System.Drawing.Point(34, 270);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 40);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearList.Location = new System.Drawing.Point(197, 270);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(100, 40);
            this.btnClearList.TabIndex = 2;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(520, 487);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(113, 40);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCansel
            // 
            this.btnCansel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCansel.Location = new System.Drawing.Point(664, 487);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(113, 40);
            this.btnCansel.TabIndex = 4;
            this.btnCansel.Text = "Cansel";
            this.btnCansel.UseVisualStyleBackColor = true;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // cbAllDir
            // 
            this.cbAllDir.AutoSize = true;
            this.cbAllDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAllDir.Location = new System.Drawing.Point(520, 275);
            this.cbAllDir.Name = "cbAllDir";
            this.cbAllDir.Size = new System.Drawing.Size(200, 33);
            this.cbAllDir.TabIndex = 5;
            this.cbAllDir.Text = "All Directories";
            this.cbAllDir.UseVisualStyleBackColor = true;
            // 
            // gbParams
            // 
            this.gbParams.Controls.Add(this.comboBox1);
            this.gbParams.Controls.Add(this.comboBox2);
            this.gbParams.Controls.Add(this.label3);
            this.gbParams.Controls.Add(this.label4);
            this.gbParams.Controls.Add(this.cbRandomStart);
            this.gbParams.Controls.Add(this.cbMusicDuration);
            this.gbParams.Controls.Add(this.cbGameDuration);
            this.gbParams.Controls.Add(this.label2);
            this.gbParams.Controls.Add(this.label1);
            this.gbParams.Location = new System.Drawing.Point(0, 316);
            this.gbParams.Name = "gbParams";
            this.gbParams.Size = new System.Drawing.Size(508, 218);
            this.gbParams.TabIndex = 6;
            this.gbParams.TabStop = false;
            this.gbParams.Text = "Parameters";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(314, 65);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(59, 24);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.Text = "F";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Player 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Player 2";
            // 
            // cbRandomStart
            // 
            this.cbRandomStart.AutoSize = true;
            this.cbRandomStart.Checked = true;
            this.cbRandomStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRandomStart.Location = new System.Drawing.Point(15, 120);
            this.cbRandomStart.Name = "cbRandomStart";
            this.cbRandomStart.Size = new System.Drawing.Size(154, 21);
            this.cbRandomStart.TabIndex = 4;
            this.cbRandomStart.Text = "Random Start Song";
            this.cbRandomStart.UseVisualStyleBackColor = true;
            // 
            // cbMusicDuration
            // 
            this.cbMusicDuration.FormattingEnabled = true;
            this.cbMusicDuration.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cbMusicDuration.Location = new System.Drawing.Point(150, 69);
            this.cbMusicDuration.Name = "cbMusicDuration";
            this.cbMusicDuration.Size = new System.Drawing.Size(57, 24);
            this.cbMusicDuration.TabIndex = 3;
            this.cbMusicDuration.Text = "10";
            // 
            // cbGameDuration
            // 
            this.cbGameDuration.FormattingEnabled = true;
            this.cbGameDuration.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cbGameDuration.Location = new System.Drawing.Point(150, 30);
            this.cbGameDuration.Name = "cbGameDuration";
            this.cbGameDuration.Size = new System.Drawing.Size(57, 24);
            this.cbGameDuration.TabIndex = 2;
            this.cbGameDuration.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Music Duration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Duration";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(314, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(59, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "A";
            // 
            // fSettigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.gbParams);
            this.Controls.Add(this.cbAllDir);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbMusicList);
            this.Name = "fSettigs";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.fSettigs_Load);
            this.gbParams.ResumeLayout(false);
            this.gbParams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMusicList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.CheckBox cbAllDir;
        private System.Windows.Forms.GroupBox gbParams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbRandomStart;
        private System.Windows.Forms.ComboBox cbMusicDuration;
        private System.Windows.Forms.ComboBox cbGameDuration;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}