namespace Subtração
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
            this.lblInstrucao1 = new System.Windows.Forms.Label();
            this.lblInstrucao2 = new System.Windows.Forms.Label();
            this.lblInstrucao3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstrucao1
            // 
            this.lblInstrucao1.AutoSize = true;
            this.lblInstrucao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInstrucao1.Location = new System.Drawing.Point(12, 40);
            this.lblInstrucao1.Name = "lblInstrucao1";
            this.lblInstrucao1.Size = new System.Drawing.Size(381, 17);
            this.lblInstrucao1.TabIndex = 0;
            this.lblInstrucao1.Text = "Para calcular a subtração de dois valores, digite-os abaixo:";
            // 
            // lblInstrucao2
            // 
            this.lblInstrucao2.AutoSize = true;
            this.lblInstrucao2.Location = new System.Drawing.Point(175, 134);
            this.lblInstrucao2.Name = "lblInstrucao2";
            this.lblInstrucao2.Size = new System.Drawing.Size(82, 13);
            this.lblInstrucao2.TabIndex = 1;
            this.lblInstrucao2.Text = "Primeiro número";
            // 
            // lblInstrucao3
            // 
            this.lblInstrucao3.AutoSize = true;
            this.lblInstrucao3.Location = new System.Drawing.Point(169, 180);
            this.lblInstrucao3.Name = "lblInstrucao3";
            this.lblInstrucao3.Size = new System.Drawing.Size(88, 13);
            this.lblInstrucao3.TabIndex = 2;
            this.lblInstrucao3.Text = "Segundo número";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(25, 37);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Resultado";
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(263, 131);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(171, 20);
            this.txtValue1.TabIndex = 4;
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(263, 177);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(171, 20);
            this.txtValue2.TabIndex = 5;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(350, 250);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(84, 33);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "Subtrair";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.lblResult);
            this.gbResult.Location = new System.Drawing.Point(67, 308);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(389, 78);
            this.gbResult.TabIndex = 7;
            this.gbResult.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 405);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 33);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(263, 250);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 33);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.lblInstrucao3);
            this.Controls.Add(this.lblInstrucao2);
            this.Controls.Add(this.lblInstrucao1);
            this.Name = "Form1";
            this.Text = "Subtração de Valores";
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstrucao1;
        private System.Windows.Forms.Label lblInstrucao2;
        private System.Windows.Forms.Label lblInstrucao3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
    }
}

