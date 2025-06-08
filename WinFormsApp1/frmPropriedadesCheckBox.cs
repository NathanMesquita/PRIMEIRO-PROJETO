using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmPropriedadesCheckBox : Form
    {
        public frmPropriedadesCheckBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //Evento que verifica se o CheckBox está marcado ou desmarcado.
        private void chkPessoaFisica_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkPessoaFisica.Checked == true) //Se o CheckBox chkPessoaFisica estiver marcado.
            {
                pnlPessoaFisica.Visible = true; //O painel pnlPessoaFisica ficara visivel.
            }


            else //senão
            {
                pnlPessoaFisica.Visible = false; //O painel pnlPessoaFisica ficara oculto.
            }
        }

        private void chkPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {

        }
        //Evento que verifica se o CheckBox está marcado ou desmarcado.
        private void chkPessoaJuridica_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkPessoaJuridica.Checked == true) //Se o CheckBox chkPessoaJuridica estiver marcado.
            {
                pnlPessoaJuridica.Visible = true; //O painel pnlPessoaJuridica ficara Visivel.
            }


            else //senão
            {
                pnlPessoaJuridica.Visible= false; //O painel pnlPessoaJuridica ficara oculto.
            }
        }
    }
}