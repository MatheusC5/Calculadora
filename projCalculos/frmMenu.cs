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
    /* Para mudar qual tela que começa o programa vai em Programa do Gerenciador de Soluções, e
      em Application.Run(new frmMenu()); troca o que está do lado esquerdo do () pelo nome do seu progeto que
      você quer wue comece*/
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cálculosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCalc>().Count() > 0)
            {
                Application.OpenForms.OfType<frmCalc>().First().Focus();
            }
            else
            {
                frmCalc objCalcbotao = new frmCalc();
                objCalcbotao.Show();
            }

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void cRadioButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRDB>().Count() > 0)
            {
                Application.OpenForms.OfType<frmRDB>().First().Focus();
            }
            else
            {
                frmRDB objCalcbotao = new frmRDB();
                objCalcbotao.Show();
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cálculadoraOOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCalcOO>().Count() > 0)
            {
                Application.OpenForms.OfType<frmCalcOO>().First().Focus();
            }
            else
            {
                frmCalcOO objCalcbotao = new frmCalcOO();
                objCalcbotao.Show();
            }
        }

        private void superCalcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSuperCalc>().Count() > 0)
            {
                Application.OpenForms.OfType<frmSuperCalc>().First().Focus();
            }
            else
            {
                frmSuperCalc objCalcbotao = new frmSuperCalc();
                objCalcbotao.Show();
            }
        }
    }
}
