namespace BinaryClockXP
{
    partial class SecretClock4Presenter
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
            this.timBinClock = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuBorderless = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNoSeconds = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTransparent = new System.Windows.Forms.ToolStripMenuItem();
            this.colorPatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSteel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xCloseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sc8 = new System.Windows.Forms.PictureBox();
            this.mn8 = new System.Windows.Forms.PictureBox();
            this.sc4 = new System.Windows.Forms.PictureBox();
            this.sc40 = new System.Windows.Forms.PictureBox();
            this.mn4 = new System.Windows.Forms.PictureBox();
            this.mn40 = new System.Windows.Forms.PictureBox();
            this.sc2 = new System.Windows.Forms.PictureBox();
            this.sc20 = new System.Windows.Forms.PictureBox();
            this.mn2 = new System.Windows.Forms.PictureBox();
            this.sc1 = new System.Windows.Forms.PictureBox();
            this.hr8 = new System.Windows.Forms.PictureBox();
            this.sc10 = new System.Windows.Forms.PictureBox();
            this.mn20 = new System.Windows.Forms.PictureBox();
            this.mn1 = new System.Windows.Forms.PictureBox();
            this.hr4 = new System.Windows.Forms.PictureBox();
            this.mn10 = new System.Windows.Forms.PictureBox();
            this.hr2 = new System.Windows.Forms.PictureBox();
            this.hr1 = new System.Windows.Forms.PictureBox();
            this.hr20 = new System.Windows.Forms.PictureBox();
            this.hr10 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mn8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mn40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mn20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mn10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr10)).BeginInit();
            this.SuspendLayout();
            // 
            // timBinClock
            // 
            this.timBinClock.Interval = 1000;
            this.timBinClock.Tick += new System.EventHandler(this.timBinClock_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBorderless,
            this.mnuNoSeconds,
            this.toolStripSeparator1,
            this.mnuTransparent,
            this.colorPatternToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem,
            this.xCloseToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 148);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // mnuBorderless
            // 
            this.mnuBorderless.CheckOnClick = true;
            this.mnuBorderless.Name = "mnuBorderless";
            this.mnuBorderless.Size = new System.Drawing.Size(144, 22);
            this.mnuBorderless.Text = "&Borderless";
            this.mnuBorderless.Click += new System.EventHandler(this.mnuBorderless_Click);
            // 
            // mnuNoSeconds
            // 
            this.mnuNoSeconds.CheckOnClick = true;
            this.mnuNoSeconds.Name = "mnuNoSeconds";
            this.mnuNoSeconds.Size = new System.Drawing.Size(144, 22);
            this.mnuNoSeconds.Text = "&No seconds";
            this.mnuNoSeconds.Click += new System.EventHandler(this.mnuNoSeconds_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // mnuTransparent
            // 
            this.mnuTransparent.Checked = true;
            this.mnuTransparent.CheckOnClick = true;
            this.mnuTransparent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuTransparent.Name = "mnuTransparent";
            this.mnuTransparent.Size = new System.Drawing.Size(144, 22);
            this.mnuTransparent.Text = "&Transparent";
            this.mnuTransparent.Click += new System.EventHandler(this.transpareToolStripMenuItem_Click);
            // 
            // colorPatternToolStripMenuItem
            // 
            this.colorPatternToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBlue,
            this.mnuGreen,
            this.mnuSteel});
            this.colorPatternToolStripMenuItem.Name = "colorPatternToolStripMenuItem";
            this.colorPatternToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.colorPatternToolStripMenuItem.Text = "&Color pattern";
            // 
            // mnuBlue
            // 
            this.mnuBlue.Name = "mnuBlue";
            this.mnuBlue.Size = new System.Drawing.Size(105, 22);
            this.mnuBlue.Text = "&Blue";
            this.mnuBlue.Click += new System.EventHandler(this.mnuBlue_Click);
            // 
            // mnuGreen
            // 
            this.mnuGreen.Name = "mnuGreen";
            this.mnuGreen.Size = new System.Drawing.Size(105, 22);
            this.mnuGreen.Text = "&Green";
            this.mnuGreen.Click += new System.EventHandler(this.mnuGreen_Click);
            // 
            // mnuSteel
            // 
            this.mnuSteel.Name = "mnuSteel";
            this.mnuSteel.Size = new System.Drawing.Size(105, 22);
            this.mnuSteel.Text = "&Steel";
            this.mnuSteel.Click += new System.EventHandler(this.mnuSteel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(141, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // xCloseToolStripMenuItem1
            // 
            this.xCloseToolStripMenuItem1.Name = "xCloseToolStripMenuItem1";
            this.xCloseToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.xCloseToolStripMenuItem1.Text = "&Exit";
            this.xCloseToolStripMenuItem1.Click += new System.EventHandler(this.xCloseToolStripMenuItem1_Click);
            // 
            // sc8
            // 
            this.sc8.BackColor = System.Drawing.Color.RoyalBlue;
            this.sc8.Location = new System.Drawing.Point(84, 7);
            this.sc8.Name = "sc8";
            this.sc8.Size = new System.Drawing.Size(10, 10);
            this.sc8.TabIndex = 15;
            this.sc8.TabStop = false;
            // 
            // mn8
            // 
            this.mn8.BackColor = System.Drawing.Color.RoyalBlue;
            this.mn8.Location = new System.Drawing.Point(52, 7);
            this.mn8.Name = "mn8";
            this.mn8.Size = new System.Drawing.Size(10, 10);
            this.mn8.TabIndex = 16;
            this.mn8.TabStop = false;
            // 
            // sc4
            // 
            this.sc4.BackColor = System.Drawing.Color.RoyalBlue;
            this.sc4.Location = new System.Drawing.Point(84, 23);
            this.sc4.Name = "sc4";
            this.sc4.Size = new System.Drawing.Size(10, 10);
            this.sc4.TabIndex = 14;
            this.sc4.TabStop = false;
            // 
            // sc40
            // 
            this.sc40.BackColor = System.Drawing.Color.RoyalBlue;
            this.sc40.Location = new System.Drawing.Point(68, 23);
            this.sc40.Name = "sc40";
            this.sc40.Size = new System.Drawing.Size(10, 10);
            this.sc40.TabIndex = 12;
            this.sc40.TabStop = false;
            // 
            // mn4
            // 
            this.mn4.BackColor = System.Drawing.Color.RoyalBlue;
            this.mn4.Location = new System.Drawing.Point(52, 23);
            this.mn4.Name = "mn4";
            this.mn4.Size = new System.Drawing.Size(10, 10);
            this.mn4.TabIndex = 13;
            this.mn4.TabStop = false;
            // 
            // mn40
            // 
            this.mn40.BackColor = System.Drawing.Color.RoyalBlue;
            this.mn40.Location = new System.Drawing.Point(36, 23);
            this.mn40.Name = "mn40";
            this.mn40.Size = new System.Drawing.Size(10, 10);
            this.mn40.TabIndex = 20;
            this.mn40.TabStop = false;
            // 
            // sc2
            // 
            this.sc2.BackColor = System.Drawing.Color.RoyalBlue;
            this.sc2.Location = new System.Drawing.Point(84, 39);
            this.sc2.Name = "sc2";
            this.sc2.Size = new System.Drawing.Size(10, 10);
            this.sc2.TabIndex = 21;
            this.sc2.TabStop = false;
            // 
            // sc20
            // 
            this.sc20.BackColor = System.Drawing.Color.RoyalBlue;
            this.sc20.Location = new System.Drawing.Point(68, 39);
            this.sc20.Name = "sc20";
            this.sc20.Size = new System.Drawing.Size(10, 10);
            this.sc20.TabIndex = 19;
            this.sc20.TabStop = false;
            // 
            // mn2
            // 
            this.mn2.BackColor = System.Drawing.Color.RoyalBlue;
            this.mn2.Location = new System.Drawing.Point(52, 39);
            this.mn2.Name = "mn2";
            this.mn2.Size = new System.Drawing.Size(10, 10);
            this.mn2.TabIndex = 17;
            this.mn2.TabStop = false;
            // 
            // sc1
            // 
            this.sc1.BackColor = System.Drawing.Color.RoyalBlue;
            this.sc1.Location = new System.Drawing.Point(84, 55);
            this.sc1.Name = "sc1";
            this.sc1.Size = new System.Drawing.Size(10, 10);
            this.sc1.TabIndex = 18;
            this.sc1.TabStop = false;
            // 
            // hr8
            // 
            this.hr8.BackColor = System.Drawing.Color.RoyalBlue;
            this.hr8.Location = new System.Drawing.Point(20, 7);
            this.hr8.Name = "hr8";
            this.hr8.Size = new System.Drawing.Size(10, 10);
            this.hr8.TabIndex = 5;
            this.hr8.TabStop = false;
            // 
            // sc10
            // 
            this.sc10.BackColor = System.Drawing.Color.RoyalBlue;
            this.sc10.Location = new System.Drawing.Point(68, 55);
            this.sc10.Name = "sc10";
            this.sc10.Size = new System.Drawing.Size(10, 10);
            this.sc10.TabIndex = 6;
            this.sc10.TabStop = false;
            // 
            // mn20
            // 
            this.mn20.BackColor = System.Drawing.Color.RoyalBlue;
            this.mn20.Location = new System.Drawing.Point(36, 39);
            this.mn20.Name = "mn20";
            this.mn20.Size = new System.Drawing.Size(10, 10);
            this.mn20.TabIndex = 4;
            this.mn20.TabStop = false;
            // 
            // mn1
            // 
            this.mn1.BackColor = System.Drawing.Color.RoyalBlue;
            this.mn1.Location = new System.Drawing.Point(52, 55);
            this.mn1.Name = "mn1";
            this.mn1.Size = new System.Drawing.Size(10, 10);
            this.mn1.TabIndex = 2;
            this.mn1.TabStop = false;
            // 
            // hr4
            // 
            this.hr4.BackColor = System.Drawing.Color.RoyalBlue;
            this.hr4.Location = new System.Drawing.Point(20, 23);
            this.hr4.Name = "hr4";
            this.hr4.Size = new System.Drawing.Size(10, 10);
            this.hr4.TabIndex = 3;
            this.hr4.TabStop = false;
            // 
            // mn10
            // 
            this.mn10.BackColor = System.Drawing.Color.RoyalBlue;
            this.mn10.Location = new System.Drawing.Point(36, 55);
            this.mn10.Name = "mn10";
            this.mn10.Size = new System.Drawing.Size(10, 10);
            this.mn10.TabIndex = 10;
            this.mn10.TabStop = false;
            // 
            // hr2
            // 
            this.hr2.BackColor = System.Drawing.Color.RoyalBlue;
            this.hr2.Location = new System.Drawing.Point(20, 39);
            this.hr2.Name = "hr2";
            this.hr2.Size = new System.Drawing.Size(10, 10);
            this.hr2.TabIndex = 11;
            this.hr2.TabStop = false;
            // 
            // hr1
            // 
            this.hr1.BackColor = System.Drawing.Color.RoyalBlue;
            this.hr1.Location = new System.Drawing.Point(20, 55);
            this.hr1.Name = "hr1";
            this.hr1.Size = new System.Drawing.Size(10, 10);
            this.hr1.TabIndex = 9;
            this.hr1.TabStop = false;
            // 
            // hr20
            // 
            this.hr20.BackColor = System.Drawing.Color.RoyalBlue;
            this.hr20.Location = new System.Drawing.Point(4, 39);
            this.hr20.Name = "hr20";
            this.hr20.Size = new System.Drawing.Size(10, 10);
            this.hr20.TabIndex = 7;
            this.hr20.TabStop = false;
            // 
            // hr10
            // 
            this.hr10.BackColor = System.Drawing.Color.RoyalBlue;
            this.hr10.Location = new System.Drawing.Point(4, 55);
            this.hr10.Name = "hr10";
            this.hr10.Size = new System.Drawing.Size(10, 10);
            this.hr10.TabIndex = 8;
            this.hr10.TabStop = false;
            // 
            // BinaryClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(99, 73);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.sc8);
            this.Controls.Add(this.mn8);
            this.Controls.Add(this.sc4);
            this.Controls.Add(this.sc40);
            this.Controls.Add(this.mn4);
            this.Controls.Add(this.mn40);
            this.Controls.Add(this.sc2);
            this.Controls.Add(this.sc20);
            this.Controls.Add(this.mn2);
            this.Controls.Add(this.sc1);
            this.Controls.Add(this.hr8);
            this.Controls.Add(this.sc10);
            this.Controls.Add(this.mn20);
            this.Controls.Add(this.mn1);
            this.Controls.Add(this.hr4);
            this.Controls.Add(this.mn10);
            this.Controls.Add(this.hr2);
            this.Controls.Add(this.hr1);
            this.Controls.Add(this.hr20);
            this.Controls.Add(this.hr10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BinaryClock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SecretClock";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.BinaryClock_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mn8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mn40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mn20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mn10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timBinClock;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBorderless;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuTransparent;
        private System.Windows.Forms.ToolStripMenuItem colorPatternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBlue;
        private System.Windows.Forms.ToolStripMenuItem mnuGreen;
        private System.Windows.Forms.ToolStripMenuItem mnuSteel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuNoSeconds;
        private System.Windows.Forms.ToolStripMenuItem xCloseToolStripMenuItem1;
        private System.Windows.Forms.PictureBox sc8;
        private System.Windows.Forms.PictureBox mn8;
        private System.Windows.Forms.PictureBox sc4;
        private System.Windows.Forms.PictureBox sc40;
        private System.Windows.Forms.PictureBox mn4;
        private System.Windows.Forms.PictureBox mn40;
        private System.Windows.Forms.PictureBox sc2;
        private System.Windows.Forms.PictureBox sc20;
        private System.Windows.Forms.PictureBox mn2;
        private System.Windows.Forms.PictureBox sc1;
        private System.Windows.Forms.PictureBox hr8;
        private System.Windows.Forms.PictureBox sc10;
        private System.Windows.Forms.PictureBox mn20;
        private System.Windows.Forms.PictureBox mn1;
        private System.Windows.Forms.PictureBox hr4;
        private System.Windows.Forms.PictureBox mn10;
        private System.Windows.Forms.PictureBox hr2;
        private System.Windows.Forms.PictureBox hr1;
        private System.Windows.Forms.PictureBox hr20;
        private System.Windows.Forms.PictureBox hr10;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

    }
}