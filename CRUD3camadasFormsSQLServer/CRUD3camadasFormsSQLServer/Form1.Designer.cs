using System.Drawing;

namespace CRUD3camadasFormsSQLServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grade_pokemons = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPokedex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grade_pokemons)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisa.:";
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Location = new System.Drawing.Point(88, 15);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(300, 20);
            this.tbPesquisa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Formulario para 3 camadas";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(71, 41);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(321, 20);
            this.tbNome.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome.:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(71, 10);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(44, 20);
            this.tbCodigo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Código.:";
            // 
            // grade_pokemons
            // 
            this.grade_pokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade_pokemons.Location = new System.Drawing.Point(55, 196);
            this.grade_pokemons.Name = "grade_pokemons";
            this.grade_pokemons.Size = new System.Drawing.Size(377, 248);
            this.grade_pokemons.TabIndex = 12;
            this.grade_pokemons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grade_pokemons_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(438, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 64);
            this.button1.TabIndex = 13;
            this.button1.Text = "Mostrar Dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPokedex
            // 
            this.tbPokedex.Location = new System.Drawing.Point(348, 9);
            this.tbPokedex.Name = "tbPokedex";
            this.tbPokedex.Size = new System.Drawing.Size(44, 20);
            this.tbPokedex.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pokedex.:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btPesquisar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbPesquisa);
            this.panel1.Location = new System.Drawing.Point(40, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 47);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbNome);
            this.panel2.Controls.Add(this.tbPokedex);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbCodigo);
            this.panel2.Location = new System.Drawing.Point(55, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 77);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::CRUD3camadasFormsSQLServer.Properties.Resources.pokeball1600;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(503, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 150);
            this.panel3.TabIndex = 18;
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btPesquisar.Image = global::CRUD3camadasFormsSQLServer.Properties.Resources.procurar;
            this.btPesquisar.Location = new System.Drawing.Point(394, 4);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(40, 40);
            this.btPesquisar.TabIndex = 0;
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Image = global::CRUD3camadasFormsSQLServer.Properties.Resources.apagar;
            this.btExcluir.Location = new System.Drawing.Point(438, 288);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(40, 40);
            this.btExcluir.TabIndex = 11;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Image = global::CRUD3camadasFormsSQLServer.Properties.Resources.alterar;
            this.btAlterar.Location = new System.Drawing.Point(438, 334);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(40, 40);
            this.btAlterar.TabIndex = 10;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Image = global::CRUD3camadasFormsSQLServer.Properties.Resources.novo;
            this.btNovo.Location = new System.Drawing.Point(438, 196);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(40, 40);
            this.btNovo.TabIndex = 7;
            this.btNovo.UseVisualStyleBackColor = true;
            // 
            // btGravar
            // 
            this.btGravar.Image = global::CRUD3camadasFormsSQLServer.Properties.Resources.salvar;
            this.btGravar.Location = new System.Drawing.Point(438, 242);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(40, 40);
            this.btGravar.TabIndex = 4;
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 542);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grade_pokemons);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "CRUD em 3 camadas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grade_pokemons)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.DataGridView grade_pokemons;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPokedex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}