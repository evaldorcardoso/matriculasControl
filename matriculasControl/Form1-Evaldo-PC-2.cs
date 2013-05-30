using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexaoDllMaster;

namespace matriculasControl
{
    public partial class frmAlunos : Form
    {
        public static DataTable dt;//dataTable para guardar alunos
        public static DataTable dd;//dataTable para guardar disciplinas
        public static DataTable ds;//dataTable para guardar semestres
        
        public frmAlunos()
        {
            InitializeComponent();

            dd = ClsDisciplinas.listar();
            dgvDisciplinas.DataSource = dd;

            dt = ClsAlunos.listar();
            dgvAlunos.DataSource = dt;

            ds = clsSemestres.listar();
            dgvSemestres.DataSource = ds;

            comboBox1.DataSource = dd;
            comboBox1.ValueMember = "id_disciplina";
            comboBox1.DisplayMember = "";
            
        }
        
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvAlunos.DataSource = ClsAlunos.pesquisar(txtNomeAluno.Text);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmAlunosCadastro telaCadastro = new frmAlunosCadastro();
            telaCadastro.Show();

        }
       
        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            dt = ClsAlunos.listar();
            dgvAlunos.DataSource = dt;
            txtNomeAluno.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nomeAluno,codAluno,dataNasc;
            dt = ClsAlunos.listar();
            ClsAlunos aluno = new ClsAlunos();
            //aluno.nome=(dt.Rows[dgvAlunos.CurrentRow.Index]["nome"].ToString());
            nomeAluno = dt.Rows[dgvAlunos.CurrentRow.Index]["nome"].ToString();
            //aluno.id_aluno =Convert.ToInt32(dt.Rows[dgvAlunos.CurrentRow.Index]["id_aluno"]);
            codAluno = dt.Rows[dgvAlunos.CurrentRow.Index]["id_aluno"].ToString();
            //aluno.data_nasc = dt.Rows[dgvAlunos.CurrentRow.Index]["data_nasc"].ToString();
            dataNasc = dt.Rows[dgvAlunos.CurrentRow.Index]["data_nasc"].ToString();
            frmAlunosCadastro telaEditar = new frmAlunosCadastro(nomeAluno, codAluno, dataNasc);
            telaEditar.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //StringBuilder codigo = new StringBuilder();
            
            if (dgvAlunos.SelectedRows.Count > 0)
            {
                //codigo.Append(dgvAlunos.SelectedRows[0].Cells[0].Value.ToString());
                ClsAlunos.cod = Convert.ToInt32(dt.Rows[dgvAlunos.CurrentRow.Index]["id_aluno"]);
                //ClsAlunos.cod = Convert.ToInt32(dgvAlunos.SelectedRows[0].Cells[0].Value);
                ClsAlunos.excluir(ClsAlunos.cod);
                
                //MessageBox.Show(cod.ToString());
            }
            else
            {
                //codigo.Append(dgvAlunos.Rows[0].Cells[0].Value.ToString());
                ClsAlunos.cod = Convert.ToInt32(dgvAlunos.Rows[0].Cells[0].Value);
                ClsAlunos.excluir(ClsAlunos.cod);
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTeste teste = new frmTeste();
            teste.Show();
        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {
         
            
                dt = ClsAlunos.listar();
                dgvAlunos.DataSource = dt;
                //dgvAlunos.DataSource = ClsAlunos.listar();
                //MessageBox.Show(ClsAlunos.cont.ToString());
                
            
        
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            frmTeste teste = new frmTeste();
            teste.Show();
        }

        private void btnInserirDisciplina_Click(object sender, EventArgs e)
        {
            frmDisciplinasCadastro cadastrarDisc = new frmDisciplinasCadastro();
            cadastrarDisc.Show();
        }

        private void btnInserirSemestre_Click(object sender, EventArgs e)
        {
            frmSemestresCadastro cadastrarSem = new frmSemestresCadastro();
            cadastrarSem.Show();
        }

        

        
  
    }
}
