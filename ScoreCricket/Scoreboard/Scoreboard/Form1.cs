using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Scoreboard
{
    public partial class Form1 : Form
    {
        String sb1;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
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

             String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("F:\\ScoreCricket\\Stats.txt");
                StringBuilder sb = new StringBuilder("", 50);
                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    char val = (char) sr.Read();
                    if (val == ' ')
                    {
                        Console.WriteLine(sb);
                        Player1.Text = sb.ToString();
                        sb1 = sb.ToString();
                        sb.Clear();
                    } else
                    {
                        sb.Append(new char[] { val });
                    }
                    //write the lie to console window
                    //Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();

                    sb.Append(new char[] { 'D', 'E', 'F' });
                }

                sr.Close();
                Console.ReadLine();
            }
            catch (Exception f)
            {
                Console.WriteLine("Exception: " + f.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            } 
        }

        

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Player1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Player1.Text = sb1;
        }
    }
}
