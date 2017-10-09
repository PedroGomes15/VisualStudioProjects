namespace _1_Evento
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
            this.button1 = new System.Windows.Forms.Button();
            this.btLer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tbNomeLido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(40, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Muda Cor vermelho";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btLer
            // 
            this.btLer.Location = new System.Drawing.Point(149, 142);
            this.btLer.Name = "btLer";
            this.btLer.Size = new System.Drawing.Size(75, 23);
            this.btLer.TabIndex = 1;
            this.btLer.Text = "Ler Nome";
            this.btLer.UseVisualStyleBackColor = true;
            this.btLer.Click += new System.EventHandler(this.btLer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome.:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(149, 116);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(189, 20);
            this.tb_nome.TabIndex = 3;
            // 
            // tbNomeLido
            // 
            this.tbNomeLido.Location = new System.Drawing.Point(149, 189);
            this.tbNomeLido.Name = "tbNomeLido";
            this.tbNomeLido.Size = new System.Drawing.Size(189, 20);
            this.tbNomeLido.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 516);
            this.Controls.Add(this.tbNomeLido);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLer);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btLer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tbNomeLido;
    }
}

