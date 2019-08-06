using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Scoreboard
{
    public partial class Form1 : Form
    {
        int nop;
        String line;
        String name;
        const int strikerate = 0;
        const int economyrate = 0;
        const int runs = 0;
        const int wickets = 0;
        const int fours = 0;
        const int sixes = 0;
        int panelxsize;
        int panelysize;
        int playernum = 0;
        int FormWidth = 1280;
        int FormLength = 1024;
        int noOfPlayers;
        int toggle = 0;
        int[] stats = new int[] { strikerate, economyrate, runs, wickets, fours, sixes };

        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            panelxsize = (FormWidth * 8) / 10;
            panelysize = (FormLength * 4) / 6;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(FormWidth, FormLength);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            try
            {

                StreamReader sr = new StreamReader("F:\\ScoreCricket\\Stats.txt");
                StreamReader sr1 = new StreamReader("F:\\ScoreCricket\\Stats.txt");

                using (sr1)
                {
                    string line;
                    while ((line = sr1.ReadLine()) != null)
                    {
                        

                        noOfPlayers++;


                    }
                }
                using (sr)
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] temp = line.Split(' ');

                        playernum++;


                        for (int x = 0; x < stats.Length; x++)
                        {
                            if (x == 0)
                            {
                                name = temp[0];
                                toggle = 1;
                                Locate(x, stats[x]);
                                toggle = 0;
                            }

                            if (toggle == 0)
                            {

                                stats[x] = Int32.Parse(temp[x + 1]);

                            }
                            Locate(x, stats[x]);
                        }
                    }
                }


            }
            catch (Exception f)
            {
                Debug.WriteLine("Exception: " + f.Message);

            }
            finally
            {
                Debug.WriteLine("Executing finally block.");
            }
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
            this.flowLayoutPanel1.Location = new System.Drawing.Point((FormWidth / 10), FormLength / 6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(panelxsize, panelysize);
        }
        private void Locate(int column, int value)
        {
            Label currentName = new Label();
            currentName.Location = new Point((column + 1) * (panelxsize / stats.Length), (playernum - 1) * (panelysize / noOfPlayers));
            if (toggle == 0) { 
            currentName.Name = value.ToString();
            currentName.Text = value.ToString();
            } else {
                currentName.Name = name;
                currentName.Text = name;
            }
            currentName.AutoSize = false;
            currentName.Size = new Size(panelxsize / (stats.Length+2), panelysize / noOfPlayers);
            flowLayoutPanel1.Controls.Add(currentName);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}