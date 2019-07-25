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

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class Form1 : Form
    {
        public StreamReader reader;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true; // make the form always on top
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // hidden border
            this.WindowState = FormWindowState.Maximized; // maximized
            this.MinimizeBox = this.MaximizeBox = false; // not allowed to be minimized
            this.MinimumSize = this.MaximumSize = this.Size; // not allowed to be resized
            this.Opacity = 0.2;
            Hide();
            //this.TransparencyKey = 
            this.BackColor = Color.Black; // the color key to transparent, choose a color that you don't use
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // Set the form click-through
                cp.ExStyle |= 0x80000 /* WS_EX_LAYERED */ | 0x20 /* WS_EX_TRANSPARENT */;
                return cp;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.reader = new StreamReader("Couple\\Word.txt");
            this.LWord.Text = this.reader.ReadLine();
            this.reader.Close();
            this.reader = new StreamReader("Couple\\Meaning.txt");
            this.LMeaning.Text = this.reader.ReadLine();
            this.reader.Close();
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
