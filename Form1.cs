using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzzV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FizzBuzzButton_Click(object sender, EventArgs e)
        {
            var stringArray = new string[100];

            for (int i = 0; i < stringArray.Length; i++)
            {
                if ((i + 1) % 3 != 0 && (i + 1) % 5 != 0)
                {
                    stringArray[i] = (i + 1).ToString();
                }
                if ((i + 1) % 3 == 0)
                {
                    stringArray[i] += "Fizz";
                }
                if ((i + 1) % 5 == 0)
                {
                    stringArray[i] += "Buzz";
                }
            }
            
            OutputLabel.Text = string.Join(", ", stringArray);
        }
    }
}