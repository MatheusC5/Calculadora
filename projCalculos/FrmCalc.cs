using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projCalculos
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                lblSinal.Text = "+";
                a = int.Parse(txtNum1.Text);
                b = int.Parse(txtNum2.Text);

                lblResultado.Text = (a + b).ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show(this, "Informe corretamente os valores" ,"Advertência",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            lblSinal.Text = "?";
            lblResultado.Text = "";
            txtNum1.Focus();//envia o foco para o controle txtNum1
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                lblSinal.Text = "-";
                a = int.Parse(txtNum1.Text);
                b = int.Parse(txtNum2.Text);

                lblResultado.Text = (a - b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Informe corretamente os valores", "Advertência", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                lblSinal.Text = "X";
                a = int.Parse(txtNum1.Text);
                b = int.Parse(txtNum2.Text);

                lblResultado.Text = (a * b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Informe corretamente os valores", "Advertência", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                lblSinal.Text = "/";
                a = int.Parse(txtNum1.Text);
                b = int.Parse(txtNum2.Text);
         
                if(a!=0 && b==0)
                {
                    MessageBox.Show(this, "Informe um número que não seja 0", "Advertência", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(a==0 && b==0)
                {
                    lblResultado.Text = "0";

                }
                else
                {
                    lblResultado.Text = (a / b).ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Informe corretamente os valores", "Advertência", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRestInt_Click(object sender, EventArgs e)
        {
            int a, b;

            try
            {
                lblSinal.Text = "%";
                a = int.Parse(txtNum1.Text);
                b = int.Parse(txtNum2.Text);

                if (a!=0 && b==0)
                {
                    MessageBox.Show(this, "Informe um número que não seja 0", "Advertência", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lblResultado.Text = (a % b).ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Informe corretamente os valores", "Advertência", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            int a, b;
            lblSinal.Text = "C";
            a = int.Parse(txtNum1.Text);
            b = int.Parse(txtNum2.Text);

            if (a > b)
            {
                lblResultado.Text = a + " é maior que " + b;
            }
            else if (a < b)
            {
                lblResultado.Text = a + " é menor que " + b;
            }
            else
            {
                lblResultado.Text = a + " é igual a " + b;
            }
        }

        private void btnParImpar_Click(object sender, EventArgs e)
        {
            int a, b;
            lblSinal.Text = "P/I";
            a = int.Parse(txtNum1.Text);
            b = int.Parse(txtNum2.Text);
            
            if(a % 2==0 && b % 2 ==0)
            {
                lblResultado.Text = a + " e " + b + " são pares";
            }
            else if(a % 2 !=0  && b % 2 != 0)
            {
                lblResultado.Text = a + " e " + b + " são ímpares";
            }
            else if (a % 2 == 0 && b % 2 != 0)
            {
                lblResultado.Text = a + " é par" + " e " + b + " é ímpar";
            }
            else
            {
                lblResultado.Text = a + " é ímpar" + " e " + b + " é par";
            }
        }
    }
}
