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
        public static DataTable dt;
        
        
        public frmAlunos()
        {
            InitializeComponent();
            dt = ClsAlunos.listar();
            dgvAlunos.DataSource = dt;
            
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
            nomeAluno = dt.Rows[dgvAlunos.CurrentRow.Index]["nome"].ToString();
            codAluno = dt.Rows[dgvAlunos.CurrentRow.Index]["id_aluno"].ToString();
            dataNasc = dt.Rows[dgvAlunos.CurrentRow.Index]["data_nasc"].ToString();
            frmAlunosCadastro telaEditar = new frmAlunosCadastro(nomeAluno,codAluno,dataNasc);
            telaEditar.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.SelectedRows.Count > 0)
            {
                ClsAlunos.cod = Convert.ToInt32(dt.Rows[dgvAlunos.CurrentRow.Index]["id_aluno"]);
                ClsAlunos.excluir(ClsAlunos.cod);
            }
            else
            {
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
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            frmTeste teste = new frmTeste();
            teste.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmDisciplinasCadastro cadastrarDisc = new frmDisciplinasCadastro();
            cadastrarDisc.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmSemestresCadastro cadastrarSem = new frmSemestresCadastro();
            cadastrarSem.Show();
        }

        private void frmAlunos_FormClosing(object sender, FormClosingEventArgs e) //evento para perguntar qe quer sair do sistema ao fechar o form
        {
            if (MessageBox.Show("Deseja realmente sair do Sistema?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; //cancela o evento fechar do form
            }
        }

        private void btnPesquisarAluno_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnPesquisarAluno, "Pesquisar Aluno"); //mensagem de informação ao passar o mouse por cima do botão
        }

        private void btnListarAlunos_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnListarAlunos, "Listar todos os alunos"); //mensagem de informação ao passar o mouse por cima do botão
        }

        private void btnNovoAluno_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnNovoAluno, "Cadastrar novo aluno"); //mensagem de informação ao passar o mouse por cima do botão
        }

        private void btnEditarAluno_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnEditarAluno, "Editar o Aluno selecionado"); //mensagem de informação ao passar o mouse por cima do botão
        }

        private void btnExcluirAluno_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnExcluirAluno, "Excluir o Aluno selecionado"); //mensagem de informação ao passar o mouse por cima do botão
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button5, "Cadastrar nova disciplina"); //mensagem de informação ao passar o mouse por cima do botão
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button10, "Cadastrar Semestre"); //mensagem de informação ao passar o mouse por cima do botão
        }
    }
}
