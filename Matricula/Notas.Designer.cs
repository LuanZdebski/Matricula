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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 374);
            this.dataGridView1.TabIndex = 2;
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAlunoRA);
            this.Controls.Add(this.txtAlunoNome);
            this.Name = "Notas";
            this.Text = "Notas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAlunoNome;
        private System.Windows.Forms.Label txtAlunoRA;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}