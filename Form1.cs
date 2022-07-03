using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Pllayer_on_a_time
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Now.ToString());           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.player.URL = "CRAB.mp3";
            this.player.controls.play();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.ToString() == this.textBox2.Text)
            {
                /// de exemplu 02.02.2020 20:19:40
                this.player.URL = "CRAB.mp3";
                this.player.controls.play();
            }
            this.textBox1.Text = DateTime.Now.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
