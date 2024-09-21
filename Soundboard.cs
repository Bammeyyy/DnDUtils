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
        private string fileType;
        private string fileCharacters;
        private string fileAmbience;
        private string fileMemes;

        public Soundboard()
        {
            InitializeComponent();
            loadCharacters();
            loadAmbience();
            loadMemes();
        }
        
        public void playFile(string file)
        {
            if (file != "")
            {
                player.SoundLocation = path + fileType + file + ".wav";
                player.Play();
            }
        }

        private void loadCharacters()
        {
            string[] files = Directory.GetFiles(@".\\sounds\\characters\\");
            foreach (string file in files)
            {
                list_Characters.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }
        
        private void loadAmbience()
        {
            string[] files = Directory.GetFiles(@".\\sounds\\ambience\\");
            foreach (string file in files)
            {
                list_Ambience.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }
        
        private void loadMemes()
        {
            string[] files = Directory.GetFiles(@".\\sounds\\memes\\");
            foreach (string file in files)
            {
                list_Memes.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        private void btn_PlayCharacters_Click(object sender, EventArgs e)
        {
            fileCharacters = list_Characters.Text;
            fileType = "characters\\";
            playFile(fileCharacters);
        }
        
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
        
        private void btn_PlayAmbience_Click(object sender, EventArgs e)
        {
            fileAmbience = list_Ambience.Text;
            fileType = "ambience\\";
            playFile(fileAmbience);
        }
        
        private void btn_PlayMemes_Click(object sender, EventArgs e)
        {
            fileMemes = list_Memes.Text;
            fileType = "memes\\";
            playFile(fileAmbience);
        }
    }
}
