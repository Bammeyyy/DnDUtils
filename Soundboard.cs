using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDUtils
{
    public partial class Soundboard : Form
    {
        public static System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private readonly string path = ".\\sounds\\";
        private string fileCharacters;
        private string fileAmbience;
        private string fileMemes;
        public void playFile(string file)
        {
            if (file != "")
            {
                player.SoundLocation = path + file + ".wav";
                player.Play();
            }
        }
        public Soundboard()
        {
            InitializeComponent();
        }

        private void btn_PlayCharacters_Click(object sender, EventArgs e)
        {
            fileCharacters = list_Characters.Text;
            playFile(fileCharacters);
        }
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
        private void btn_PlayAmbience_Click(object sender, EventArgs e)
        {
            fileAmbience = list_Ambience.Text;
            playFile(fileAmbience);
        }
        private void btn_PlayMemes_Click(object sender, EventArgs e)
        {
            fileMemes = list_Memes.Text;
            playFile(fileAmbience);
        }
    }
}
