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
    
    public partial class NovoCurso : Form
    {
        List<Curso> ListCursos;
        public NovoCurso(List<Curso> ListCursos)
        {
            InitializeComponent();
            this.ListCursos = ListCursos;
        }

        private void btnAdc_Click(object sender, EventArgs e)
        {
            Curso novoCurso = new Curso();
            novoCurso.nomeCurso = txtNome.Text;
            novoCurso.numPeriodos = (int)nUpDownPeriodos.Value;
            novoCurso.mediaAprovacao = (float)nUpDownMedia.Value;

            ListCursos.Add(novoCurso);
            this.Close();
        }
    }
}
