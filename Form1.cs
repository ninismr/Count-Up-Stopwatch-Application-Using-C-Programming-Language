using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Simple_StopWatch
{
    public partial class Form1 : Form
    {
        private Stopwatch stopWatch;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.label1.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);
        }

        // references : https://youtu.be/O0kkq9-FWn4 
    }
}
