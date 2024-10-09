namespace RecursosHumanos
{
    partial class Form1
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
        private void InitializeComponent()
        {
            textUser = new TextBox();
            textPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btEntrar = new Button();
            btCadastrar = new Button();
            SuspendLayout();
            // 
            // textUser
            // 
            textUser.Location = new Point(123, 98);
            textUser.Margin = new Padding(3, 2, 3, 2);
            textUser.Name = "textUser";
            textUser.Size = new Size(394, 23);
            textUser.TabIndex = 0;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(123, 184);
            textPassword.Margin = new Padding(3, 2, 3, 2);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(394, 23);
            textPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 64);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 141);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // btEntrar
            // 
            btEntrar.Location = new Point(412, 275);
            btEntrar.Margin = new Padding(3, 2, 3, 2);
            btEntrar.Name = "btEntrar";
            btEntrar.Size = new Size(82, 22);
            btEntrar.TabIndex = 4;
            btEntrar.Text = "Entrar";
            btEntrar.UseVisualStyleBackColor = true;
            btEntrar.Click += btEntrar_Click;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(163, 269);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(129, 28);
            btCadastrar.TabIndex = 5;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 338);
            Controls.Add(btCadastrar);
            Controls.Add(btEntrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textPassword);
            Controls.Add(textUser);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUser;
        private TextBox textPassword;
        private Label label1;
        private Label label2;
        private Button btEntrar;
        private Button btCadastrar;
    }
}
