namespace Matricula
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
            this.rTextInfo = new System.Windows.Forms.RichTextBox();
            this.btnAdc = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtRA = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxCursos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdcCurso = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.MaskedTextBox();
            this.btnAdcMatricula = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rTextInfo
            // 
            this.rTextInfo.Location = new System.Drawing.Point(266, 12);
            this.rTextInfo.Name = "rTextInfo";
            this.rTextInfo.Size = new System.Drawing.Size(522, 329);
            this.rTextInfo.TabIndex = 0;
            this.rTextInfo.Text = "";
            // 
            // btnAdc
            // 
            this.btnAdc.Location = new System.Drawing.Point(12, 379);
            this.btnAdc.Name = "btnAdc";
            this.btnAdc.Size = new System.Drawing.Size(132, 59);
            this.btnAdc.TabIndex = 1;
            this.btnAdc.Text = "Adicionar Aluno";
            this.btnAdc.UseVisualStyleBackColor = true;
            this.btnAdc.Click += new System.EventHandler(this.btnAdc_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(150, 379);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(132, 59);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Pesquisar e Listar";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(12, 88);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 4;
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(12, 147);
            this.txtRA.Mask = "0000000000";
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(100, 20);
            this.txtRA.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "RA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF";
            // 
            // cBoxCursos
            // 
            this.cBoxCursos.FormattingEnabled = true;
            this.cBoxCursos.Location = new System.Drawing.Point(12, 217);
            this.cBoxCursos.Name = "cBoxCursos";
            this.cBoxCursos.Size = new System.Drawing.Size(121, 21);
            this.cBoxCursos.TabIndex = 9;
            this.cBoxCursos.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Curso";
            // 
            // btnAdcCurso
            // 
            this.btnAdcCurso.Location = new System.Drawing.Point(288, 379);
            this.btnAdcCurso.Name = "btnAdcCurso";
            this.btnAdcCurso.Size = new System.Drawing.Size(132, 59);
            this.btnAdcCurso.TabIndex = 11;
            this.btnAdcCurso.Text = "Adicionar Curso";
            this.btnAdcCurso.UseVisualStyleBackColor = true;
            this.btnAdcCurso.Click += new System.EventHandler(this.btnAdcCurso_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data de Matricula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(12, 260);
            this.txtMatricula.Mask = "00/00/0000";
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 12;
            this.txtMatricula.ValidatingType = typeof(System.DateTime);
            // 
            // btnAdcMatricula
            // 
            this.btnAdcMatricula.Location = new System.Drawing.Point(426, 379);
            this.btnAdcMatricula.Name = "btnAdcMatricula";
            this.btnAdcMatricula.Size = new System.Drawing.Size(132, 59);
            this.btnAdcMatricula.TabIndex = 14;
            this.btnAdcMatricula.Text = "Matricular o Aluno";
            this.btnAdcMatricula.UseVisualStyleBackColor = true;
            this.btnAdcMatricula.Click += new System.EventHandler(this.btnAdcMatricula_Click);
            // 
            // btnNotas
            // 
            this.btnNotas.Location = new System.Drawing.Point(656, 379);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(132, 59);
            this.btnNotas.TabIndex = 15;
            this.btnNotas.Text = "Notas e Status";
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNotas);
            this.Controls.Add(this.btnAdcMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.btnAdcCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBoxCursos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnAdc);
            this.Controls.Add(this.rTextInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTextInfo;
        private System.Windows.Forms.Button btnAdc;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtRA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxCursos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdcCurso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtMatricula;
        private System.Windows.Forms.Button btnAdcMatricula;
        private System.Windows.Forms.Button btnNotas;
    }
}

