using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// Chris
// 11/02/2021
// AT2.1 - Audio Player
namespace AudioPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LinkedList<string> mySongs = new LinkedList<string>();
        string song = "";

        // Method to show the LinkedList in the listbox
        private void showListOfSongs()
        {
            listOfSongs.Items.Clear();
            foreach (var songTitle in mySongs)
            {
                string songName = Path.GetFileName(songTitle);
                listOfSongs.Items.Add(songName);
            }
        }
        // Method that takes the file path as input and connects it to the media player
        private void playSound(string playsound)
        {
            axWindowsMediaPlayer1.URL = playsound;
            song = playsound;
        }
        // Method to add a song to the LinkedList
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            var songTitle = string.Empty;
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    songTitle = openFileDialog1.FileName;
                    mySongs.AddLast(songTitle);
                    showListOfSongs();
                }
            }
        }
        // Method to remove a song from the LinkedList
        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            mySongs.Remove(song);
            showListOfSongs();
        }
        // Method to play the first song in the LinkedList
        private void btnStartSong_Click(object sender, EventArgs e)
        {
            string songChoice = mySongs.First();
            playSound(songChoice);
        }
        // Method to play the next song in the LinkedList
        private void btnNextSong_Click(object sender, EventArgs e)
        {
                try
                {
                    string nextChoice = mySongs.Find(song).Next.Value;
                    playSound(nextChoice);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Something went wrong");
                    return;
                }
        }
        // Method to play the last song in the LinkedList
        private void btnLastSong_Click(object sender, EventArgs e)
        {
            string songChoice = mySongs.Last();
            playSound(songChoice);
        }
        // Method to play the previous son in the LinkedList
        private void btnBackSong_Click(object sender, EventArgs e)
        {
            try
            {
                string prevChoice = mySongs.Find(song).Previous.Value;
                playSound(prevChoice);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Something went wrong");
                return;
            }
        }
    }
}
