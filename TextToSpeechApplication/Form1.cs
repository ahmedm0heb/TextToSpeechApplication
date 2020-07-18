using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;


namespace TextToSpeechApplication
{
    public partial class Form1 : Form

    {
        SpeechSynthesizer reader = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(richTextBox1.Text!="")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SpeakAsync(richTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(reader != null)
            {
                if (reader.State == SynthesizerState.Speaking)
                    reader.Pause();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(reader != null)
            {
                if (reader.State == SynthesizerState.Paused)
                    reader.Resume();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (reader != null)
                Dispose();
        }

    
    }
}
