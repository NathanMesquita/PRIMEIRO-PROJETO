namespace WinFormsApp1
{
    public partial class frmPrincipal : Form {
        public frmPrincipal() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btnMostrarMensagem_Click(object sender, EventArgs e) {
            lblMensagem.Text = "Primeiro Aplicativo em C#"; //A label lblMensagem exibe um texto.
            lblMensagem.ForeColor = Color.RoyalBlue; //E a cor do mesmmo é definida como azul royal 
        }

        private void btnPropriedadesCheckBox_Click(object sender, EventArgs e) {
            frmPropriedadesCheckBox propriedades = new frmPropriedadesCheckBox(); //instanciados o formulario.
            propriedades.ShowDialog(); //O formulario é exibido atraves do metodo ShowDialog.
        }

        private void btnVisualizadorImagens_Click(object sender, EventArgs e) {
            frmVisualizadorImagens propriedades = new frmVisualizadorImagens(); //instanciados o formulario.
            propriedades.ShowDialog(); //O formulario é exibido atraves do metodo ShowDialog.
        }

        private void frmPrincipal_Load(object sender, EventArgs e) {

        }

        private void btnCalculadora_Click(object sender, EventArgs e) {
            frmCalculadora propriedades = new frmCalculadora(); //instanciados o formulario.
            propriedades.ShowDialog(); //O formulario é exibido atraves do metodo ShowDialog.
        }
    }
}
