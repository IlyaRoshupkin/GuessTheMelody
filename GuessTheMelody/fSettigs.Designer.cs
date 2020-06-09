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
            this.btnLoad.Location = new System.Drawing.Point(35, 275);
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
            this.btnClearList.Location = new System.Drawing.Point(198, 275);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(100, 40);
            this.btnClearList.TabIndex = 2;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(454, 376);
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
            this.btnCansel.Location = new System.Drawing.Point(622, 376);
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
            this.cbAllDir.Location = new System.Drawing.Point(497, 266);
            this.cbAllDir.Name = "cbAllDir";
            this.cbAllDir.Size = new System.Drawing.Size(200, 33);
            this.cbAllDir.TabIndex = 5;
            this.cbAllDir.Text = "All Directories";
            this.cbAllDir.UseVisualStyleBackColor = true;
            // 
            // fSettigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbAllDir);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbMusicList);
            this.Name = "fSettigs";
            this.Text = "Settings";
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
    }
}