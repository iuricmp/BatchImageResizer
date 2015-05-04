namespace BatchImageResizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelecionaPasta = new System.Windows.Forms.Button();
            this.txtNomePasta = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnLerEstrutura = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblArquivosEncontrados = new System.Windows.Forms.Label();
            this.btnIniciarReducao = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQtdReduzidos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelecionaPasta
            // 
            this.btnSelecionaPasta.Location = new System.Drawing.Point(319, 43);
            this.btnSelecionaPasta.Name = "btnSelecionaPasta";
            this.btnSelecionaPasta.Size = new System.Drawing.Size(191, 23);
            this.btnSelecionaPasta.TabIndex = 1;
            this.btnSelecionaPasta.Text = "Selecionar Pasta Origem";
            this.btnSelecionaPasta.UseVisualStyleBackColor = true;
            this.btnSelecionaPasta.Click += new System.EventHandler(this.btnSelecionaPasta_Click);
            // 
            // txtNomePasta
            // 
            this.txtNomePasta.Location = new System.Drawing.Point(92, 43);
            this.txtNomePasta.Name = "txtNomePasta";
            this.txtNomePasta.Size = new System.Drawing.Size(221, 20);
            this.txtNomePasta.TabIndex = 2;
            // 
            // btnLerEstrutura
            // 
            this.btnLerEstrutura.Location = new System.Drawing.Point(319, 106);
            this.btnLerEstrutura.Name = "btnLerEstrutura";
            this.btnLerEstrutura.Size = new System.Drawing.Size(191, 23);
            this.btnLerEstrutura.TabIndex = 4;
            this.btnLerEstrutura.Text = "Exibir Estrutura de Pastas";
            this.btnLerEstrutura.UseVisualStyleBackColor = true;
            this.btnLerEstrutura.Click += new System.EventHandler(this.btnLerEstrutura_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 135);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(647, 173);
            this.textBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Arquivos Encontrados: ";
            // 
            // lblArquivosEncontrados
            // 
            this.lblArquivosEncontrados.AutoSize = true;
            this.lblArquivosEncontrados.Location = new System.Drawing.Point(127, 310);
            this.lblArquivosEncontrados.Name = "lblArquivosEncontrados";
            this.lblArquivosEncontrados.Size = new System.Drawing.Size(0, 13);
            this.lblArquivosEncontrados.TabIndex = 7;
            // 
            // btnIniciarReducao
            // 
            this.btnIniciarReducao.Location = new System.Drawing.Point(319, 345);
            this.btnIniciarReducao.Name = "btnIniciarReducao";
            this.btnIniciarReducao.Size = new System.Drawing.Size(191, 23);
            this.btnIniciarReducao.TabIndex = 8;
            this.btnIniciarReducao.Text = "Iniciar Redução Imagens";
            this.btnIniciarReducao.UseVisualStyleBackColor = true;
            this.btnIniciarReducao.Click += new System.EventHandler(this.btnIniciarReducao_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(319, 374);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(191, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Arquivos Reduzidos:";
            // 
            // lblQtdReduzidos
            // 
            this.lblQtdReduzidos.AutoSize = true;
            this.lblQtdReduzidos.Location = new System.Drawing.Point(126, 328);
            this.lblQtdReduzidos.Name = "lblQtdReduzidos";
            this.lblQtdReduzidos.Size = new System.Drawing.Size(0, 13);
            this.lblQtdReduzidos.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 443);
            this.Controls.Add(this.lblQtdReduzidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnIniciarReducao);
            this.Controls.Add(this.lblArquivosEncontrados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btnLerEstrutura);
            this.Controls.Add(this.txtNomePasta);
            this.Controls.Add(this.btnSelecionaPasta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionaPasta;
        private System.Windows.Forms.TextBox txtNomePasta;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnLerEstrutura;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblArquivosEncontrados;
        private System.Windows.Forms.Button btnIniciarReducao;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQtdReduzidos;
    }
}

