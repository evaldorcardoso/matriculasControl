using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexaoDllMaster;
using Microsoft.Reporting.WinForms;
using System.Collections;


namespace matriculasControl
{
    public partial class frmPrincipal : Form
    {
        public static DataTable dd;//Datatable para disciplinas
        public static DataTable ds;//Datatable para semestres
        public static DataTable dt;//Datatable para alunos
        public static DataTable dm;//Datatable para matriculas
        public static DataTable dmd;//Datatable para matriculas_disciplinas
        public enum eStatusForm { insert, update };
        private eStatusForm statusForm;
        int codAnt;
        int idd;

        public frmPrincipal()
        {
            InitializeComponent();
            carregarDataGrid();
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmAlunosCadastro telaCadastro = new frmAlunosCadastro();
            telaCadastro.Show();
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

        private void btnNovoAluno_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAlunos, "Adicicionar aluno");
        }

        private void btnInserirDisciplina_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnDisciplinas, "Adicionar Disciplina");
        }

        private void carregarComboBox()
        {
            dt = ClsAlunos.listar();
            cbxAluno.DataSource = dt; //carrega comboBox
            cbxAluno.DisplayMember = "nome";
            cbxAluno.ValueMember = "id_aluno";
            cbxAluno.SelectAll();

            dd = ClsDisciplinas.listar();
     
            ds = clsSemestres.listar();
            cbxSemestre.DataSource = ds; //carrega comboBox
            cbxSemestre.DisplayMember = "descricao";
            cbxSemestre.ValueMember = "id";
        }//carrega todos os comboBox

        private void btnInserirSemestre_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnSemestres, "Adicionar Semestre");
        }

        private void carregarDataGrid()
        {
            dm = clsMatriculas.listar2();
            dgvMatriculas.DataSource = dm;//carrega datagridview de matriculas
            dmd = clsMatriculas_Disciplinas.listar();
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            int cont = 0;
            foreach (DataGridViewRow dr in dgvDisciplinas.Rows)
                        {
                            if (Convert.ToBoolean(dgvDisciplinas.Rows[dr.Index].Cells[0].Value))
                                cont++;
                        }
            if (cont == 0)
            {
                MessageBox.Show("Nenhuma disciplina selecionada, nenhuma alteração foi feita no cadastro");
            }
            else
            {
                if (statusForm == eStatusForm.insert)
                {
                    ArrayList listaDeDisciplinas = new ArrayList();
                    foreach (DataGridViewRow dr in dgvDisciplinas.Rows)
                    {
                        if (Convert.ToBoolean(dgvDisciplinas.Rows[dr.Index].Cells[0].Value))
                        {
                            listaDeDisciplinas.Add(dgvDisciplinas.Rows[dr.Index].Cells[1].Value);
                        }
                    }

                    try
                    {
                        clsMatriculas_Disciplinas matriculas_disciplinas = new clsMatriculas_Disciplinas();
                        clsMatriculas matricula = new clsMatriculas(dtpDataDaMatricula.Text, Convert.ToInt32(cbxAluno.SelectedValue), Convert.ToInt32(cbxSemestre.SelectedValue));
                        clsMatriculas.matricular(matricula.data_matricula, matricula.alunos_id_aluno, matricula.semestres_id);
                        
                        for (int i = 0; i < listaDeDisciplinas.Count; i++)
                        {
                            clsMatriculas_Disciplinas.cadastrar(Convert.ToInt32(listaDeDisciplinas[i]));
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show(MessageBoxIcon.Error + "Não foi possivel inserir!");
                    }
                }
                if (statusForm == eStatusForm.update)
                {
                    try
                    {
                        foreach (DataGridViewRow dr in dgvDisciplinas.Rows)
                        {
                            if (Convert.ToBoolean(dgvDisciplinas.Rows[dr.Index].Cells[0].Value))
                            {
                                idd = Convert.ToInt32(dgvDisciplinas.Rows[dr.Index].Cells[1].Value.ToString());
                            }
                        }
                        
                            clsMatriculas.editar(codAnt, Convert.ToInt32(cbxSemestre.SelectedValue), Convert.ToInt32(cbxAluno.SelectedValue), dtpDataDaMatricula.Text);
                            clsMatriculas_Disciplinas.editar(codAnt, idd);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(MessageBoxIcon.Error + "Não foi possivel editar!");
                    }
                }
            }
                acaoMatricula("", false);
                carregarDataGrid();
        }

        private void btnNovaMatricula_Click(object sender, EventArgs e)
        {
            carregarComboBox();
            statusForm = eStatusForm.insert;
            acaoMatricula("Matricular Aluno", true);
            dgvDisciplinas.DataSource = dd;   
            cbxAluno.Focus();
        }

        private void acaoMatricula(string acao, Boolean visibilidade)//seta a visibilidade da opcao matricular
        {

            if (visibilidade == true)//torna inativo os controles enquanto nao finalizar a matrícula
            {
                dgvMatriculas.Enabled = false;
                btnNovaMatricula.Enabled = false;
                btnEditarMatricula.Enabled = false;
                btnExcluirMatricula.Enabled = false;
                btnAlunos.Enabled = false;
                btnDisciplinas.Enabled = false;
                btnSemestres.Enabled = false;
                txtNomeAluno.Enabled = false;
                btnPesquisar.Enabled = false;
                btnListarTodos.Enabled = false;
            }
            else//torna ativo os controles após finalizar a matrícula
            {
                dgvMatriculas.Enabled = true;
                btnNovaMatricula.Enabled = true;
                btnEditarMatricula.Enabled = true;
                btnExcluirMatricula.Enabled = true;
                btnAlunos.Enabled = true;
                btnDisciplinas.Enabled = true;
                btnSemestres.Enabled = true;
                txtNomeAluno.Enabled = true;
                btnPesquisar.Enabled = true;
                btnListarTodos.Enabled = true;
            }
            
            gpxMatriculas.Text = acao;
            gpxMatriculas.Visible = visibilidade;
            lblSelecionarAluno.Visible = visibilidade;
            lblSelSemestre.Visible = visibilidade;
            lblDataMatricula.Visible = visibilidade;
            cbxAluno.Visible = visibilidade;
            dgvDisciplinas.Visible = visibilidade;
            cbxSemestre.Visible = visibilidade;
            dtpDataDaMatricula.Visible = visibilidade;
            btnMatricular.Visible = visibilidade;
            btnCancelar.Visible = visibilidade;
            lblDica.Visible = visibilidade;
            lblDica2.Visible = visibilidade;
        }

        private void btnEditarMatricula_Click(object sender, EventArgs e)
        {
            carregarComboBox();
            dgvDisciplinas.DataSource = dd;
            cbxAluno.SelectedValue = Convert.ToInt32(dm.Rows[dgvMatriculas.CurrentRow.Index]["alunos_id_aluno"].ToString());
            acaoMatricula("Editar Matrícula", true);

            //Seleciona a disciplina que já estava cadastrada
            idd = Convert.ToInt32(dm.Rows[dgvMatriculas.CurrentRow.Index]["disciplinas_id_disciplina"].ToString());
            foreach (DataGridViewRow dr in dgvDisciplinas.Rows)
            {
                if (Convert.ToInt32(dgvDisciplinas.Rows[dr.Index].Cells[1].Value.ToString()) == idd)
                {
                    dgvDisciplinas.Rows[dr.Index].Cells[0].Value = true;
                }
            }
            //seleciona o semestre que ja estava cadastrado
            cbxSemestre.SelectedValue = Convert.ToInt32(dm.Rows[dgvMatriculas.CurrentRow.Index]["semestres_id"].ToString());
            //guarda o id da matricula em edição
            codAnt = Convert.ToInt32(dm.Rows[dgvMatriculas.CurrentRow.Index]["id_matricula"].ToString());
            //carrega a data da matricula já cadastrada
            dtpDataDaMatricula.Text = dm.Rows[dgvMatriculas.CurrentRow.Index]["data_matricula"].ToString();
            statusForm = eStatusForm.update;
            cbxAluno.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            acaoMatricula("", false);
        }

        private void btnExcluirMatricula_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clsMatriculas.excluir(Convert.ToInt32(dm.Rows[dgvMatriculas.CurrentRow.Index]["id_matricula"].ToString()));
                carregarDataGrid();
                carregarComboBox();
            }
        }

        //teclando F9 abre o form de alunos para matricular um aluno
        private void cbxAluno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F9)
            {
                frmAlunosCadastro telaCadastro = new frmAlunosCadastro(frmAlunosCadastro.eStatusForm.search);
                telaCadastro.ShowDialog();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
            
        }

        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            //ao reativar o form seleciona os combobox com a opção vinda da pesquisa no form de alunos ou semestres
            cbxAluno.SelectedValue = frmAlunosCadastro.idAluno;
            cbxSemestre.SelectedValue = frmSemestresCadastro.idSemestre;
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do Sistema?", "", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == 0)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else 
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void dgvMatriculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbAluno.Checked)
                dm = clsMatriculas.pesquisarAluno(txtNomeAluno.Text);
            else
            {
                if (rdbSemestre.Checked)
                    dm = clsMatriculas.pesquisarSemestre(txtNomeAluno.Text);
                else
                    dm = clsMatriculas.pesquisarDisciplina(txtNomeAluno.Text);
            }
            dgvMatriculas.DataSource = dm;
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            dm = clsMatriculas.listar2();
            dgvMatriculas.DataSource = dm;
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (rdbAluno.Checked)
                    dm = clsMatriculas.pesquisarAluno(txtNomeAluno.Text);
                else
                {
                    if (rdbSemestre.Checked)
                        dm = clsMatriculas.pesquisarSemestre(txtNomeAluno.Text);
                    else
                        dm = clsMatriculas.pesquisarDisciplina(txtNomeAluno.Text);
                }
                dgvMatriculas.DataSource = dm;
                e.Handled = true;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmRelatorios relatorio = new frmRelatorios(dm,frmRelatorios.eStatusForm.matriculas);
            relatorio.Show(this);
        }

        private void txtNomeAluno_TextChanged(object sender, EventArgs e)
        {
            if (rdbAluno.Checked)
                dm = clsMatriculas.pesquisarAluno(txtNomeAluno.Text);
            else
            {
                if (rdbSemestre.Checked)
                    dm = clsMatriculas.pesquisarSemestre(txtNomeAluno.Text);
                else
                    dm = clsMatriculas.pesquisarDisciplina(txtNomeAluno.Text);
            }
            dgvMatriculas.DataSource = dm;
        }

        //teclando F9 abre o form de semestres para matricular um aluno
        private void cbxSemestre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F9)
            {
                frmSemestresCadastro telaSemestre = new frmSemestresCadastro(frmSemestresCadastro.eStatusForm.search);
                telaSemestre.ShowDialog();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
        }
        
    }
}
