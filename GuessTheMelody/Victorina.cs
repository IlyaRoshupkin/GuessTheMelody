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
        static public int gameDuration = 60;
        static public int musicDuration = 5;
        static public bool randomStart = false;
        static public string lastFolder = "";
        static public bool allDirectories = false;
        static public int answerTime = 5;
        static public string answer = "";
        static public string player1Key = Keys.A.ToString();
        static public string player2Key = Keys.F.ToString();

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
                MessageBox.Show("Nessesserely to load the songs.");
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
                rk.SetValue("AnswerTime", answerTime);
                rk.SetValue("Player1Key", player1Key);
                rk.SetValue("Player2Key", player2Key);
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
                    answerTime = (int)rk.GetValue("AnswerTime");
                    player1Key = rk.GetValue("Player1Key").ToString();
                    player2Key = rk.GetValue("Player2Key").ToString();
                }
            }
            catch
            {
                WriteParam();
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
    }
}
