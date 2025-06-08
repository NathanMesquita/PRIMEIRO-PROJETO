namespace WinFormsApp1 {
    partial class frmCalculadora {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            btnCalcular = new Button();
            textValor1 = new TextBox();
            textValor2 = new TextBox();
            rbSoma = new RadioButton();
            rbSubtração = new RadioButton();
            rbMultiplicação = new RadioButton();
            rbDivisao = new RadioButton();
            textResultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.ForeColor = SystemColors.WindowText;
            btnCalcular.Location = new Point(114, 215);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // textValor1
            // 
            textValor1.Location = new Point(31, 49);
            textValor1.Name = "textValor1";
            textValor1.Size = new Size(100, 23);
            textValor1.TabIndex = 1;
            textValor1.TextChanged += textValor1_TextChanged;
            // 
            // textValor2
            // 
            textValor2.Location = new Point(173, 49);
            textValor2.Name = "textValor2";
            textValor2.Size = new Size(100, 23);
            textValor2.TabIndex = 2;
            textValor2.TextChanged += textBox2_TextChanged;
            // 
            // rbSoma
            // 
            rbSoma.AutoSize = true;
            rbSoma.ForeColor = SystemColors.WindowText;
            rbSoma.Location = new Point(31, 98);
            rbSoma.Name = "rbSoma";
            rbSoma.Size = new Size(55, 19);
            rbSoma.TabIndex = 3;
            rbSoma.TabStop = true;
            rbSoma.Text = "Soma";
            rbSoma.UseVisualStyleBackColor = true;
            rbSoma.CheckedChanged += rbSoma_CheckedChanged;
            // 
            // rbSubtração
            // 
            rbSubtração.AutoSize = true;
            rbSubtração.ForeColor = SystemColors.WindowText;
            rbSubtração.Location = new Point(31, 123);
            rbSubtração.Name = "rbSubtração";
            rbSubtração.Size = new Size(78, 19);
            rbSubtração.TabIndex = 4;
            rbSubtração.TabStop = true;
            rbSubtração.Text = "Subtração";
            rbSubtração.UseVisualStyleBackColor = true;
            rbSubtração.CheckedChanged += rbSubtração_CheckedChanged;
            // 
            // rbMultiplicação
            // 
            rbMultiplicação.AutoSize = true;
            rbMultiplicação.ForeColor = SystemColors.WindowText;
            rbMultiplicação.Location = new Point(31, 148);
            rbMultiplicação.Name = "rbMultiplicação";
            rbMultiplicação.Size = new Size(97, 19);
            rbMultiplicação.TabIndex = 5;
            rbMultiplicação.TabStop = true;
            rbMultiplicação.Text = "Multiplicação";
            rbMultiplicação.UseVisualStyleBackColor = true;
            rbMultiplicação.CheckedChanged += rbMultiplicação_CheckedChanged;
            // 
            // rbDivisao
            // 
            rbDivisao.AutoSize = true;
            rbDivisao.ForeColor = SystemColors.WindowText;
            rbDivisao.Location = new Point(31, 173);
            rbDivisao.Name = "rbDivisao";
            rbDivisao.Size = new Size(63, 19);
            rbDivisao.TabIndex = 6;
            rbDivisao.TabStop = true;
            rbDivisao.Text = "Divisao";
            rbDivisao.UseVisualStyleBackColor = true;
            rbDivisao.CheckedChanged += rbDivisao_CheckedChanged;
            // 
            // textResultado
            // 
            textResultado.Location = new Point(99, 292);
            textResultado.Name = "textResultado";
            textResultado.Size = new Size(100, 23);
            textResultado.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(56, 31);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 8;
            label1.Text = "Valor 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(205, 31);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 9;
            label2.Text = "Valor 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(31, 295);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 10;
            label3.Text = "Resultado:";
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(309, 337);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textResultado);
            Controls.Add(rbDivisao);
            Controls.Add(rbMultiplicação);
            Controls.Add(rbSubtração);
            Controls.Add(rbSoma);
            Controls.Add(textValor2);
            Controls.Add(textValor1);
            Controls.Add(btnCalcular);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox textValor1;
        private TextBox textValor2;
        private RadioButton rbSoma;
        private RadioButton rbSubtração;
        private RadioButton rbMultiplicação;
        private RadioButton rbDivisao;
        private TextBox textResultado;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}