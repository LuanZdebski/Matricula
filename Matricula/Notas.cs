using Matricula.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula
{
    public partial class Notas : Form
    {
        Form1 paginaInicial;
        Aluno aluno;
        public Notas(Form1 paginaInicial, Aluno aluno)
        {
            InitializeComponent();
            this.paginaInicial = paginaInicial;
            this.aluno = aluno;

            txtAlunoNome.Text = "Aluno: " + aluno.nomeAluno;
            txtAlunoRA.Text = "RA: " + aluno.numeroRA;
            AtualizarTabela();
        }
        private void AtualizarTabela()
        {
            int columnCount = 1;
            int rowCount = 1;
            foreach (Curso curso in aluno.cursosMatriculados)
            {
                if (columnCount < curso.numPeriodos)
                {
                    columnCount = curso.numPeriodos;
                }
                if (rowCount < aluno.numCursosMatriculados * 5)
                {
                    rowCount = aluno.numCursosMatriculados * 5;
                }
                
            }

            TabelaNotas.ColumnCount = columnCount;
            TabelaNotas.RowCount = rowCount;

            int indice = 0;
            foreach (Curso curso in aluno.cursosMatriculados)
            {
                TabelaNotas.Rows[indice*5].Cells[0].Value = curso.nomeCurso;
                
                int indwhile = 0;
                while (indwhile < curso.numPeriodos)
                {
                    TabelaNotas.Rows[(indice * 5)+1].Cells[indwhile].Value = (indwhile+1) + " Período";
                    indwhile++;
                }
                indice++;
            }
            AtualizarNotas();
        }
        public void AtualizarNotas()
        {
            int indiceCurso = 0;
            foreach (Curso curso in aluno.cursosMatriculados)
            {
                
                for (int i = 0; i < curso.numPeriodos; i++)
                {

                    TabelaNotas.Rows[(indiceCurso * 5) + 2].Cells[i].Value = aluno.listaNotas[indiceCurso].Notas[i];
                    if (aluno.listaNotas[indiceCurso].Notas[i] < curso.mediaAprovacao)
                    {
                        TabelaNotas.Rows[(indiceCurso * 5) + 3].Cells[i].Value = "Reprovado";

                    }
                    else { TabelaNotas.Rows[(indiceCurso * 5) + 3].Cells[i].Value = "Aprovado"; }
                    
                }
                indiceCurso++;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtualizarUmaNota atualizarUmaNota = new AtualizarUmaNota(this, aluno);
            atualizarUmaNota.Show();

        }
    }
}
