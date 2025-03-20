namespace TargetSistemas
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnExercicio2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExercicio3 = new System.Windows.Forms.Button();
            this.btnExercicio4 = new System.Windows.Forms.Button();
            this.btnExercicio5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExercicio2
            // 
            this.btnExercicio2.Location = new System.Drawing.Point(12, 189);
            this.btnExercicio2.Name = "btnExercicio2";
            this.btnExercicio2.Size = new System.Drawing.Size(101, 39);
            this.btnExercicio2.TabIndex = 0;
            this.btnExercicio2.Text = "Exercício 2";
            this.btnExercicio2.UseVisualStyleBackColor = true;
            this.btnExercicio2.Click += new System.EventHandler(this.btnExercicio2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 137);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // btnExercicio3
            // 
            this.btnExercicio3.Location = new System.Drawing.Point(12, 246);
            this.btnExercicio3.Name = "btnExercicio3";
            this.btnExercicio3.Size = new System.Drawing.Size(101, 39);
            this.btnExercicio3.TabIndex = 2;
            this.btnExercicio3.Text = "Exercício 3";
            this.btnExercicio3.UseVisualStyleBackColor = true;
            this.btnExercicio3.Click += new System.EventHandler(this.btnExercicio3_Click);
            // 
            // btnExercicio4
            // 
            this.btnExercicio4.Location = new System.Drawing.Point(12, 303);
            this.btnExercicio4.Name = "btnExercicio4";
            this.btnExercicio4.Size = new System.Drawing.Size(101, 39);
            this.btnExercicio4.TabIndex = 3;
            this.btnExercicio4.Text = "Exercício 4";
            this.btnExercicio4.UseVisualStyleBackColor = true;
            this.btnExercicio4.Click += new System.EventHandler(this.btnExercicio4_Click);
            // 
            // btnExercicio5
            // 
            this.btnExercicio5.Location = new System.Drawing.Point(12, 360);
            this.btnExercicio5.Name = "btnExercicio5";
            this.btnExercicio5.Size = new System.Drawing.Size(101, 39);
            this.btnExercicio5.TabIndex = 4;
            this.btnExercicio5.Text = "Exercício 5";
            this.btnExercicio5.UseVisualStyleBackColor = true;
            this.btnExercicio5.Click += new System.EventHandler(this.btnExercicio5_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.btnExercicio5);
            this.Controls.Add(this.btnExercicio4);
            this.Controls.Add(this.btnExercicio3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExercicio2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExercicio2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnExercicio3;
        private System.Windows.Forms.Button btnExercicio4;
        private System.Windows.Forms.Button btnExercicio5;
    }
}

