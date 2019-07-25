using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
namespace DesktopApp1
{
    public partial class Form2 : Form
    {
        public Thread DAthread;
        public Thread Gthread;
        public ManualResetEvent Event;
        public Form2(ref Thread Thr,ref ManualResetEvent _event)
        {
            InitializeComponent();
            this.DAthread = Thr;
            this.Event = _event;
// Thread DisplayWords = new Thread(EmbedMethod);
// DisplayWords.Start();
// Application.Run(new Form1());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //= Convert.ToDouble(numericUpDown1.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Form1.ActiveForm.Opacity = Convert.ToDouble(trackBar1.Value);
        }

        private void CB_Browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void CB_toggle_Click(object sender, EventArgs e)
        {
            if(this.CB_toggle.Text=="Pause")
            {
                this.CB_toggle.Text = "Resume";
                    this.Event.Set();
            }
            else
            {
                this.CB_toggle.Text = "Pause";
                this.Event.Reset();
            }
        }
        private void EmbedMethod()
        {
            Process run = Process.Start("Generate.exe WordList\\list1.txt 5");
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.label2.Text = openFileDialog1.FileName;
        }

        private void CB_Apply_Click(object sender, EventArgs e)
        {
            if (this.CB_Apply.Text == "Start")
            {
                this.CB_Apply.Text = "Stop";
                this.Hide();
                notifyIcon1.BalloonTipText = "Application is Running in Background";
                notifyIcon1.BalloonTipTitle = "GRE Words";
                notifyIcon1.ShowBalloonTip(1000);
                Gthread = new Thread(Generator);
                Gthread.Start();
                DAthread.Start();
            }
            else
            {
                Gthread.Abort();
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void Generator()
        {
            //add the code which does the function of generator.
        }
    }
    
}
