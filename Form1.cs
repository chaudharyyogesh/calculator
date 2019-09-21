using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Double result=0;
        String opperformed = "";
        int count = 0;
        bool isopperformed = false;
        bool isequal = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonclick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                count++;
            }
            if (isequal)
            {
                button12.PerformClick();
            }
            if (textbox.Text == "0" || (isopperformed))
            {
                textbox.Clear();
            }
           
            if (count <= 1 || button.Text != ".")
            {
            
                    textbox.Text = textbox.Text + button.Text;
                    isopperformed = false;
                
            }
        }

        private void operation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(isequal==true)
            {
                textbox.Text = "0";
                isequal = false;
            }
            
            
                if (result != 0)
                {
                switch (opperformed)
                {
                    case "+":
                        textbox.Text = (result + Double.Parse(textbox.Text)).ToString();
                        break;
                    case "-":
                        textbox.Text = (result - Double.Parse(textbox.Text)).ToString();
                        break;
                    case "/":
                        textbox.Text = (result / Double.Parse(textbox.Text)).ToString();
                        break;
                    case "*":
                        textbox.Text = (result * Double.Parse(textbox.Text)).ToString();
                        break;
                    default:
                        break;

                }
                result = Double.Parse(textbox.Text);
                opperformed = button.Text;
    
                }
                else
                {
                    opperformed = button.Text;
                    result = Double.Parse(textbox.Text);
                }
                count = 0;
                isopperformed = true;
     label.Text = result + " " + opperformed;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textbox.Text = "0";
            count = 0;
            isequal = false;
           
      
        }

        private void button17_Click(object sender, EventArgs e)
        {
 
            if (textbox.Text != "")
            {
               
                label.Text = label.Text + " " + textbox.Text + " =";
                isequal = true;
                switch (opperformed)
                {
                    case "+":
                        textbox.Text = (result + Double.Parse(textbox.Text)).ToString();
                        break;
                    case "-":
                        textbox.Text = (result - Double.Parse(textbox.Text)).ToString();
                        break;
                    case "/":
                        textbox.Text = (result / Double.Parse(textbox.Text)).ToString();
                        break;
                    case "*":
                        textbox.Text = (result * Double.Parse(textbox.Text)).ToString();
                        break;
                    default:
                        break;

                }
                result = Double.Parse(textbox.Text);


            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textbox.Text = "0";
            result = 0;
            label.Text="";
            count = 0;
            isequal = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
