namespace Calculos
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
            this.bt_Soma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Num1 = new System.Windows.Forms.TextBox();
            this.tb_Num2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Dividir = new System.Windows.Forms.Button();
            this.bt_Multiplicar = new System.Windows.Forms.Button();
            this.bt_Subtrair = new System.Windows.Forms.Button();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Soma
            // 
            this.bt_Soma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_Soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Soma.Location = new System.Drawing.Point(270, 250);
            this.bt_Soma.Name = "bt_Soma";
            this.bt_Soma.Size = new System.Drawing.Size(50, 50);
            this.bt_Soma.TabIndex = 0;
            this.bt_Soma.Text = "+";
            this.bt_Soma.UseVisualStyleBackColor = false;
            this.bt_Soma.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero 1.:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_Num1
            // 
            this.tb_Num1.Location = new System.Drawing.Point(354, 176);
            this.tb_Num1.Name = "tb_Num1";
            this.tb_Num1.Size = new System.Drawing.Size(127, 20);
            this.tb_Num1.TabIndex = 2;
            // 
            // tb_Num2
            // 
            this.tb_Num2.Location = new System.Drawing.Point(354, 217);
            this.tb_Num2.Name = "tb_Num2";
            this.tb_Num2.Size = new System.Drawing.Size(127, 20);
            this.tb_Num2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero 2.:";
            // 
            // bt_Dividir
            // 
            this.bt_Dividir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_Dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Dividir.Location = new System.Drawing.Point(431, 250);
            this.bt_Dividir.Name = "bt_Dividir";
            this.bt_Dividir.Size = new System.Drawing.Size(50, 50);
            this.bt_Dividir.TabIndex = 5;
            this.bt_Dividir.Text = "/";
            this.bt_Dividir.UseVisualStyleBackColor = false;
            this.bt_Dividir.Click += new System.EventHandler(this.bt_Dividir_Click);
            // 
            // bt_Multiplicar
            // 
            this.bt_Multiplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_Multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Multiplicar.Location = new System.Drawing.Point(379, 250);
            this.bt_Multiplicar.Name = "bt_Multiplicar";
            this.bt_Multiplicar.Size = new System.Drawing.Size(50, 50);
            this.bt_Multiplicar.TabIndex = 6;
            this.bt_Multiplicar.Text = "*";
            this.bt_Multiplicar.UseVisualStyleBackColor = false;
            this.bt_Multiplicar.Click += new System.EventHandler(this.bt_Multiplicar_Click);
            // 
            // bt_Subtrair
            // 
            this.bt_Subtrair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_Subtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Subtrair.Location = new System.Drawing.Point(323, 250);
            this.bt_Subtrair.Name = "bt_Subtrair";
            this.bt_Subtrair.Size = new System.Drawing.Size(50, 50);
            this.bt_Subtrair.TabIndex = 7;
            this.bt_Subtrair.Text = "-";
            this.bt_Subtrair.UseVisualStyleBackColor = false;
            this.bt_Subtrair.Click += new System.EventHandler(this.bt_Subtrair_Click);
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(354, 332);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(127, 20);
            this.tbResultado.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Calculadora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 514);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_Subtrair);
            this.Controls.Add(this.bt_Multiplicar);
            this.Controls.Add(this.bt_Dividir);
            this.Controls.Add(this.tb_Num2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Soma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Soma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Num1;
        private System.Windows.Forms.TextBox tb_Num2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Dividir;
        private System.Windows.Forms.Button bt_Multiplicar;
        private System.Windows.Forms.Button bt_Subtrair;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

