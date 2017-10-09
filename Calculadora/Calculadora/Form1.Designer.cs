namespace Calculadora
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
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(12, 12);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(207, 26);
            this.tbNumero.TabIndex = 0;
            this.tbNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbNumero.TextChanged += new System.EventHandler(this.tbNumero_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "BackSpace";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(13, 100);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(47, 36);
            this.bt7.TabIndex = 3;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(172, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(119, 100);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(47, 36);
            this.bt9.TabIndex = 5;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(66, 100);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(47, 36);
            this.bt8.TabIndex = 6;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(65, 142);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(47, 36);
            this.bt5.TabIndex = 10;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(118, 142);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(47, 36);
            this.bt6.TabIndex = 9;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(171, 142);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(47, 36);
            this.button9.TabIndex = 8;
            this.button9.Text = "*";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(12, 142);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(47, 36);
            this.bt4.TabIndex = 7;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(65, 226);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(47, 36);
            this.bt0.TabIndex = 18;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(117, 226);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(47, 68);
            this.button12.TabIndex = 17;
            this.button12.Text = "=";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(170, 226);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(47, 36);
            this.button13.TabIndex = 16;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(12, 226);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(47, 36);
            this.button14.TabIndex = 15;
            this.button14.Text = ".";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(66, 186);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(47, 36);
            this.bt2.TabIndex = 14;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(118, 184);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(47, 36);
            this.bt3.TabIndex = 13;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(171, 184);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(47, 36);
            this.button17.TabIndex = 12;
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(13, 184);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(47, 36);
            this.bt1.TabIndex = 11;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 341);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNumero);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button bt1;
    }
}

