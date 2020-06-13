using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;

namespace GuessTheMelody
{
    static class Victorina
    {
        static public List<string> playList = new List<string>();
        static public int gameDuration = 25;
        static public int musicDuration = 5;
        static public bool randomStart = false;
        static public string lastFolder = "";
        static public bool allDirectories = false;
        static public int answerTime = 5;

        static public void ReadMusic()
        {
            try
            {
                string[] music_files = Directory.GetFiles(lastFolder, "*.mp3", allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                playList.Clear();
                playList.AddRange(music_files);
            }
            catch
            {
                MessageBox.Show("The playlist is abcient.");
            }
        }

        static string regKeyName = "Software\\MyCompanyName\\GuessMelody";

        public static void WriteParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("GameDuration", gameDuration);
                rk.SetValue("MusicDuration", musicDuration);
                rk.SetValue("AllDirectories", allDirectories);
                rk.SetValue("RandomStart", randomStart);
                rk.SetValue("Time for answer", answerTime);
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
        public static void ReadParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                if(rk != null)
                {
                    lastFolder = (string)rk.GetValue("LastFolder");
                    gameDuration = (int)rk.GetValue("GameDuration");
                    randomStart = Convert.ToBoolean(rk.GetValue("RandomStart"));
                    musicDuration = (int)rk.GetValue("MusicDuration");
                    allDirectories = Convert.ToBoolean(rk.GetValue("AllDirectories"));
                    answerTime = (int)rk.GetValue("Time for answer");
                }
            }
            catch
            {
                if(MessageBox.Show("The settings are abcient.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    WriteParam();
                } 
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
    }
}
