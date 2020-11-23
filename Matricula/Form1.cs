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
    public partial class Form1 : Form
    {
        List<Curso> ListCursos = new List<Curso>();
        List<Aluno> ListAlunos = new List<Aluno>();


        public Form1()
        {
            InitializeComponent();
      
        }

        private void btnAdcCurso_Click(object sender, EventArgs e)
        {
            NovoCurso novoCurso = new NovoCurso(ListCursos);
            novoCurso.Show();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            PuxarCursos();
        }
        private void PuxarCursos()
        {
            cBoxCursos.Items.Clear();
            foreach (Curso curso in ListCursos)
            {
                cBoxCursos.Items.Add(curso.nomeCurso);
            }
        }

        private void btnAdc_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "") { MessageBox.Show("Preencha o nome"); }
            else
            {
                if (!txtCPF.MaskCompleted) { MessageBox.Show("Preecha o CPF"); }
                else
                {
                    if (!txtRA.MaskCompleted) { MessageBox.Show("Preecha o RA"); }
                    else
                    {
                        if (ListAlunos.Exists(a => a.numeroCPF == txtCPF.Text) || ListAlunos.Exists(a => a.numeroRA == txtRA.Text))
                        {
                            MessageBox.Show("Aluno ja registrado");
                        }
                        else
                        {
                            if (cBoxCursos.Text != "" && !txtMatricula.MaskCompleted) { MessageBox.Show("para adicionar um curso, preencha a data de matricula"); }
                            else
                            {
                                Aluno novoAluno = new Aluno();

                                novoAluno.nomeAluno = txtNome.Text;
                                novoAluno.numeroCPF = txtCPF.Text;
                                novoAluno.numeroRA = txtRA.Text;
                                
                                if(ListCursos.Exists(c => c.nomeCurso == cBoxCursos.Text)  && txtMatricula.MaskCompleted) 
                                {
                                    Curso curso = ListCursos.Find(c => c.nomeCurso == cBoxCursos.Text);
                                   
                                    Nota nota = new Nota();
                                    curso.ordemCurso = 1;
                                    novoAluno.cursosMatriculados.Add(curso);
                                    novoAluno.datasDeMatricula[0] = Convert.ToDateTime(txtMatricula.Text);
                                    novoAluno.numCursosMatriculados++;
                                    for (int i = 0; i < curso.numPeriodos; i++)
                                    {
                                        nota.Notas.Add(0);
                                    }
                                    
                                    
                                    novoAluno.listaNotas.Add(nota);
          
                                }
                               
                                ListAlunos.Add(novoAluno);
                            }
                        }
                    }
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Aluno alunoEncontrado = Find();

            if(alunoEncontrado != null)
            {
                rTextInfo.Clear(); 
                rTextInfo.AppendText("Nome: " + alunoEncontrado.nomeAluno + Environment.NewLine);
                rTextInfo.AppendText("RA: " + alunoEncontrado.numeroRA + Environment.NewLine);
                if (alunoEncontrado.numCursosMatriculados == 0) { rTextInfo.AppendText("nao esta matriculado em nenhum curso"); }
                else
                {
                    rTextInfo.AppendText("Matriculado em: " + Environment.NewLine);
                    for (int i = 0; i < alunoEncontrado.numCursosMatriculados; i++)
                    {
                        rTextInfo.AppendText(alunoEncontrado.cursosMatriculados[i].nomeCurso + " (" + alunoEncontrado.datasDeMatricula[i].Year + " - " + (alunoEncontrado.datasDeMatricula[i].Year + (alunoEncontrado.cursosMatriculados[i].numPeriodos/2)) + ")" + Environment.NewLine);
                    }
                }

            }

            else { rTextInfo.Clear(); rTextInfo.AppendText("nenhum resultado encontrado"); }
        }

        private void btnAdcMatricula_Click(object sender, EventArgs e)
        {
            Aluno alunoEncontrado = Find();
            if (ListAlunos.Exists(a => a == alunoEncontrado) )
            {
                if (cBoxCursos.Text != "" && !txtMatricula.MaskCompleted) { MessageBox.Show("para adicionar um curso, preencha a data de matricula"); }
                else if(cBoxCursos.Text != "" && txtMatricula.MaskCompleted)
                {
                    
                    Curso novoCurso = ListCursos.Find(c => c.nomeCurso == cBoxCursos.Text);
                    Nota nota = new Nota();
                    novoCurso.ordemCurso = alunoEncontrado.numCursosMatriculados + 1;
                    for (int i = 0; i < novoCurso.numPeriodos; i++)
                    {
                        nota.Notas.Add(0);
                    }
                    alunoEncontrado.listaNotas.Add(nota);

                    alunoEncontrado.cursosMatriculados.Add(novoCurso);

                    alunoEncontrado.datasDeMatricula[alunoEncontrado.numCursosMatriculados] = Convert.ToDateTime(txtMatricula.Text);
                    alunoEncontrado.numCursosMatriculados++;

               



                }
            }
            else { MessageBox.Show("preecha qual aluno sera feita a matricula"); }
        
        }
        private Aluno Find()
        {         
            if (ListAlunos.Exists(a => a.nomeAluno == txtNome.Text))
            {
                return ListAlunos.Find(a => a.nomeAluno == txtNome.Text);
              
            }
            else if (ListAlunos.Exists(a => a.numeroCPF == txtCPF.Text))
            {
                return ListAlunos.Find(a => a.numeroCPF == txtCPF.Text);
                
            }
            else if (ListAlunos.Exists(a => a.numeroRA == txtRA.Text))
            {
                return ListAlunos.Find(a => a.numeroRA == txtRA.Text);              
            }
            return null;
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {

            if (ListAlunos.Exists(a => a == Find()))
            {
                Notas notas = new Notas(this, Find());
                notas.Show();
            }
            else { MessageBox.Show("preecha com aluno valido para ver as notas"); }
            
        }
    }
}
