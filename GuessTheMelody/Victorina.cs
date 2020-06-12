using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace GuessTheMelody
{
    static class Victorina
    {
        static public List<string> playList = new List<string>();
        static public int gameDuration = 60;
        static public int musicDuration = 0;
        static public bool randomStart = false;
        static public string lastFolder = "";
        static public bool allDirectories = false;

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
                rk.SetValue("AllDirections", allDirectories);
                rk.SetValue("RandomStart", randomStart);
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
                }
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
    }
}
