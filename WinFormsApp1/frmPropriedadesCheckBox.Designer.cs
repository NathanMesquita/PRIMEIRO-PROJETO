namespace WinFormsApp1
{
    partial class frmPropriedadesCheckBox
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPropriedadesCheckBox));
            chkPessoaFisica = new CheckBox();
            chkPessoaJuridica = new CheckBox();
            pnlPessoaFisica = new Panel();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            pnlPessoaJuridica = new Panel();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            pnlPessoaFisica.SuspendLayout();
            pnlPessoaJuridica.SuspendLayout();
            SuspendLayout();
            // 
            // chkPessoaFisica
            // 
            chkPessoaFisica.AutoSize = true;
            chkPessoaFisica.Font = new Font("Arial", 11.25F);
            chkPessoaFisica.ForeColor = SystemColors.WindowText;
            chkPessoaFisica.Location = new Point(64, 120);
            chkPessoaFisica.Name = "chkPessoaFisica";
            chkPessoaFisica.Size = new Size(120, 21);
            chkPessoaFisica.TabIndex = 0;
            chkPessoaFisica.Text = "Pessoa Fisica";
            chkPessoaFisica.UseVisualStyleBackColor = true;
            chkPessoaFisica.CheckedChanged += chkPessoaFisica_CheckedChanged;
            chkPessoaFisica.CheckStateChanged += chkPessoaFisica_CheckStateChanged;
            // 
            // chkPessoaJuridica
            // 
            chkPessoaJuridica.AutoSize = true;
            chkPessoaJuridica.Font = new Font("Arial", 11.25F);
            chkPessoaJuridica.ForeColor = SystemColors.WindowText;
            chkPessoaJuridica.Location = new Point(64, 239);
            chkPessoaJuridica.Name = "chkPessoaJuridica";
            chkPessoaJuridica.Size = new Size(131, 21);
            chkPessoaJuridica.TabIndex = 1;
            chkPessoaJuridica.Text = "Pessoa Juridica";
            chkPessoaJuridica.UseVisualStyleBackColor = true;
            chkPessoaJuridica.CheckStateChanged += chkPessoaJuridica_CheckStateChanged;
            // 
            // pnlPessoaFisica
            // 
            pnlPessoaFisica.BackColor = Color.DimGray;
            pnlPessoaFisica.BorderStyle = BorderStyle.FixedSingle;
            pnlPessoaFisica.Controls.Add(textBox3);
            pnlPessoaFisica.Controls.Add(label3);
            pnlPessoaFisica.Controls.Add(textBox1);
            pnlPessoaFisica.Controls.Add(label1);
            pnlPessoaFisica.Font = new Font("Arial", 11.25F);
            pnlPessoaFisica.ForeColor = SystemColors.WindowText;
            pnlPessoaFisica.Location = new Point(483, 69);
            pnlPessoaFisica.Name = "pnlPessoaFisica";
            pnlPessoaFisica.Size = new Size(200, 100);
            pnlPessoaFisica.TabIndex = 2;
            pnlPessoaFisica.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 11.25F);
            textBox3.Location = new Point(76, 54);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 25);
            textBox3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F);
            label3.Location = new Point(18, 57);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 11.25F);
            textBox1.Location = new Point(76, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F);
            label1.Location = new Point(18, 21);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // pnlPessoaJuridica
            // 
            pnlPessoaJuridica.BackColor = Color.DimGray;
            pnlPessoaJuridica.BorderStyle = BorderStyle.FixedSingle;
            pnlPessoaJuridica.Controls.Add(textBox4);
            pnlPessoaJuridica.Controls.Add(label4);
            pnlPessoaJuridica.Controls.Add(textBox2);
            pnlPessoaJuridica.Controls.Add(label2);
            pnlPessoaJuridica.Font = new Font("Arial", 11.25F);
            pnlPessoaJuridica.ForeColor = SystemColors.WindowText;
            pnlPessoaJuridica.Location = new Point(483, 199);
            pnlPessoaJuridica.Name = "pnlPessoaJuridica";
            pnlPessoaJuridica.Size = new Size(200, 100);
            pnlPessoaJuridica.TabIndex = 3;
            pnlPessoaJuridica.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial", 11.25F);
            textBox4.Location = new Point(76, 52);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 25);
            textBox4.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F);
            label4.Location = new Point(18, 55);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 3;
            label4.Text = "CNPJ:";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 11.25F);
            textBox2.Location = new Point(76, 18);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F);
            label2.Location = new Point(18, 21);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            // 
            // frmPropriedadesCheckBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlPessoaJuridica);
            Controls.Add(pnlPessoaFisica);
            Controls.Add(chkPessoaJuridica);
            Controls.Add(chkPessoaFisica);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPropriedadesCheckBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Propriedades do CheckBox";
            pnlPessoaFisica.ResumeLayout(false);
            pnlPessoaFisica.PerformLayout();
            pnlPessoaJuridica.ResumeLayout(false);
            pnlPessoaJuridica.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkPessoaFisica;
        private CheckBox chkPessoaJuridica;
        private Panel pnlPessoaFisica;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label3;
        private Panel pnlPessoaJuridica;
        private Label label4;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox4;
    }
}