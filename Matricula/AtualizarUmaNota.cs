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
    public partial class AtualizarUmaNota : Form
    {
        Aluno aluno;
        Notas notas;
        public AtualizarUmaNota(Notas notas,Aluno aluno)
        {
            InitializeComponent();
            this.aluno = aluno;
            this.notas = notas;
            Combo();
        }
        private void Combo()
        { 
            foreach(Curso curso in aluno.cursosMatriculados)
            {
                cBoxCurso.Items.Add(curso.nomeCurso);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Curso curso = aluno.cursosMatriculados.Find(c => c.nomeCurso == cBoxCurso.Text);
            if (cBoxCurso.Text != "")
            {
                if(Periodo.Value <= curso.numPeriodos)
                {

                    aluno.listaNotas[curso.ordemCurso-1].Notas[(int)Periodo.Value-1] = (float)nUpDownNota.Value;
                    notas.AtualizarNotas();
                    this.Close();

                }
                else { MessageBox.Show("Periodo invalido"); }
            }
            else { MessageBox.Show("Selecione um curso"); }
        }
    }
}
