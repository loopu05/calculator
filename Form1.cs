using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Calc;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        bool znak = true;
        double tmp1;
        double tmp2;
        ICalc Calc;
        public void Correct()
        {
            if (calc.Text[0] == '0' && (calc.Text.IndexOf(",") != 1))
                calc.Text = calc.Text.Remove(0, 1);
        }

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            tmp1 = 0;
            tmp2 = 0;
            Calc = null;
            calc.Text ="0";
            label1.Text = "";
        }

        private void calc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calc.Text = calc.Text + 1;
            Correct();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            calc.Text = calc.Text + 2;
            Correct();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calc.Text = calc.Text + 3;
            Correct();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            calc.Text = calc.Text + 4;
            Correct();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            calc.Text = calc.Text + 5;
            Correct();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calc.Text = calc.Text + 6;
            Correct();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calc.Text = calc.Text + 7;
            Correct();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calc.Text = calc.Text + 8;
            Correct();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calc.Text = calc.Text + 9;
            Correct();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            calc.Text = calc.Text + 0;
            Correct();
        }

        private void sign_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                calc.Text = "-" + calc.Text;
                znak = false;
            }
            else if (znak == false)
            {
                calc.Text = calc.Text.Replace("-", "");
                znak = true;
            }
        }
        private void point_Click(object sender, EventArgs e)
        {
            if(calc.Text.IndexOf(',')==-1)
            {
            calc.Text = calc.Text + "0,";

            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if(calc.Text !="")
            {
                if (Calc != null)
                { 
                tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(calc.Text));
                }
                else
                {
                tmp1 = Convert.ToDouble(calc.Text);
                }
                calc.Text = "";
                Calc = new Plus();
                label1.Text = tmp1.ToString()+"+";
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (calc.Text != "")
            {
                
                
                    if (Calc != null)
                    {
                        tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(calc.Text));
                    }
                    else
                    {
                        tmp1 = Convert.ToDouble(calc.Text);
                    }
                    calc.Text = "";
                    Calc = new Minus();
                    label1.Text = tmp1.ToString() + "-";
                
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (calc.Text != "")
            {
                
                    if (Calc != null)
                    {
                        tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(calc.Text));
                    }
                    else
                    {
                        tmp1 = Convert.ToDouble(calc.Text);
                    }
                    calc.Text = "";
                    Calc = new Multiply();
                    label1.Text = tmp1.ToString()+"*";
                
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (calc.Text != "")
            {
                    if (Calc != null)
                    {
                        tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(calc.Text));
                    }
                    else
                    {
                        tmp1 = Convert.ToDouble(calc.Text);
                    }
                    
                    calc.Text = "";
                Calc = new Divide();
                    label1.Text = tmp1.ToString() + "/";
                
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            calc.Text = "";
            label1.Text = "";
        }

        private void equally_Click(object sender, EventArgs e)
        {
            if(calc.Text !="" && Calc!=null)
            {
                tmp2 = Convert.ToDouble(calc.Text);
                calc.Text = Calc.DoMath(tmp1, tmp2) + "";
                label1.Text = "";
                Calc = null;
            }

        }

    }
}
