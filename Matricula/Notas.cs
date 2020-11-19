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
        }
  
    }
}
