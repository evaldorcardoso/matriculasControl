using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matriculasControl
{
    public partial class frmSemestresCadastro : Form
    {
        public static DataTable ds;
        public enum eStatusForm { insert, update, search };
        private eStatusForm statusForm;
        int codAnt;
        public static int idSemestre = 0;


        public frmSemestresCadastro()
        {
            InitializeComponent();
            carregarDataGrid();
        }

        public frmSemestresCadastro(eStatusForm pForm)
        {
            InitializeComponent();
            carregarDataGrid();
            statusForm = pForm;
        }

        private void carregarDataGrid()
        {
            ds = clsSemestres.listar();
            dgvSemestres.DataSource = ds;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            acaoSemestre("", false);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
                MessageBox.Show("Campo Descrição não pode estar vazio!");
            else
            {
                if (statusForm == eStatusForm.insert)
                {
                    try
                    {
                        clsSemestres semestre = new clsSemestres(txtNome.Text);
                        clsSemestres.inserir(semestre.descricao);
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
                        clsSemestres.editar(codAnt,_descricao);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(MessageBoxIcon.Error + "Não foi possivel editar!");
                    }
                }
                acaoSemestre("", false);
                carregarDataGrid();
            }
        }

        private void btnEditarSemestre_Click(object sender, EventArgs e)
        {
            txtNome.Text = ds.Rows[dgvSemestres.CurrentRow.Index]["descricao"].ToString();
            codAnt = Convert.ToInt32(ds.Rows[dgvSemestres.CurrentRow.Index]["id"].ToString());
            statusForm = eStatusForm.update;
            acaoSemestre("Editar Semestre", true);
            txtNome.Focus();
        }

        private void acaoSemestre(string acao, Boolean visibilidade)//seta a visibilidade da acao do semestre
        {

            if (visibilidade == true)//torna inativo os controles enquanto nao finalizar a matrícula
            {
                dgvSemestres.Enabled = false;
                btnInserirSemestre.Enabled = false;
                btnEditarSemestre.Enabled = false;
                btnExcluirSemestre.Enabled = false;
                btnPesquisarSemestre.Enabled = false;
                btnListarSemestre.Enabled = false;
                txtNomeSemestre.Enabled = false;
            }
            else//torna ativo os controles após finalizar a matrícula
            {
                dgvSemestres.Enabled = true;
                btnInserirSemestre.Enabled = true;
                btnEditarSemestre.Enabled = true;
                btnExcluirSemestre.Enabled = true;
                btnPesquisarSemestre.Enabled = true;
                btnListarSemestre.Enabled = true;
                txtNomeSemestre.Enabled = true;
            }

            gpxAcaoSemestre.Text = acao;
            gpxAcaoSemestre.Visible = visibilidade;
            lblNome.Visible = visibilidade;
            btnSalvar.Visible = visibilidade;
            txtNome.Visible = visibilidade;
            if (statusForm == eStatusForm.insert)
            {
                txtNome.Text = "";
            }
        }

        private void btnInserirSemestre_Click(object sender, EventArgs e)
        {
            statusForm = eStatusForm.insert;
            acaoSemestre("Cadastrar Semestre", true);
            txtNome.Focus();
        }

        private void btnPesquisarSemestre_Click(object sender, EventArgs e)
        {
            ds = clsSemestres.pesquisar(txtNomeSemestre.Text);
            dgvSemestres.DataSource = ds;
        }

        private void btnListarSemestre_Click(object sender, EventArgs e)
        {
            ds = clsSemestres.listar();
            dgvSemestres.DataSource = ds;
            txtNomeSemestre.Clear();
        }

        private void btnExcluirSemestre_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clsSemestres.excluir(Convert.ToInt32(ds.Rows[dgvSemestres.CurrentRow.Index]["id"]));
                carregarDataGrid();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelarr_Click(object sender, EventArgs e)
        {
            acaoSemestre("", false);
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
            Close();
        }

        private void txtNomeSemestre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                ds = clsSemestres.pesquisar(txtNomeSemestre.Text);
                dgvSemestres.DataSource = ds;
                e.Handled = true;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (txtNome.Text == "")
                    MessageBox.Show("Campo Descrição não pode estar vazio!");
                else
                {
                    if (statusForm == eStatusForm.insert)
                    {
                        try
                        {
                            clsSemestres semestre = new clsSemestres(txtNome.Text);
                            clsSemestres.inserir(semestre.descricao);
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
                            clsSemestres.editar(codAnt, _descricao);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show(MessageBoxIcon.Error + "Não foi possivel editar!");
                        }
                    }
                    acaoSemestre("", false);
                    carregarDataGrid();
                }
                e.Handled = true;
            }
        }

        //mandar semestre escolhido para o form principal ao pressionar enter para matricular
        private void dgvSemestres_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter) && (statusForm == eStatusForm.search))
            {
                idSemestre = Convert.ToInt32((ds.Rows[dgvSemestres.CurrentRow.Index]["id"].ToString()));
                Close();
            }
        }

        private void dgvSemestres_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(statusForm == eStatusForm.search)
            {
                idSemestre = Convert.ToInt32((ds.Rows[dgvSemestres.CurrentRow.Index]["id"].ToString()));
                Close();
            }
        }
       
    }
}
