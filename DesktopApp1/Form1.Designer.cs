namespace DesktopApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LMeaning = new System.Windows.Forms.Label();
            this.LWord = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LWord);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LMeaning);
            this.splitContainer1.Size = new System.Drawing.Size(556, 327);
            this.splitContainer1.SplitterDistance = 87;
            this.splitContainer1.TabIndex = 0;
            // 
            // LMeaning
            // 
            this.LMeaning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LMeaning.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMeaning.ForeColor = System.Drawing.Color.White;
            this.LMeaning.Location = new System.Drawing.Point(0, 0);
            this.LMeaning.Name = "LMeaning";
            this.LMeaning.Size = new System.Drawing.Size(556, 236);
            this.LMeaning.TabIndex = 0;
            this.LMeaning.Text = "Gaurav Atreya is the one who made this program, this displays the GRE words from " +
    "a file and update the words as per the given timer.\r\n";
            this.LMeaning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LWord
            // 
            this.LWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LWord.Font = new System.Drawing.Font("Monospac821 BT", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LWord.ForeColor = System.Drawing.Color.White;
            this.LWord.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LWord.Location = new System.Drawing.Point(0, 0);
            this.LWord.Name = "LWord";
            this.LWord.Size = new System.Drawing.Size(556, 87);
            this.LWord.TabIndex = 0;
            this.LWord.Text = "Gaurav Atreya";
            this.LWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "WordList\\list1.txt";
            this.openFileDialog1.InitialDirectory = "WordList";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 327);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label LWord;
        private System.Windows.Forms.Label LMeaning;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

