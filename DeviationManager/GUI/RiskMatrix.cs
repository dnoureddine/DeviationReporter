using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeviationManager.GUI
{
    public partial class RiskMatrix : Form
    {
        private TextBox riskCategory;
        private Panel panelToShake = null;
      
        public RiskMatrix(TextBox riskCategory)
        {
            InitializeComponent();
            this.riskCategory = riskCategory;

            int[] cords = this.getRiskMatrixCordination(riskCategory.Text);
            if(cords != null)
            {
                this.shakeRiskCategoryCase(cords[0], cords[1]);
            }
            
            if(this.panelToShake != null)
            {
                //change the style of the panel to shake
                this.panelToShake.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        // chose the panel to shake using cordination x and y
        private void shakeRiskCategoryCase(int x, int y)
        {
           
            if( x == 5 && y == 1)
            {
                this.panelToShake = this.panel10;
            }
            else if (x == 5 && y == 2)
            {
                this.panelToShake = this.panel9;
            }
            else if (x == 5 && y == 3)
            {
                this.panelToShake = this.panel4;
            }
            else if (x == 5 && y == 4)
            {
                this.panelToShake = this.panel6;
            }
            else if (x == 5 && y == 5)
            {
                this.panelToShake = this.panel3;
                    
            }
            else if (x == 5 && y == 6)
            {
                this.panelToShake = this.panel5;
            }
            else if (x == 5 && y == 7)
            {
                this.panelToShake = this.panel7;
            }
            else if (x == 5 && y == 8)
            {
                this.panelToShake = this.panel8;
            }
            else if (x == 5 && y == 9)
            {
                this.panelToShake = this.panel11;
            }
            else if (x == 5 && y == 10)
            {
                this.panelToShake = this.panel12;
            }

            //*********************************************
            else if (x == 4 && y == 1)
            {
                this.panelToShake = this.panel15;
            }
            else if (x == 4 && y == 2)
            {
                this.panelToShake = this.panel16;
            }
            else if (x == 4 && y == 3)
            {
                this.panelToShake = this.panel22;
            }
            else if (x == 4 && y == 4)
            {
                this.panelToShake = this.panel21;
            }
            else if (x == 4 && y == 5)
            {
                this.panelToShake = this.panel20;
            }
            else if (x == 4 && y == 6)
            {
                this.panelToShake = this.panel19;
            }
            else if (x == 4 && y == 7)
            {
                this.panelToShake = this.panel18;
            }
            else if (x == 4 && y == 8)
            {
                this.panelToShake = this.panel17;
            }
            else if (x == 4 && y == 9)
            {
                this.panelToShake = this.panel14;
            }
            else if (x == 4 && y == 10)
            {
                this.panelToShake = this.panel13;
            }

            //***************************************
            else if (x == 3 && y == 1)
            {
                this.panelToShake = this.panel25;
            }
            else if (x == 3 && y == 2)
            {
                this.panelToShake = this.panel26;
            }
            else if (x == 3 && y == 3)
            {
                this.panelToShake = this.panel32;
            }
            else if (x == 3 && y == 4)
            {
                this.panelToShake = this.panel31;
            }
            else if (x == 3 && y == 5)
            {
                this.panelToShake = this.panel30;
            }
            else if (x == 3 && y == 6)
            {
                this.panelToShake = this.panel29;
            }
            else if (x == 3 && y == 7)
            {
                this.panelToShake = this.panel28;
            }
            else if (x == 3 && y == 8)
            {
                this.panelToShake = this.panel27;
            }
            else if (x == 3 && y == 9)
            {
                this.panelToShake = this.panel24;
            }
            else if (x == 3 && y == 10)
            {
                this.panelToShake = this.panel23;
            }

            //************************
            else if (x == 2 && y == 1)
            {
                this.panelToShake = this.panel35;
            }
            else if (x == 2 && y == 2)
            {
                this.panelToShake = this.panel36;
            }
            else if (x == 2 && y == 3)
            {
                this.panelToShake = this.panel42;
            }
            else if (x == 2 && y == 4)
            {
                this.panelToShake = this.panel41;
            }
            else if (x == 2 && y == 5)
            {
                this.panelToShake = this.panel40;
            }
            else if (x == 2 && y == 6)
            {
                this.panelToShake = this.panel39;
            }
            else if (x == 2 && y == 7)
            {
                this.panelToShake = this.panel38;
            }
            else if (x == 2 && y == 8)
            {
                this.panelToShake = this.panel37;
            }
            else if (x == 2 && y == 9)
            {
                this.panelToShake = this.panel34;
            }
            else if (x == 2 && y == 10)
            {
                this.panelToShake = this.panel33;
            }

            //*****************************************
            else if (x == 1 && y == 1)
            {
                this.panelToShake = this.panel45;
            }
            else if (x == 1 && y == 2)
            {
                this.panelToShake = this.panel46;
            }
            else if (x == 1 && y == 3)
            {
                this.panelToShake = this.panel52;
            }
            else if (x == 1 && y == 4)
            {
                this.panelToShake = this.panel51;
            }
            else if (x == 1 && y == 5)
            {
                this.panelToShake = this.panel50;
            }
            else if (x == 1 && y == 6)
            {
                this.panelToShake = this.panel49;
            }
            else if (x == 1 && y == 7)
            {
                this.panelToShake = this.panel48;
            }
            else if (x == 1 && y == 8)
            {
                this.panelToShake = this.panel47;
            }
            else if (x == 1 && y == 9)
            {
                this.panelToShake = this.panel44;
            }
            else if (x == 1 && y == 10)
            {
                this.panelToShake = this.panel43;
            }


        }

        // get the shaked case cordination x and y
        private int[] getRiskMatrixCordination(String s)
        {
            int[] cord = new int[2];

            if (s == "")
            {
                cord = null;
            }
            else
            {
                var getNumbers = (from t in s
                                  where char.IsDigit(t)
                                  select t).ToArray();

                if (getNumbers.Count() == 2)
                {
                    cord[0] = getNumbers[0] - '0';
                    cord[1] = getNumbers[1] - '0';
                }
                else if (getNumbers.Count() == 3 && getNumbers[2] == '0')
                {
                    cord[0] = getNumbers[0] - '0';
                    cord[1] = 10;
                }
                else
                {
                    cord = null;
                }

            }

            return cord;
        }


        /****************************** event  **********************/

        private void panel10_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=5,y=1)";
            this.Close();
        }

        private void panel9_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=5,y=2)";
            this.Close();
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=5,y=3)";
            this.Close();
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=5,y=4)";
            this.Close();
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=5,y=5)";
            this.Close();
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=5,y=6)";
            this.Close();
        }

        private void panel7_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=5,y=7)";
            this.Close();
        }

        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=5,y=8)";
            this.Close();
        }

        private void panel11_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=5,y=9)";
            this.Close();
        }

        private void panel12_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=5,y=10)";
            this.Close();
        }

        private void panel13_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=4,y=10)";
            this.Close();
        }

        private void panel14_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=4,y=9)";
            this.Close();
        }

        private void panel17_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=4,y=8)";
            this.Close();
        }

        private void panel18_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=4,y=7)";
            this.Close();
        }

        private void panel19_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=4,y=6)";
            this.Close();
        }

        private void panel20_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=4,y=5)";
            this.Close();
        }

        private void panel23_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=3,y=10)";
            this.Close();
        }

        private void panel24_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=3,y=9)";
            this.Close();
        }

        private void panel27_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=3,y=8)";
            this.Close();
        }

        private void panel28_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=3,y=7)";
            this.Close();
        }

        private void panel15_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GELB, (x=4,y=1)";
            this.Close();
        }

        private void panel16_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GELB, (x=4,y=2)";
            this.Close();
        }

        private void panel22_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "ROT, (x=4,y=3)";
            this.Close();
        }

        private void panel21_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GELB, (x=4,y=4)";
            this.Close();
        }

        private void panel31_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GELB, (x=3,y=4)";
            this.Close();
        }

        private void panel30_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GELB, (x=3,y=5)";
            this.Close();
        }

        private void panel29_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GELB, (x=3,y=6)";
            this.Close();
        }

        private void panel38_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GELB, (x=2,y=7)";
            this.Close();
        }

        private void panel37_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GELB, (x=2,y=8)";
            this.Close();
        }

        private void panel34_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GELB, (x=2,y=9)";
            this.Close();
        }

        private void panel33_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GELB, (x=2,y=10)";
            this.Close();
        }

        private void panel25_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GRÜN, (x=3,y=1)";
            this.Close();
        }

        private void panel26_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GRÜN, (x=3,y=2)";
            this.Close();
        }

        private void panel32_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GRÜN, (x=3,y=3)";
            this.Close();
        }

        private void panel35_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GRÜN, (x=2,y=1)";
            this.Close();
        }

        private void panel36_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GRÜN, (x=2,y=2)";
            this.Close();
        }

        private void panel42_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GRÜN, (x=2,y=3)";
            this.Close();
        }

        private void panel41_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GRÜN, (x=2,y=4)";
            this.Close();
        }

        private void panel40_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GRÜN, (x=2,y=5)";
            this.Close();
        }

        private void panel39_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GRÜN, (x=2,y=6)";
            this.Close();
        }

        private void panel45_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GRÜN, (x=1,y=1)";
            this.Close();
        }

        private void panel46_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GRÜN, (x=1,y=2)";
            this.Close();
        }

        private void panel52_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GRÜN, (x=1,y=3)";
            this.Close();
        }

        private void panel51_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GRÜN, (x=1,y=4)";
            this.Close();
        }

        private void panel50_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GRÜN, (x=1,y=5)";
            this.Close();
        }

        private void panel49_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GRÜN, (x=1,y=6)";
            this.Close();
        }

        private void panel48_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GRÜN, (x=1,y=7)";
            this.Close();
        }

        private void panel47_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GRÜN, (x=1,y=8)";
            this.Close();
        }

        private void panel44_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GRÜN, (x=1,y=9)";
            this.Close();
        }

        private void panel43_MouseClick(object sender, MouseEventArgs e)
        {
            this.riskCategory.Text = "GRÜN, (x=1,y=10)";
            this.Close();
        }

    }
}
