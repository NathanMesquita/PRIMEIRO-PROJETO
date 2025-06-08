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
    public partial class frmVisualizadorImagens : Form
    {
        public frmVisualizadorImagens()
        {
            InitializeComponent();
        }

        private void btnMostrarImagem_Click(object sender, EventArgs e)
        {
            if (ofdImagens.ShowDialog() == DialogResult.OK) //Se o resultado estiver sido encontrado.
            {
                pblImagens.Load(ofdImagens.FileName); //A imagem selecionada vai ser executada.
                btnMostrarImagem.Enabled = false; //Desabilita o botao btnMostrarImagem
            }
        }

        private void btnLimparImagem_Click(object sender, EventArgs e)
        {
            pblImagens.Image = null; //Limpa a imagem do PictureBox pblImagens
            btnMostrarImagem.Enabled = true; //Habilita o botao btnMostrarImagem
        }

        private void frmVisualizadorImagens_Load(object sender, EventArgs e)
        {

        }

        private void rbStretch_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStretch.Checked == true) //Se o radioButton Stretch estiver marcado.
            {
                pblImagens.SizeMode = PictureBoxSizeMode.StretchImage; //A propriedade SizeMode para verificar o tamanho da imagem.
            }
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormal.Checked == true) //Se o radioButton Normal estiver marcado.
            {
                pblImagens.SizeMode = PictureBoxSizeMode.Normal; //A propriedade SizeMode para verificar o tamanho da imagem.
            }
        }

        private void ofdImagens_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
