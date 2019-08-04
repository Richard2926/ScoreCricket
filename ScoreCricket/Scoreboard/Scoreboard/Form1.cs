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
        int strikerate;
        int economyrate;
        int runs;
        int wickets;
        int fours;
        int sixes;
        int length;
        char val;
        int caseSwitch = 1;
        int FormWidth = 1280;
        int FormLength = 1024;
        

        public Form1()
        {
            InitializeComponent();
            

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
            //panel1.Visible = true;
            
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\Users\\sanat\\Source\\Repos\\ScoreCricket\\ScoreCricket\\Stats.txt");
                 using (sr) 
                {
                string line;
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = sr.ReadLine()) != null) 
                {
                    string[] temp = line.Split(' ');
                    name= temp[0];
                    strikerate=Int32.Parse(temp[1]);
                    economyrate=Int32.Parse(temp[2]);
                    runs = Int32.Parse(temp[3]);
                    wickets = Int32.Parse(temp[4]);
                    fours = Int32.Parse(temp[5]);
                    sixes = Int32.Parse(temp[6]);
               
                    Label currentName = new Label();
                    currentName.Name = name;
                    currentName.Text = name;
                    currentName.AutoSize = false;
                    currentName.Size = new Size(80, 80);
                    //flowLayoutPanel1.Controls.Add(currentName);
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

        

       

        
    }
}
