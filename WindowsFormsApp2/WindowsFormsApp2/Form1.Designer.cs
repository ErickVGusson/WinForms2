namespace WindowsFormsApp2
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
            this.btnTroca = new System.Windows.Forms.Button();
            this.txbValor1 = new System.Windows.Forms.TextBox();
            this.txbValor2 = new System.Windows.Forms.TextBox();
            this.txbValor3 = new System.Windows.Forms.TextBox();
            this.btnDecrescente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTroca
            // 
            this.btnTroca.Location = new System.Drawing.Point(12, 64);
            this.btnTroca.Name = "btnTroca";
            this.btnTroca.Size = new System.Drawing.Size(100, 23);
            this.btnTroca.TabIndex = 0;
            this.btnTroca.Text = "Trocar valores";
            this.btnTroca.UseVisualStyleBackColor = true;
            this.btnTroca.Click += new System.EventHandler(this.btnTroca_Click);
            // 
            // txbValor1
            // 
            this.txbValor1.Location = new System.Drawing.Point(12, 12);
            this.txbValor1.Name = "txbValor1";
            this.txbValor1.Size = new System.Drawing.Size(100, 20);
            this.txbValor1.TabIndex = 1;
            // 
            // txbValor2
            // 
            this.txbValor2.Location = new System.Drawing.Point(118, 12);
            this.txbValor2.Name = "txbValor2";
            this.txbValor2.Size = new System.Drawing.Size(100, 20);
            this.txbValor2.TabIndex = 2;
            // 
            // txbValor3
            // 
            this.txbValor3.Location = new System.Drawing.Point(224, 12);
            this.txbValor3.Name = "txbValor3";
            this.txbValor3.Size = new System.Drawing.Size(100, 20);
            this.txbValor3.TabIndex = 3;
            // 
            // btnDecrescente
            // 
            this.btnDecrescente.Location = new System.Drawing.Point(118, 64);
            this.btnDecrescente.Name = "btnDecrescente";
            this.btnDecrescente.Size = new System.Drawing.Size(100, 23);
            this.btnDecrescente.TabIndex = 4;
            this.btnDecrescente.Text = "Decrescente";
            this.btnDecrescente.UseVisualStyleBackColor = true;
            this.btnDecrescente.Click += new System.EventHandler(this.btnDecrescente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 287);
            this.Controls.Add(this.btnDecrescente);
            this.Controls.Add(this.txbValor3);
            this.Controls.Add(this.txbValor2);
            this.Controls.Add(this.txbValor1);
            this.Controls.Add(this.btnTroca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTroca;
        private System.Windows.Forms.TextBox txbValor1;
        private System.Windows.Forms.TextBox txbValor2;
        private System.Windows.Forms.TextBox txbValor3;
        private System.Windows.Forms.Button btnDecrescente;
    }
}

