namespace ComboBox_Metodos
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
            this.cb_Pegar = new System.Windows.Forms.ComboBox();
            this.bt_Adicionar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Ultima = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_Pegar
            // 
            this.cb_Pegar.FormattingEnabled = true;
            this.cb_Pegar.Items.AddRange(new object[] {
            "Julia Ruiz",
            "Thaisi Avancia",
            "Bianca Novelli",
            "Amanda Couto",
            "Lara Cruz"});
            this.cb_Pegar.Location = new System.Drawing.Point(41, 64);
            this.cb_Pegar.Name = "cb_Pegar";
            this.cb_Pegar.Size = new System.Drawing.Size(221, 21);
            this.cb_Pegar.TabIndex = 0;
            // 
            // bt_Adicionar
            // 
            this.bt_Adicionar.Location = new System.Drawing.Point(480, 91);
            this.bt_Adicionar.Name = "bt_Adicionar";
            this.bt_Adicionar.Size = new System.Drawing.Size(92, 35);
            this.bt_Adicionar.TabIndex = 1;
            this.bt_Adicionar.Text = "Adicionar";
            this.bt_Adicionar.UseVisualStyleBackColor = true;
            this.bt_Adicionar.Click += new System.EventHandler(this.bt_Adicionar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(337, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 20);
            this.textBox1.TabIndex = 2;
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Location = new System.Drawing.Point(108, 91);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(92, 35);
            this.bt_Limpar.TabIndex = 3;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ultima Gostosa Adicionada:";
            // 
            // lb_Ultima
            // 
            this.lb_Ultima.AutoSize = true;
            this.lb_Ultima.Location = new System.Drawing.Point(293, 232);
            this.lb_Ultima.Name = "lb_Ultima";
            this.lb_Ultima.Size = new System.Drawing.Size(0, 13);
            this.lb_Ultima.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 281);
            this.Controls.Add(this.lb_Ultima);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_Adicionar);
            this.Controls.Add(this.cb_Pegar);
            this.Name = "Form1";
            this.Text = "Pedro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Pegar;
        private System.Windows.Forms.Button bt_Adicionar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Ultima;
    }
}

