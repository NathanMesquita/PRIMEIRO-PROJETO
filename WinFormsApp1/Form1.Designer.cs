namespace WinFormsApp1
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            lblMensagem = new Label();
            btnMostrarMensagem = new Button();
            btnPropriedadesCheckBox = new Button();
            btnVisualizadorImagens = new Button();
            btnCalculadora = new Button();
            SuspendLayout();
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensagem.ForeColor = Color.FromArgb(128, 128, 255);
            lblMensagem.Location = new Point(51, 210);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 33);
            lblMensagem.TabIndex = 0;
            lblMensagem.Click += label1_Click;
            // 
            // btnMostrarMensagem
            // 
            btnMostrarMensagem.ForeColor = SystemColors.WindowText;
            btnMostrarMensagem.Location = new Point(128, 261);
            btnMostrarMensagem.Name = "btnMostrarMensagem";
            btnMostrarMensagem.Size = new Size(130, 23);
            btnMostrarMensagem.TabIndex = 1;
            btnMostrarMensagem.Text = "Mostrar Mensagem";
            btnMostrarMensagem.UseVisualStyleBackColor = true;
            btnMostrarMensagem.Click += btnMostrarMensagem_Click;
            // 
            // btnPropriedadesCheckBox
            // 
            btnPropriedadesCheckBox.ForeColor = SystemColors.WindowText;
            btnPropriedadesCheckBox.Location = new Point(29, 38);
            btnPropriedadesCheckBox.Name = "btnPropriedadesCheckBox";
            btnPropriedadesCheckBox.Size = new Size(75, 23);
            btnPropriedadesCheckBox.TabIndex = 2;
            btnPropriedadesCheckBox.Text = "CheckBox";
            btnPropriedadesCheckBox.UseVisualStyleBackColor = true;
            btnPropriedadesCheckBox.Click += btnPropriedadesCheckBox_Click;
            // 
            // btnVisualizadorImagens
            // 
            btnVisualizadorImagens.ForeColor = SystemColors.WindowText;
            btnVisualizadorImagens.Location = new Point(282, 38);
            btnVisualizadorImagens.Name = "btnVisualizadorImagens";
            btnVisualizadorImagens.Size = new Size(70, 23);
            btnVisualizadorImagens.TabIndex = 3;
            btnVisualizadorImagens.Text = "Imagens";
            btnVisualizadorImagens.UseVisualStyleBackColor = true;
            btnVisualizadorImagens.Click += btnVisualizadorImagens_Click;
            // 
            // btnCalculadora
            // 
            btnCalculadora.ForeColor = SystemColors.WindowText;
            btnCalculadora.Location = new Point(152, 38);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Size = new Size(81, 23);
            btnCalculadora.TabIndex = 4;
            btnCalculadora.Text = "Calculadora";
            btnCalculadora.UseVisualStyleBackColor = true;
            btnCalculadora.Click += btnCalculadora_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(382, 319);
            Controls.Add(btnCalculadora);
            Controls.Add(btnVisualizadorImagens);
            Controls.Add(btnPropriedadesCheckBox);
            Controls.Add(btnMostrarMensagem);
            Controls.Add(lblMensagem);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplicativo em C#";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensagem;
        private Button btnMostrarMensagem;
        private Button btnPropriedadesCheckBox;
        private Button btnVisualizadorImagens;
        private Button btnCalculadora;
    }
}
