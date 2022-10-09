using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class activity7 : Form
    {
        public activity7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Accidentially double clicked on this propertie which opened up its event handler. 
            // If I delete this event handler, it will generate an error with my program.
            // Which I don't know why it does so. Do you have an answer for me Proffessor? 
            // I know I can and should start over for cleaner code, but I want to know why this is happening. 
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Create Variables
            int num;
            double piValue = 4;
            double number = 4;
            double den = 3;
            num = Convert.ToInt32(usersNumTerms.Text);

           //Create for Loop
           for (int i =0; i<=num; i++)
            {
                if (i % 2 == 0)
                {
                    piValue -= number / den;
                }
                else
                {
                    piValue += number / den;
                }
                den += 2;
            }
            //Display Results on Textbox Labels
            userTotalLabel.Text = "Approximate value of pi after " + num + " terms";
            userTotal.Text = "= " + piValue;
        }

        private void userTotal_Click(object sender, EventArgs e)
        {
            // Accidentially double clicked on this propertie which opened up its event handler. 
            // If I delete this event handler, it will generate an error with my program.
            // Which I don't know why it does so. Do you have an answer for me Proffessor? 
            // I know I can and should start over for cleaner code, but I want to know why this is happening. 
        }
    }
}
