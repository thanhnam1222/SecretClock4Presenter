//BY CheburAF fimine@gmail.com
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BinaryClockXP
{
    public partial class BinaryClock : Form
    {

        //Colour variables used to switch patterns:
        private System.Drawing.Color colLit;
        private System.Drawing.Color colDim;
        private System.Drawing.Color colBackground;

        
        //the following 6 arrays will serve as Control Arrays:
        private System.Windows.Forms.PictureBox[] Hrs10;
        private System.Windows.Forms.PictureBox[] Hrs;
       
        private System.Windows.Forms.PictureBox[] Mns10;
        private System.Windows.Forms.PictureBox[] Mns;
        
        private System.Windows.Forms.PictureBox[] Scs10;
        private System.Windows.Forms.PictureBox[] Scs;



        public BinaryClock()
        {
            InitializeComponent();
        }

        
        private void BinaryClock_Load(object sender, EventArgs e)
        {
                        
            this.ColorPattern(this.mnuBlue.Name); //set it to the default colour pattern
            this.TransparencyKey = this.colBackground; //set the transparency


            Hrs10 = new System.Windows.Forms.PictureBox[] { hr20, hr10 }; //put 10 hours LEDs into an array;
            Hrs = new System.Windows.Forms.PictureBox[] { hr8, hr4, hr2, hr1 }; // put Single hours into an array;

            Mns10 = new System.Windows.Forms.PictureBox[] { mn40, mn20, mn10 };
            Mns = new System.Windows.Forms.PictureBox[] { mn8, mn4, mn2, mn1 };

            Scs10 = new System.Windows.Forms.PictureBox[] { sc40, sc20, sc10 };
            Scs = new System.Windows.Forms.PictureBox[] { sc8, sc4, sc2, sc1 };

            
            timBinClock_Tick(sender, e); //thick the clock manually so there is no 1 sec delay on start; 
            timBinClock.Start(); //start the clock;

            //tinh chinh cho cac chuc nang secret la mac dinh
            macdinh();
        }

        public void macdinh()
        {
            NoSecond_Enable();//bat chuc nang khong hien kim giay
            this.Left = Screen.PrimaryScreen.Bounds.Width - 70;
            this.Top = 0;

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mnuBorderless.Checked = true;
        }

        private void timBinClock_Tick(object sender, EventArgs e)
        {
            //The timBinClock timer is set to tick every 1000 miliseconds = every 1 second

            int Foo; //this one is a Dummy

            
            //CONFIGURE HOURS:
            //(Note, we're using terms 10 and Singles as follows: in 14, the 10 is 1, and Single is is 4. 
            
            int HrNow = DateTime.Now.Hour; //get current hour
            int TenHrNow = Math.DivRem(DateTime.Now.Hour, 10, out Foo) * 10; //now get the 10 hours. 
            bool[] hrs = this.DecimalToBinary(HrNow - TenHrNow, 8); // translate the Single hours into binary;
            bool[] hrs10 = this.DecimalToBinary(TenHrNow / 10, 8); //translate the 10 hours into binary;

            
            LightOnOff(hrs10, this.Hrs10); //Light/Dim 10 hours LEDs
            LightOnOff(hrs, this.Hrs); //Light/Dim Single hours LEDs


            //CONFIGURE MINUTES:
            //Same deal as with the Hours above

            int MinNow = DateTime.Now.Minute;
            int TenMinNow = Math.DivRem(DateTime.Now.Minute, 10, out Foo) * 10;
            bool[] mns = this.DecimalToBinary(MinNow - TenMinNow, 8);
            bool[] mns10 = this.DecimalToBinary(TenMinNow / 10, 8);


            LightOnOff(mns10, this.Mns10);
            LightOnOff(mns, this.Mns);

            //CONFIGURE SECONDS:
            //Look above

            int SecNow = DateTime.Now.Second;
            int TenSecNow = Math.DivRem(DateTime.Now.Second, 10, out Foo) * 10;
            bool[] scs = this.DecimalToBinary(SecNow - TenSecNow, 8);
            bool[] scs10 = this.DecimalToBinary(TenSecNow / 10, 8);



            LightOnOff(scs10, this.Scs10);
            LightOnOff(scs, this.Scs);
        }


        private bool[] DecimalToBinary(int number, int MaxBit) // Converts a decimal Number into a binary number, contained in array of integers;
        {
            
            System.Collections.ArrayList alBinaryNumber = new System.Collections.ArrayList(); //We use ArrayList here for flexibility sake; 

            while (MaxBit >= 1) //since 1 is the lowest representation in the binary, we execute while our Max is no less than 1;
            {
                if (number / MaxBit > 0)// if the MaxBit consists in the Number to be converted more than once 
                {
                    alBinaryNumber.Add(true); //if it's 1 then MaxBit is contained in the number 1 time - put 1;
                    number = number - MaxBit; // and decuct the MaxBit from the number for we have recorded Max being there;
                }
                else //if Max consists 0 times in the number:
                {
                    alBinaryNumber.Add(false); //record 0;
                }
                MaxBit = MaxBit / 2; //Divide Max to descend one step in the binary system and continue; 
                
               
            }
            
            //after we went through all the steps, return ArrayList converted from ArrayList of objects into Array of booleans:
            return (bool[])alBinaryNumber.ToArray(typeof(bool));
        }

        

        private void LightOnOff(bool[] binNumber, System.Windows.Forms.PictureBox[] Lights)
        {
            //binNumber is the binary number represented in Array of booleans;
            //Lights is an array of PictureBox controls; 

            // in the For-Loop go through the binNumber array and "turn on" the corresponding "LED" lights in the Lights array:
            for (int i = (binNumber.Length - Lights.Length); i - (binNumber.Length - Lights.Length) < Lights.Length; i++)
            {
                //since our binary number has 4 bins, while Lights aren't therefore we need to compensate for array length differences
                // therefore (binNumber.Length - Lights.Length)
                
                if (binNumber[i])//if "on"
                {
                    Lights.ElementAt(i - (binNumber.Length - Lights.Length)).BackColor = this.colLit; //turn the light ON

                }
                else 
                {
                    Lights.ElementAt(i - (binNumber.Length - Lights.Length)).BackColor = this.colDim;//turn the light OFF
                }

                Lights.ElementAt(i - (binNumber.Length - Lights.Length)).Refresh(); //It won't hurt to refresh the control since we are changing its colour;
                
            }
            
        }
        

        // **************************************************************
        // DECORATIONS BELOW:

        public void ChangeBorderStyle()
        {
            if (this.mnuBorderless.Checked)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
            else
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            }
        }

        public void NoSecond_Enable(){
                this.sc10.Visible=false ;
                this.sc20.Visible=false ;
                this.sc40.Visible = false;
                this.sc1.Visible  = false;
                this.sc2.Visible = false;
                this.sc4.Visible = false;
                this.sc8.Visible = false;
                this.Width = 105 - 35;
                mnuNoSeconds.Checked = true;
        }
        public void NoSecond_Disable()
        {
            this.sc10.Visible = true;
            this.sc20.Visible = true;
            this.sc40.Visible = true;
            this.sc1.Visible = true;
            this.sc2.Visible = true;
            this.sc4.Visible = true;
            this.sc8.Visible = true;
            this.Width = 105;
            mnuNoSeconds.Checked = false;
        }

        public void ChangeSecondStyle()
        {
            if (this.mnuNoSeconds.Checked)
            {NoSecond_Enable();
        
            }
            else
            {
                NoSecond_Disable();
                
            }
        }

        public void ColorPattern(string Name)
        {
            switch (Name)
            {
                case "mnuBlue":
                    this.colLit = System.Drawing.Color.RoyalBlue;
                    this.colDim = System.Drawing.Color.LightSteelBlue;
                    this.colBackground = System.Drawing.Color.CornflowerBlue;
                    break;
                case "mnuGreen":
                    this.colLit = System.Drawing.Color.LimeGreen;
                    this.colDim = System.Drawing.Color.PaleGreen;
                    this.colBackground = System.Drawing.Color.WhiteSmoke;
                    break;
                case "mnuSteel":
                    this.colLit = System.Drawing.Color.LightSlateGray;
                    this.colDim = System.Drawing.Color.Gainsboro;
                    this.colBackground = System.Drawing.Color.DarkGray;
                    break;

            }

            this.BackColor = this.colBackground;
            this.SetTransparent(this.mnuTransparent.Checked);
        }


        private void SetTransparent(bool Checked)
        {
            if (Checked)
            {
                this.TransparencyKey = this.colBackground;
            }
            else
            {
                this.TransparencyKey = System.Drawing.Color.Red;
           }

        }

        private void mnuBorderless_Click(object sender, EventArgs e)
        {
            ChangeBorderStyle();
        }
        
        private void transpareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTransparent(mnuTransparent.Checked);
        }
        
        private void mnuBlue_Click(object sender, EventArgs e)
        {
            this.ColorPattern(this.mnuBlue.Name );
        }

        private void mnuGreen_Click(object sender, EventArgs e)
        {
            this.ColorPattern(this.mnuGreen.Name );
        }

        private void mnuSteel_Click(object sender, EventArgs e)
        {
            this.ColorPattern(this.mnuSteel.Name );
        }

        private void xCloseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void mnuNoSeconds_Click(object sender, EventArgs e)
        {
            ChangeSecondStyle();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SecretClock4Presenter v1.0n, \nbased on Binary Clock for Window - Alexei Fimine,\n is licensed under The GNU General Public License (GPLv3)\n ThanhNamNguyen added \"No Seconds\" on menu, changed this program to a SecretClock4Presenter.");

        }

        
    }
}
