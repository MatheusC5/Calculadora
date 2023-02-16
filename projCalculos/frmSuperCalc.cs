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
    public partial class frmSuperCalc : Form
    {
        public frmSuperCalc()
        {
            InitializeComponent();
        }
        SCalc objSCalc = new SCalc();
        bool vLimpar = false;
        private void Insere_Numero(object botao, EventArgs e)//Colocar no "Onclick" do botão em Eventos a opção de "Insere Número"
        {
            //if (lblVisor.Text == "0" && (botao as Button).Text=="0" || vLimpar) {lblVisor.Text = "";}   
            if (!((botao as Button).Text == "." && lblVisor.Text.Contains("."))) //!= não
            {

                if (lblVisor.Text == "0" || vLimpar)
                {
                    lblVisor.Text = "";
                    vLimpar = false;
                }
                lblVisor.Text += (botao as Button).Text;
            }
            lblVisor.Focus(); //Remove foco do botão
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AoClicarSinal(object botao, EventArgs e)
        {
            objSCalc.Operação = (botao as Button).Text;
            objSCalc.NumAnterior = decimal.Parse(lblVisor.Text);
            vLimpar = true;
            lblVisor.Focus();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objSCalc.NumAtual = decimal.Parse(lblVisor.Text);
            lblVisor.Text = objSCalc.Calcular();
            vLimpar = true;
            lblVisor.Focus();
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {

        }

        private void FrmSuperCalc_KeyDown(object sender, KeyEventArgs e)
        {
            Button bot = new Button();
            //S = v.subtring(4,4)=>pega apartir do 4 quatro caracteres
            //MessageBox.Show(e.KeyCode.ToString()); //=>tenque colocar isso para mostrar o nome da tecla
            //Cálculos com o Teclado Numérico
            if (e.KeyCode>=Keys.NumPad0 && e.KeyCode<=Keys.NumPad9)
            {
                bot.Text = e.KeyCode.ToString().Substring(6, 1);
                Insere_Numero(bot, e);
                return;
            }
            else if(e.KeyCode== Keys.Decimal)
            {
                bot.Text = ".";
                Insere_Numero(bot, e);
                return;
            }
            string operacao = e.KeyCode.ToString();
            switch (operacao)
            {
                case "Add":
                    {
                        bot.Text = "+";
                        AoClicarSinal(bot, e);
                        break;
                    }
                case "Subtract":
                    {
                        bot.Text = "-";
                        AoClicarSinal(bot, e);
                        break;
                    }
                case "Multiply":
                    {
                        bot.Text = "X";
                        AoClicarSinal(bot, e);
                        break;
                    }
                case "Divide":
                    {
                        bot.Text = ":";
                        AoClicarSinal(bot, e);
                        break;
                    }
                case "PageUp":
                    {
                        bot.Text = "^";
                        AoClicarSinal(bot, e);
                        break;
                    }

                case "Return":
                    {
                        bot.Text = "=";
                        btnCalcular_Click(bot, e);
                        break;
                    }
                case "Back":
                    {
                        bot.Text = "CE";
                        btnCE_Click(bot, e);
                        break;
                    }
                case "Oemplus":
                    {
                        bot.Text = "=";
                        btnCalcular_Click(bot, e);
                        break;
                    }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
            if (lblVisor.Text == "") lblVisor.Text = "0"; //Quando for somente uma instrução pode isso
        }
    }
}
