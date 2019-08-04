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
                StreamReader sr = new StreamReader("F:\\ScoreCricket\\Stats.txt");
                StreamReader sr1 = new StreamReader("F:\\ScoreCricket\\Stats.txt");
                StringBuilder sb = new StringBuilder("", 50);
                line = sr.ReadLine();
                line = sr1.ReadLine();
                nop = Int32.Parse(line);
                //flowLayoutPanel1.Controls.Clear();
                for (int x = 0; x < nop; x++)
                {
                    
                    line = sr.ReadLine();
                    length = line.Length;
                    for (int y = length; y >0; y--)
                    {
                        
                        val = (char)sr1.Read();

                        if (val == ' ')
                        {
                            
                            switch (caseSwitch)
                            {
                                case 1:
                                    name = sb.ToString();
                                    caseSwitch++;
                                    sb.Clear();
                                    break;

                                case 2:

                                    strikerate = Int32.Parse(sb.ToString());
                                    caseSwitch++;
                                    sb.Clear();
                                    break;

                                case 3:
                                    economyrate = Int32.Parse(sb.ToString());
                                    caseSwitch++;
                                    sb.Clear();
                                    break;

                                case 4:
                                    runs = Int32.Parse(sb.ToString());
                                    caseSwitch++;
                                    sb.Clear();
                                    break;

                                case 5:
                                    wickets = Int32.Parse(sb.ToString());
                                    caseSwitch++;
                                    sb.Clear();
                                    break;

                                case 6:
                                    fours = Int32.Parse(sb.ToString());
                                    caseSwitch++;
                                    sb.Clear();
                                    break;

                                case 7:
                                    sixes = Int32.Parse(sb.ToString());
                                    caseSwitch++;
                                    caseSwitch = 1;
                                    sb.Clear();
                                    break;

                                default:

                                    sb.Clear();
                                    break;
                            }
                        
                        } else
                        {
                            sb.Append(val);
                        }
                    }
                    
                    Label currentName = new Label();
                    currentName.Name = name;
                    currentName.Text = name;
                    currentName.AutoSize = false;
                    //currentName.Size = (80, 80);
                    //flowLayoutPanel1.Controls.Add(currentName);

                }


                sr.Close();
                sr1.Close();
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

        

       

        
    }
}
