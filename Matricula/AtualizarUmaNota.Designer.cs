namespace Matricula
{
    partial class AtualizarUmaNota
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
            this.cBoxCurso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Periodo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nUpDownNota = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Periodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownNota)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxCurso
            // 
            this.cBoxCurso.FormattingEnabled = true;
            this.cBoxCurso.Location = new System.Drawing.Point(12, 26);
            this.cBoxCurso.Name = "cBoxCurso";
            this.cBoxCurso.Size = new System.Drawing.Size(121, 21);
            this.cBoxCurso.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Curso";
            // 
            // Periodo
            // 
            this.Periodo.Location = new System.Drawing.Point(12, 80);
            this.Periodo.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Periodo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Periodo.Name = "Periodo";
            this.Periodo.Size = new System.Drawing.Size(57, 20);
            this.Periodo.TabIndex = 13;
            this.Periodo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Período";
            // 
            // nUpDownNota
            // 
            this.nUpDownNota.DecimalPlaces = 1;
            this.nUpDownNota.Location = new System.Drawing.Point(12, 138);
            this.nUpDownNota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUpDownNota.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownNota.Name = "nUpDownNota";
            this.nUpDownNota.Size = new System.Drawing.Size(57, 20);
            this.nUpDownNota.TabIndex = 14;
            this.nUpDownNota.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nova Nota";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(153, 138);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 16;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // AtualizarUmaNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 183);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nUpDownNota);
            this.Controls.Add(this.Periodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBoxCurso);
            this.Name = "AtualizarUmaNota";
            this.Text = "AtualizarNotas";
            ((System.ComponentModel.ISupportInitialize)(this.Periodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Periodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUpDownNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtualizar;
    }
}