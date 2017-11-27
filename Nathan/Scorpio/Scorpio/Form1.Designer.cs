namespace Scorpio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextB = new System.Windows.Forms.TextBox();
            this.TextA = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.ButFechar = new System.Windows.Forms.Button();
            this.ButEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextB
            // 
            this.TextB.Location = new System.Drawing.Point(30, 131);
            this.TextB.Name = "TextB";
            this.TextB.Size = new System.Drawing.Size(100, 20);
            this.TextB.TabIndex = 0;
            this.TextB.TextChanged += new System.EventHandler(this.TextB_TextChanged);
            // 
            // TextA
            // 
            this.TextA.Location = new System.Drawing.Point(30, 74);
            this.TextA.Name = "TextA";
            this.TextA.Size = new System.Drawing.Size(100, 20);
            this.TextA.TabIndex = 1;
            this.TextA.TextChanged += new System.EventHandler(this.TextA_TextChanged);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(58, 52);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Usuario";
            this.labelUsuario.Click += new System.EventHandler(this.labelUsuario_Click);
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(61, 112);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 3;
            this.labelSenha.Text = "Senha";
            this.labelSenha.Click += new System.EventHandler(this.labelSenha_Click);
            // 
            // ButFechar
            // 
            this.ButFechar.Location = new System.Drawing.Point(30, 186);
            this.ButFechar.Name = "ButFechar";
            this.ButFechar.Size = new System.Drawing.Size(75, 23);
            this.ButFechar.TabIndex = 4;
            this.ButFechar.Text = "Cancelar";
            this.ButFechar.UseVisualStyleBackColor = true;
            this.ButFechar.Click += new System.EventHandler(this.ButFechar_Click);
            // 
            // ButEntrar
            // 
            this.ButEntrar.Location = new System.Drawing.Point(166, 186);
            this.ButEntrar.Name = "ButEntrar";
            this.ButEntrar.Size = new System.Drawing.Size(75, 23);
            this.ButEntrar.TabIndex = 5;
            this.ButEntrar.Text = "Entrar";
            this.ButEntrar.UseVisualStyleBackColor = true;
            this.ButEntrar.Click += new System.EventHandler(this.ButEntrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ButEntrar);
            this.Controls.Add(this.ButFechar);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.TextA);
            this.Controls.Add(this.TextB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextB;
        private System.Windows.Forms.TextBox TextA;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Button ButFechar;
        private System.Windows.Forms.Button ButEntrar;
    }
}

