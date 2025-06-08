namespace WinFormsApp1
{
    partial class frmVisualizadorImagens
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizadorImagens));
            pictureBox1 = new PictureBox();
            pblImagens = new PictureBox();
            rbStretch = new RadioButton();
            rbNormal = new RadioButton();
            btnMostrarImagem = new Button();
            btnLimparImagem = new Button();
            ofdImagens = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pblImagens).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OIP__3__removebg_preview;
            pictureBox1.Location = new Point(161, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(477, 341);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pblImagens
            // 
            pblImagens.Location = new Point(207, 74);
            pblImagens.Name = "pblImagens";
            pblImagens.Size = new Size(388, 241);
            pblImagens.SizeMode = PictureBoxSizeMode.StretchImage;
            pblImagens.TabIndex = 1;
            pblImagens.TabStop = false;
            // 
            // rbStretch
            // 
            rbStretch.AutoSize = true;
            rbStretch.ForeColor = SystemColors.WindowText;
            rbStretch.Location = new Point(530, 403);
            rbStretch.Name = "rbStretch";
            rbStretch.Size = new Size(62, 19);
            rbStretch.TabIndex = 2;
            rbStretch.TabStop = true;
            rbStretch.Text = "Stretch";
            rbStretch.UseVisualStyleBackColor = true;
            rbStretch.CheckedChanged += rbStretch_CheckedChanged;
            // 
            // rbNormal
            // 
            rbNormal.AutoSize = true;
            rbNormal.ForeColor = SystemColors.WindowText;
            rbNormal.Location = new Point(530, 368);
            rbNormal.Name = "rbNormal";
            rbNormal.Size = new Size(65, 19);
            rbNormal.TabIndex = 3;
            rbNormal.TabStop = true;
            rbNormal.Text = "Normal";
            rbNormal.UseVisualStyleBackColor = true;
            rbNormal.CheckedChanged += rbNormal_CheckedChanged;
            // 
            // btnMostrarImagem
            // 
            btnMostrarImagem.ForeColor = SystemColors.WindowText;
            btnMostrarImagem.Location = new Point(207, 399);
            btnMostrarImagem.Name = "btnMostrarImagem";
            btnMostrarImagem.Size = new Size(111, 23);
            btnMostrarImagem.TabIndex = 4;
            btnMostrarImagem.Text = "Mostrar Imagem";
            btnMostrarImagem.UseVisualStyleBackColor = true;
            btnMostrarImagem.Click += btnMostrarImagem_Click;
            // 
            // btnLimparImagem
            // 
            btnLimparImagem.ForeColor = SystemColors.WindowText;
            btnLimparImagem.Location = new Point(338, 399);
            btnLimparImagem.Name = "btnLimparImagem";
            btnLimparImagem.Size = new Size(106, 23);
            btnLimparImagem.TabIndex = 5;
            btnLimparImagem.Text = "Limpar Imagem";
            btnLimparImagem.UseVisualStyleBackColor = true;
            btnLimparImagem.Click += btnLimparImagem_Click;
            // 
            // ofdImagens
            // 
            ofdImagens.FileName = "openFileDialog1";
            ofdImagens.Filter = "Image Files (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            ofdImagens.FileOk += ofdImagens_FileOk;
            // 
            // frmVisualizadorImagens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimparImagem);
            Controls.Add(btnMostrarImagem);
            Controls.Add(rbNormal);
            Controls.Add(rbStretch);
            Controls.Add(pblImagens);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmVisualizadorImagens";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizador de Imagens";
            Load += frmVisualizadorImagens_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pblImagens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pblImagens;
        private RadioButton rbStretch;
        private RadioButton rbNormal;
        private Button btnMostrarImagem;
        private Button btnLimparImagem;
        private OpenFileDialog ofdImagens;
    }
}