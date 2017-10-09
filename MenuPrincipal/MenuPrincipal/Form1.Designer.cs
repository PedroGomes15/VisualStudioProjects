namespace MenuPrincipal
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.lbDataHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btChamaForm = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataEHoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxRadioButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mascarasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manipulaStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funçõesMatematicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDataHora
            // 
            this.lbDataHora.AutoSize = true;
            this.lbDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataHora.Location = new System.Drawing.Point(22, 288);
            this.lbDataHora.Name = "lbDataHora";
            this.lbDataHora.Size = new System.Drawing.Size(0, 24);
            this.lbDataHora.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btChamaForm
            // 
            this.btChamaForm.Location = new System.Drawing.Point(12, 234);
            this.btChamaForm.Name = "btChamaForm";
            this.btChamaForm.Size = new System.Drawing.Size(178, 23);
            this.btChamaForm.TabIndex = 1;
            this.btChamaForm.Text = "Datas e Horas";
            this.btChamaForm.UseVisualStyleBackColor = true;
            this.btChamaForm.Click += new System.EventHandler(this.btChamaForm_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataEHoraToolStripMenuItem,
            this.checkBoxRadioButtonToolStripMenuItem,
            this.mascarasToolStripMenuItem,
            this.manipulaStringToolStripMenuItem,
            this.funçõesMatematicasToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.formsToolStripMenuItem.Text = "Formularios";
            // 
            // dataEHoraToolStripMenuItem
            // 
            this.dataEHoraToolStripMenuItem.Name = "dataEHoraToolStripMenuItem";
            this.dataEHoraToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.dataEHoraToolStripMenuItem.Text = "Data e Hora";
            this.dataEHoraToolStripMenuItem.Click += new System.EventHandler(this.dataEHoraToolStripMenuItem_Click);
            // 
            // checkBoxRadioButtonToolStripMenuItem
            // 
            this.checkBoxRadioButtonToolStripMenuItem.Name = "checkBoxRadioButtonToolStripMenuItem";
            this.checkBoxRadioButtonToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.checkBoxRadioButtonToolStripMenuItem.Text = "Check Box/RadioButton";
            this.checkBoxRadioButtonToolStripMenuItem.Click += new System.EventHandler(this.checkBoxRadioButtonToolStripMenuItem_Click);
            // 
            // mascarasToolStripMenuItem
            // 
            this.mascarasToolStripMenuItem.Name = "mascarasToolStripMenuItem";
            this.mascarasToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.mascarasToolStripMenuItem.Text = "Mascaras";
            this.mascarasToolStripMenuItem.Click += new System.EventHandler(this.mascarasToolStripMenuItem_Click);
            // 
            // manipulaStringToolStripMenuItem
            // 
            this.manipulaStringToolStripMenuItem.Name = "manipulaStringToolStripMenuItem";
            this.manipulaStringToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.manipulaStringToolStripMenuItem.Text = "Manipula String";
            this.manipulaStringToolStripMenuItem.Click += new System.EventHandler(this.manipulaStringToolStripMenuItem_Click);
            // 
            // funçõesMatematicasToolStripMenuItem
            // 
            this.funçõesMatematicasToolStripMenuItem.Name = "funçõesMatematicasToolStripMenuItem";
            this.funçõesMatematicasToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.funçõesMatematicasToolStripMenuItem.Text = "Funções Matematicas";
            this.funçõesMatematicasToolStripMenuItem.Click += new System.EventHandler(this.funçõesMatematicasToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(829, 321);
            this.Controls.Add(this.btChamaForm);
            this.Controls.Add(this.lbDataHora);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDataHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btChamaForm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataEHoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxRadioButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mascarasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manipulaStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funçõesMatematicasToolStripMenuItem;
    }
}

