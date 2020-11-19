using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula.Entidades
{
    public class Aluno
    {
        public string nomeAluno;
        public string numeroRA;
        public string numeroCPF;

        public List<Curso> cursosMatriculados = new List<Curso>();
        public DateTime[] datasDeMatricula = new DateTime[10];
        public int numCursosMatriculados;
    }
}
