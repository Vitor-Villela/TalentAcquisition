namespace RecursosHumanos
{
    partial class telaCadastro
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
            textNome = new TextBox();
            textSenha = new TextBox();
            btCadastrar = new Button();
            btLimpar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Location = new Point(183, 146);
            textNome.Name = "textNome";
            textNome.Size = new Size(408, 23);
            textNome.TabIndex = 0;
            // 
            // textSenha
            // 
            textSenha.Location = new Point(183, 258);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(408, 23);
            textSenha.TabIndex = 1;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(440, 344);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(151, 46);
            btCadastrar.TabIndex = 2;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(183, 344);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(149, 46);
            btLimpar.TabIndex = 3;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += btLimpar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F);
            label1.Location = new Point(306, 30);
            label1.Name = "label1";
            label1.Size = new Size(180, 51);
            label1.TabIndex = 4;
            label1.Text = "Cadastrar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(183, 118);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 5;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(183, 230);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 6;
            label3.Text = "Senha";
            // 
            // telaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btLimpar);
            Controls.Add(btCadastrar);
            Controls.Add(textSenha);
            Controls.Add(textNome);
            Name = "telaCadastro";
            Text = "telaCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNome;
        private TextBox textSenha;
        private Button btCadastrar;
        private Button btLimpar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}