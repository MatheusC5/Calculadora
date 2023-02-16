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
    public partial class frmRDB : Form
    {
        public frmRDB()
        {
            InitializeComponent();
        }

        private void btnRSomar_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "+";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpRadios_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, c;
                a = int.Parse(txtNum1.Text);
                b = int.Parse(txtNum2.Text);
                switch (lblSinal.Text)
                {
                    case "+":
                        {
                            c = a + b;
                            lblResultado.Text = c.ToString();
                            break;
                        }
                    case "-":
                        {
                            c = a - b;
                            lblResultado.Text = c.ToString();
                            break;
                        }
                    case "X":
                        {
                            c = a * b;
                            lblResultado.Text = c.ToString();
                            break;
                        }
                    case "/":
                        {
                            try
                            {
                                lblSinal.Text = "/";
                                a = int.Parse(txtNum1.Text);
                                b = int.Parse(txtNum2.Text);

                                if (a != 0 && b == 0)
                                {
                                    MessageBox.Show(this, "Informe um número que não seja 0", "Advertência", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else if (a == 0 && b == 0)
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
                            break;
                        }
                    case "C":
                        {
                            if (a > b)
                            {
                                lblResultado.Text = a + " \né maior que\n " + b;
                            }
                            else if (a < b)
                            {
                                lblResultado.Text = a + " \né menor que " + b;
                            }
                            else
                            {
                                lblResultado.Text = a + " \né igual a\n " + b;
                            }
                            break;
                        }
                    case "%":
                        {
                            try
                            {
                                lblSinal.Text = "%";
                                a = int.Parse(txtNum1.Text);
                                b = int.Parse(txtNum2.Text);

                                if (a != 0 && b == 0)
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
                            break;
                        }
                    default:
                        {
                            a = int.Parse(txtNum1.Text);
                            b = int.Parse(txtNum2.Text);
                            if (a % 2 == 0 && b % 2 == 0)
                            {
                                lblResultado.Text = a + " e " + b + " \n são pares";
                            }
                            else if (a % 2 != 0 && b % 2 != 0)
                            {
                                lblResultado.Text = a + " e " + b + " \n são ímpares";
                            }
                            else if (a % 2 == 0 && b % 2 != 0)
                            {
                                lblResultado.Text = a + " é par" + " e " + b + " \né ímpar";
                            }
                            else
                            {
                                lblResultado.Text = a + " é ímpar" + " e " + b + " \né par";
                            }
                            break;
                        }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Informe corretamente os valores", "Advertência", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnRSubtrair_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "-";
        }

        private void btnRMultiplicar_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "X";
        }

        private void btnRDividir_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "/";
        }

        private void btnRComparar_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "C";
        }

        private void btnRRestoInteiro_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "%";
        }

        private void btnRParImpar_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "P/I";
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            lblResultado.Text = "";
        }

        private void btnFech_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
