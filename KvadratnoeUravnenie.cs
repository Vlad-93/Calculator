using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calculator;

namespace Calculator
{
    public partial class KvadratnoeUravnenie : Form
    {
        public KvadratnoeUravnenie()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            double a, b, c, D, x, x1, x2;
            string result = "";

            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);

            D = b * b - 4 * a * c;

            if (D > 0)
            {
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);

                result = "x1 = " + Convert.ToString(x1).Substring(0, 10) + "    x2 = " + Convert.ToString(x2).Substring(1,10);
            }
            else
                if (D == 0)
                {
                x = -b / (2 * a);
                result = "x = " + Convert.ToString(x);
                }
                else
                    result = "Нет корней";

            txtResult.Text = result;      
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
