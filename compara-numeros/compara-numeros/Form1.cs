using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compara_numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int num3 = int.Parse(txtNum3.Text);


            //if (num1 >= num2 && num1 >= num3)
            //{
            //    lblResultado.Text = num1.ToString();
            //}
            //else if (num2 >= num1 && num2 >= num3)
            //{
            //    lblResultado.Text = num2.ToString();
            //}
            //else
            //{
            //    lblResultado.Text = num3.ToString();
            //}

            int[] numeros = { num1, num2, num3 };

            lblResultado.Text = numeros.Max().ToString();



        }
    }
}
