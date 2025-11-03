namespace MiguelMorandiniSQLServer
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(71, 51);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 0;
            button1.Text = "Criar Tabela";
            button1.UseVisualStyleBackColor = false;
            button1.Click += CriarTabela;
            // 
            // button2
            // 
            button2.Location = new Point(71, 95);
            button2.Name = "button2";
            button2.Size = new Size(106, 23);
            button2.TabIndex = 1;
            button2.Text = "Deletar Tabela";
            button2.UseVisualStyleBackColor = true;
            button2.Click += DeletarTabela;
            // 
            // button3
            // 
            button3.Location = new Point(71, 144);
            button3.Name = "button3";
            button3.Size = new Size(106, 23);
            button3.TabIndex = 2;
            button3.Text = "Inserir Item";
            button3.UseVisualStyleBackColor = true;
            button3.Click += InserirItem;
            // 
            // button4
            // 
            button4.Location = new Point(71, 185);
            button4.Name = "button4";
            button4.Size = new Size(106, 23);
            button4.TabIndex = 3;
            button4.Text = "Atualiza Nome";
            button4.UseVisualStyleBackColor = true;
            button4.Click += AtualizaNome;
            // 
            // button6
            // 
            button6.Location = new Point(72, 308);
            button6.Name = "button6";
            button6.Size = new Size(105, 23);
            button6.TabIndex = 6;
            button6.Text = "Alterar Telefone";
            button6.UseVisualStyleBackColor = true;
            button6.Click += AlterarTelefone;
            // 
            // button7
            // 
            button7.Location = new Point(71, 269);
            button7.Name = "button7";
            button7.Size = new Size(105, 23);
            button7.TabIndex = 5;
            button7.Text = "Alterar Idade";
            button7.UseVisualStyleBackColor = true;
            button7.Click += AlterarIdade;
            // 
            // button8
            // 
            button8.Location = new Point(72, 228);
            button8.Name = "button8";
            button8.Size = new Size(105, 23);
            button8.TabIndex = 4;
            button8.Text = "Excluir Item";
            button8.UseVisualStyleBackColor = true;
            button8.Click += ExcluirItem;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
