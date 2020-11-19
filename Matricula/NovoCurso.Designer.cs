namespace Matricula
{
    partial class NovoCurso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.nUpDownMedia = new System.Windows.Forms.NumericUpDown();
            this.nUpDownPeriodos = new System.Windows.Forms.NumericUpDown();
            this.btnAdc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownPeriodos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade de períodos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Média para aprovação";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(247, 20);
            this.txtNome.TabIndex = 3;
            // 
            // nUpDownMedia
            // 
            this.nUpDownMedia.Location = new System.Drawing.Point(13, 137);
            this.nUpDownMedia.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUpDownMedia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownMedia.Name = "nUpDownMedia";
            this.nUpDownMedia.Size = new System.Drawing.Size(57, 20);
            this.nUpDownMedia.TabIndex = 4;
            this.nUpDownMedia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUpDownPeriodos
            // 
            this.nUpDownPeriodos.Location = new System.Drawing.Point(13, 84);
            this.nUpDownPeriodos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nUpDownPeriodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownPeriodos.Name = "nUpDownPeriodos";
            this.nUpDownPeriodos.Size = new System.Drawing.Size(57, 20);
            this.nUpDownPeriodos.TabIndex = 5;
            this.nUpDownPeriodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdc
            // 
            this.btnAdc.Location = new System.Drawing.Point(101, 179);
            this.btnAdc.Name = "btnAdc";
            this.btnAdc.Size = new System.Drawing.Size(75, 23);
            this.btnAdc.TabIndex = 6;
            this.btnAdc.Text = "Adicionar";
            this.btnAdc.UseVisualStyleBackColor = true;
            this.btnAdc.Click += new System.EventHandler(this.btnAdc_Click);
            // 
            // NovoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 214);
            this.Controls.Add(this.btnAdc);
            this.Controls.Add(this.nUpDownPeriodos);
            this.Controls.Add(this.nUpDownMedia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NovoCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovoCurso";
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownPeriodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.NumericUpDown nUpDownMedia;
        private System.Windows.Forms.NumericUpDown nUpDownPeriodos;
        private System.Windows.Forms.Button btnAdc;
    }
}