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
    public partial class frmDisciplinasCadastro : Form
    {
        public static DataTable dd;
        public enum eStatusForm { insert, update };
        private eStatusForm statusForm;
        int codAnt;

        public frmDisciplinasCadastro()
        {
            InitializeComponent();
            carregarDataGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            acaoDisciplina("", false);
        }

        private void carregarDataGrid()
        {
            dd = ClsDisciplinas.listar();
            dgvDisciplinas.DataSource = dd;
        }

        private void acaoDisciplina(string acao, Boolean visibilidade)//seta a visibilidade da acao das disciplinas
        {

            if (visibilidade == true)//torna inativo os controles enquanto nao finalizar a matrícula
            {
                dgvDisciplinas.Enabled = false;
                btnInserirDisciplina.Enabled = false;
                btnEditarDisciplina.Enabled = false;
                btnExcluirDisciplina.Enabled = false;
                btnPesquisarDisciplina.Enabled = false;
                btnListarDisciplinas.Enabled = false;
                txtNomeDisciplina.Enabled = false;
            }
            else//torna ativo os controles após finalizar a matrícula
            {
                dgvDisciplinas.Enabled = true;
                btnInserirDisciplina.Enabled = true;
                btnEditarDisciplina.Enabled = true;
                btnExcluirDisciplina.Enabled = true;
                btnPesquisarDisciplina.Enabled = true;
                btnListarDisciplinas.Enabled = true;
                txtNomeDisciplina.Enabled = true;
            }

            gpxAcaoDisciplina.Text = acao;
            gpxAcaoDisciplina.Visible = visibilidade;
            lblNome.Visible = visibilidade;
            btnSalvar.Visible = visibilidade;
            btnCancelar.Visible = visibilidade;
            txtNome.Visible = visibilidade;
            if (statusForm == eStatusForm.insert)
            {
                txtNome.Text = "";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
                MessageBox.Show("Campo Descrição não pode ser vazio!");
            else
                {
                    if (statusForm == eStatusForm.insert)
                    {
                        try
                        {
                            ClsDisciplinas disciplina = new ClsDisciplinas(txtNome.Text);
                            ClsDisciplinas.inserir(disciplina.ddescricao);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show(MessageBoxIcon.Error + "Não foi possivel inserir!");
                        }
                    }
                    if (statusForm == eStatusForm.update)
                    {
                        string _descricao;
                        try
                        {
                            _descricao = txtNome.Text;
                            ClsDisciplinas.editar(codAnt , _descricao);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show(MessageBoxIcon.Error + "Não foi possivel editar!");
                        }
                    }
                    acaoDisciplina("", false);
                    carregarDataGrid();
                }
        }

        private void btnEditarDisciplina_Click(object sender, EventArgs e)
        {
            txtNome.Text= dd.Rows[dgvDisciplinas.CurrentRow.Index]["ddescricao"].ToString();
            codAnt =Convert.ToInt32(dd.Rows[dgvDisciplinas.CurrentRow.Index]["id_disciplina"].ToString());
            statusForm = eStatusForm.update;
            acaoDisciplina("Editar Disciplina", true);
            txtNome.Focus();
        }

        private void btnInserirDisciplina_Click(object sender, EventArgs e)
        {
            statusForm = eStatusForm.insert;
            acaoDisciplina("Cadastrar Disciplina", true);
            txtNome.Focus();
        }

        private void btnPesquisarDisciplina_Click(object sender, EventArgs e)
        {
            dd = ClsDisciplinas.pesquisar(txtNomeDisciplina.Text);
            dgvDisciplinas.DataSource = dd;
        }

        private void btnListarDisciplinas_Click(object sender, EventArgs e)
        {
            carregarDataGrid();
            txtNomeDisciplina.Clear();
        }

        private void btnExcluirDisciplina_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ClsDisciplinas.excluir(Convert.ToInt32(dd.Rows[dgvDisciplinas.CurrentRow.Index]["id_disciplina"]));
                carregarDataGrid();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            acaoDisciplina("", false);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomeDisciplina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                dd = ClsDisciplinas.pesquisar(txtNomeDisciplina.Text);
                dgvDisciplinas.DataSource = dd;
                e.Handled = true;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmRelatorios telaRelatorios = new frmRelatorios(dd, frmRelatorios.eStatusForm.disciplinas);
            telaRelatorios.Show();
        }

    }
}
