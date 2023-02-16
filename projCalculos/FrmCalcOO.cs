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
    public partial class frmCalcOO : Form
    {
        public frmCalcOO()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnResultado_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            try
            {
                Calculadora objCalc = new Calculadora();
                objCalc.Num1 = decimal.Parse(txtNum1.Text);
                objCalc.Num2 = decimal.Parse(txtNum2.Text);

                lblResultado.Text = objCalc.Subtrair();
                lblSinal.Text = btnSubtrair.Text;
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Informe corretamente os valores", "Advertência", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                //Instanciando a classe
                //ou Criando um objeto calculadora
                Calculadora objCalc = new Calculadora();
                objCalc.Num1 = decimal.Parse(txtNum1.Text);
                objCalc.Num2 = decimal.Parse(txtNum2.Text);
                objCalc.Somar();
                lblResultado.Text = objCalc.Resultado.ToString();
                lblSinal.Text = btnSomar.Text;
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Informe corretamente os valores", "Advertência", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSubtrair_Click_1(object sender, EventArgs e)
        {
            Calculadora objCalc = new Calculadora();
            objCalc.Num1 = decimal.Parse(txtNum1.Text);
            objCalc.Num2 = decimal.Parse(txtNum2.Text);

            lblResultado.Text = objCalc.Subtrair();
            lblSinal.Text = btnSubtrair.Text;
        }
        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        
        private void FrmCalcOO_Load(object sender, EventArgs e)
        {

        }

        private void btnComparar_Click_1(object sender, EventArgs e)
        {
            lblSinal.Text = btnComparar.Text;
            int a, b;
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

        private void btnMultiplicar_Click_1(object sender, EventArgs e)
        {
            Calculadora objCalcOO = new Calculadora();
            objCalcOO.Num1 = decimal.Parse(txtNum1.Text);
            objCalcOO.Num2 = decimal.Parse(txtNum2.Text);

            lblResultado.Text = objCalcOO.Multiplicar();
            lblSinal.Text = btnMultiplicar.Text;
        }

        private void btnDividir_Click_1(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                lblSinal.Text = btnDividir.Text;
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
        }

        private void btnRestoInt_Click_1(object sender, EventArgs e)
        {
            int a, b;

            try
            {
                lblSinal.Text = btnRestoInt.Text; ;
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
        }

        private void btnParImpar_Click_1(object sender, EventArgs e)
        {
            lblSinal.Text = btnParImpar.Text;
            int a, b;
            a = int.Parse(txtNum1.Text);
            b = int.Parse(txtNum2.Text);

            if (a % 2 == 0 && b % 2 == 0)
            {
                lblResultado.Text = a + " e " + b + " são pares";
            }
            else if (a % 2 != 0 && b % 2 != 0)
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

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            lblResultado.Text = "";
            txtNum1.Focus();
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
