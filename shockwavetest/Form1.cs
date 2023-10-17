using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;

namespace shockwave_test
{
    public partial class Form1 : Form
    {
        string num;
        int i = 1;
        public Form1()
        {
            InitializeComponent();
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            string fol = Application.StartupPath;
            Directory.SetCurrentDirectory(fol);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            num = random.Next(7600).ToString();
            this.Text = num;
            //axShockwaveFlash1.Movie = "http://z0r.de/L/z0r-de_" + num + ".swf";
            //axShockwaveFlash1.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();
            num = random.Next(7600).ToString();
            this.Text = num;
            //axShockwaveFlash1.Movie = "http://z0r.de/L/z0r-de_" + num + ".swf";
            //axShockwaveFlash1.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("http://z0r.de/L/z0r-de_" + num + ".swf", "z0r-de_" + num + ".swf");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
            num = textBox1.Text;
            //axShockwaveFlash1.Movie = "http://z0r.de/L/z0r-de_" + textBox1.Text + ".swf";
            //axShockwaveFlash1.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                i = 1;
                timer1.Start();
                timer1.Interval = Convert.ToInt32(textBox2.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            num = i.ToString();
            this.Text = num;
            //axShockwaveFlash1.Movie = "http://z0r.de/L/z0r-de_" + i + ".swf";
            //axShockwaveFlash1.Play();
            if (i >= 7911)
            {
                timer1.Stop();
            }
            i = i + 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = Convert.ToInt32(textBox2.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            i = Convert.ToInt32(num);
            i = i - 1;
            num = i.ToString();
            this.Text = num;
            //axShockwaveFlash1.Movie = "http://z0r.de/L/z0r-de_" + i + ".swf";
            //axShockwaveFlash1.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            i = Convert.ToInt32(num);
            i = i + 1;
            num = i.ToString();
            this.Text = num;
            //axShockwaveFlash1.Movie = "http://z0r.de/L/z0r-de_" + i + ".swf";
            //axShockwaveFlash1.Play();
        }
    }
}
