namespace Matricula
{
    partial class Notas
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
            this.txtAlunoNome = new System.Windows.Forms.Label();
            this.txtAlunoRA = new System.Windows.Forms.Label();
            this.TabelaNotas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAlunoNome
            // 
            this.txtAlunoNome.AutoSize = true;
            this.txtAlunoNome.Location = new System.Drawing.Point(13, 13);
            this.txtAlunoNome.Name = "txtAlunoNome";
            this.txtAlunoNome.Size = new System.Drawing.Size(37, 13);
            this.txtAlunoNome.TabIndex = 0;
            this.txtAlunoNome.Text = "Aluno:";
            // 
            // txtAlunoRA
            // 
            this.txtAlunoRA.AutoSize = true;
            this.txtAlunoRA.Location = new System.Drawing.Point(13, 38);
            this.txtAlunoRA.Name = "txtAlunoRA";
            this.txtAlunoRA.Size = new System.Drawing.Size(25, 13);
            this.txtAlunoRA.TabIndex = 1;
            this.txtAlunoRA.Text = "RA:";
            // 
            // TabelaNotas
            // 
            this.TabelaNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaNotas.Location = new System.Drawing.Point(16, 64);
            this.TabelaNotas.Name = "TabelaNotas";
            this.TabelaNotas.Size = new System.Drawing.Size(772, 374);
            this.TabelaNotas.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Atualizar Notas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TabelaNotas);
            this.Controls.Add(this.txtAlunoRA);
            this.Controls.Add(this.txtAlunoNome);
            this.Name = "Notas";
            this.Text = "Notas";
            ((System.ComponentModel.ISupportInitialize)(this.TabelaNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAlunoNome;
        private System.Windows.Forms.Label txtAlunoRA;
        private System.Windows.Forms.DataGridView TabelaNotas;
        private System.Windows.Forms.Button button1;
    }
}