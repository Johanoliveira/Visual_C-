namespace Visualizador
{
    partial class w_Visualizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_Visualizador));
            this.btn_Selecionar = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pb_Figura = new System.Windows.Forms.PictureBox();
            this.btn_Aumentar = new System.Windows.Forms.Button();
            this.btn_Diminuir = new System.Windows.Forms.Button();
            this.btnDrawBorder = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.btn_Janela = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Figura)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Selecionar
            // 
            this.btn_Selecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Selecionar.Location = new System.Drawing.Point(324, 34);
            this.btn_Selecionar.Name = "btn_Selecionar";
            this.btn_Selecionar.Size = new System.Drawing.Size(80, 23);
            this.btn_Selecionar.TabIndex = 0;
            this.btn_Selecionar.Text = "Selecionar";
            this.btn_Selecionar.UseVisualStyleBackColor = true;
            this.btn_Selecionar.Click += new System.EventHandler(this.btn_Selecionar_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Location = new System.Drawing.Point(324, 63);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(80, 23);
            this.btn_Fechar.TabIndex = 1;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pb_Figura
            // 
            this.pb_Figura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Figura.Location = new System.Drawing.Point(39, 34);
            this.pb_Figura.Name = "pb_Figura";
            this.pb_Figura.Size = new System.Drawing.Size(265, 238);
            this.pb_Figura.TabIndex = 2;
            this.pb_Figura.TabStop = false;
            this.pb_Figura.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pb_Figura_LoadCompleted);
            this.pb_Figura.MouseLeave += new System.EventHandler(this.pb_Figura_MouseLeave);
            this.pb_Figura.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_Figura_MouseMove);
            // 
            // btn_Aumentar
            // 
            this.btn_Aumentar.Location = new System.Drawing.Point(324, 249);
            this.btn_Aumentar.Name = "btn_Aumentar";
            this.btn_Aumentar.Size = new System.Drawing.Size(23, 23);
            this.btn_Aumentar.TabIndex = 3;
            this.btn_Aumentar.Text = "+";
            this.btn_Aumentar.UseVisualStyleBackColor = true;
            this.btn_Aumentar.Click += new System.EventHandler(this.btn_Aumentar_Click);
            // 
            // btn_Diminuir
            // 
            this.btn_Diminuir.Location = new System.Drawing.Point(353, 249);
            this.btn_Diminuir.Name = "btn_Diminuir";
            this.btn_Diminuir.Size = new System.Drawing.Size(23, 23);
            this.btn_Diminuir.TabIndex = 4;
            this.btn_Diminuir.Text = "-";
            this.btn_Diminuir.UseVisualStyleBackColor = true;
            this.btn_Diminuir.Click += new System.EventHandler(this.btn_Diminuir_Click);
            // 
            // btnDrawBorder
            // 
            this.btnDrawBorder.Location = new System.Drawing.Point(324, 92);
            this.btnDrawBorder.Name = "btnDrawBorder";
            this.btnDrawBorder.Size = new System.Drawing.Size(80, 23);
            this.btnDrawBorder.TabIndex = 5;
            this.btnDrawBorder.Text = "Draw Border";
            this.btnDrawBorder.UseVisualStyleBackColor = true;
            this.btnDrawBorder.Click += new System.EventHandler(this.btnDrawBorder_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(321, 128);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 6;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(321, 141);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 13);
            this.lblY.TabIndex = 7;
            this.lblY.Text = "Y:";
            // 
            // btn_Janela
            // 
            this.btn_Janela.Location = new System.Drawing.Point(324, 173);
            this.btn_Janela.Name = "btn_Janela";
            this.btn_Janela.Size = new System.Drawing.Size(75, 23);
            this.btn_Janela.TabIndex = 8;
            this.btn_Janela.Text = "Abrir Janela";
            this.btn_Janela.UseVisualStyleBackColor = true;
            this.btn_Janela.Click += new System.EventHandler(this.btn_Janela_Click);
            // 
            // w_Visualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(414, 291);
            this.Controls.Add(this.btn_Janela);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnDrawBorder);
            this.Controls.Add(this.btn_Diminuir);
            this.Controls.Add(this.btn_Aumentar);
            this.Controls.Add(this.pb_Figura);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btn_Selecionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "w_Visualizador";
            this.Text = "Visualizador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_Visualizador_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.w_Visualizador_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Figura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Selecionar;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pb_Figura;
        private System.Windows.Forms.Button btn_Aumentar;
        private System.Windows.Forms.Button btn_Diminuir;
        private System.Windows.Forms.Button btnDrawBorder;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Button btn_Janela;
    }
}

