using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Sound_FX_Player
{
    public partial class Form1 : Form
    {
        public string SoundLocation { get; set; }

        private System.Windows.Forms.TextBox filepathTextbox;

        private System.Windows.Forms.Button selectFileButton;

        private System.Windows.Forms.Button stopButton;

        private SoundPlayer player;

        SoundPlayer _soundPlayer = new SoundPlayer();
        SoundPlayer _soundPlayer2 = new SoundPlayer();
        SoundPlayer _soundPlayer3 = new SoundPlayer();
        SoundPlayer _soundPlayer4 = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // start the sound
            _soundPlayer.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // stop the sound
            _soundPlayer.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // open file... button
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "WAV files (*.wav)|*.wav";
            openFileDialog1.DefaultExt = ".wav";

            // 11.10.23 yritys ratkoa filepathTextbox = null - erroria
            filepathTextbox = new System.Windows.Forms.TextBox();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path from the dialog
                this.filepathTextbox.Text = openFileDialog1.FileName;

                //Assign the selected file's path to the SoundPlayer object
                _soundPlayer.SoundLocation = filepathTextbox.Text;
            }
        }

        //  The 2nd SoundPlayer:----------------------------------------------------



        private void button4_Click(object sender, EventArgs e)
        {
            // open file... button
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "WAV files (*.wav)|*.wav";
            openFileDialog2.DefaultExt = ".wav";

            // 11.10.23 yritys ratkoa filepathTextbox = null - erroria
            filepathTextbox = new System.Windows.Forms.TextBox();

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path from the dialog
                this.filepathTextbox.Text = openFileDialog2.FileName;

                //Assign the selected file's path to the SoundPlayer object
                _soundPlayer2.SoundLocation = filepathTextbox.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // start the sound
            _soundPlayer2.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // stop the sound
            _soundPlayer2.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //  3rd SoundPlayer --------------------------------------------------
        private void button7_Click(object sender, EventArgs e)
        {
            // open file... button
            OpenFileDialog openFileDialog3 = new OpenFileDialog();
            openFileDialog3.Filter = "WAV files (*.wav)|*.wav";
            openFileDialog3.DefaultExt = ".wav";

            // 11.10.23 yritys ratkoa filepathTextbox = null - erroria
            filepathTextbox = new System.Windows.Forms.TextBox();

            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path from the dialog
                this.filepathTextbox.Text = openFileDialog3.FileName;

                //Assign the selected file's path to the SoundPlayer object
                _soundPlayer3.SoundLocation = filepathTextbox.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _soundPlayer3.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _soundPlayer3.Stop();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //  4th _soundPlayer ------------------------------------------------
        private void button10_Click(object sender, EventArgs e)
        {
            // open file... button
            OpenFileDialog openFileDialog4 = new OpenFileDialog();
            openFileDialog4.Filter = "WAV files (*.wav)|*.wav";
            openFileDialog4.DefaultExt = ".wav";

            // 11.10.23 yritys ratkoa filepathTextbox = null - erroria
            filepathTextbox = new System.Windows.Forms.TextBox();

            if (openFileDialog4.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path from the dialog
                this.filepathTextbox.Text = openFileDialog4.FileName;

                //Assign the selected file's path to the SoundPlayer object
                _soundPlayer4.SoundLocation = filepathTextbox.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            _soundPlayer4.Play();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _soundPlayer4.Stop();
        }
    }
}