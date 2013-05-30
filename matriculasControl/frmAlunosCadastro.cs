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
    public partial class frmAlunosCadastro : Form
    {
        public static DataTable dt;
        public static int idAluno=0;

        public enum eStatusForm {inserir,update,search};
        private eStatusForm statusForm;
        int codAnt;
        public frmAlunosCadastro()
        {
            InitializeComponent();
            carregarDataGrid();
        }
        public frmAlunosCadastro(eStatusForm pForm)
        {
            InitializeComponent();
            carregarDataGrid();
            statusForm = pForm;
        }

        public static string _nome;
        public static int _codigo;
        public static string _data_nasc;

        private void carregarDataGrid()
        {
            dt = ClsAlunos.listar();
            dgvAlunos.DataSource = dt;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo Nome não pode estar vazio!");
            }
            else
            {
                if (statusForm == eStatusForm.inserir)
                {
                    
                    try
                    {
                        ClsAlunos aluno = new ClsAlunos(txtNome.Text, dtpDataNasc.Text);
                        ClsAlunos.inserir(aluno.nome,aluno.data_nasc);
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
                        _nome = txtNome.Text;
                        _data_nasc = dtpDataNasc.Text;
                        ClsAlunos.editar(codAnt, _nome, _data_nasc);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(MessageBoxIcon.Error + "Não foi possivel editar!");
                    }
                }
                acaoAluno("", false);
                carregarDataGrid();
            }
        }

        private void acaoAluno(string acao, Boolean visibilidade)//seta a visibilidade da opcao matricular
        {
            
            if (visibilidade == true)//torna inativo os controles enquanto nao finalizar a matrícula
            {
                dgvAlunos.Enabled = false;
                btnNovoAluno.Enabled = false;
                btnEditarAluno.Enabled = false;
                btnExcluirAluno.Enabled = false;
                btnPesquisarAluno.Enabled = false;
                btnListarAlunos.Enabled = false;
                txtNomeAluno.Enabled = false;
                txtNome.SelectAll();
            }
            else//torna ativo os controles após finalizar a matrícula
            {
                dgvAlunos.Enabled = true;
                btnNovoAluno.Enabled = true;
                btnEditarAluno.Enabled = true;
                btnExcluirAluno.Enabled = true;
                btnPesquisarAluno.Enabled = true;
                btnListarAlunos.Enabled = true;
                txtNomeAluno.Enabled = true;
            }

            gpxAcaoAluno.Text = acao;
            gpxAcaoAluno.Visible = visibilidade;
            lblNome.Visible = visibilidade;
            lblDataNasc.Visible = visibilidade;
            btnSalvar.Visible = visibilidade;
            btnCancelar.Visible = visibilidade;
            txtNome.Visible = visibilidade;
            if (statusForm == eStatusForm.inserir)
            {
                txtNome.Text = "";
                dtpDataNasc.ResetText();
            }
            dtpDataNasc.Visible = visibilidade;
            
            
        }

        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            txtNome.Text = dt.Rows[dgvAlunos.CurrentRow.Index]["nome"].ToString();
            dtpDataNasc.Text = dt.Rows[dgvAlunos.CurrentRow.Index]["data_nasc"].ToString();
            codAnt =Convert.ToInt32(dt.Rows[dgvAlunos.CurrentRow.Index]["id_aluno"].ToString());
            statusForm = eStatusForm.update;
            acaoAluno("Editar Aluno", true);
            txtNome.Focus();
            
        }

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ClsAlunos.cod = Convert.ToInt32(dt.Rows[dgvAlunos.CurrentRow.Index]["id_aluno"]);
                ClsAlunos.excluir(ClsAlunos.cod);
                carregarDataGrid();
            }
        }

        private void btnNovoAluno_Click(object sender, EventArgs e)
        {
            acaoAluno("Cadastrar Aluno", true);
            statusForm = eStatusForm.inserir;
            txtNome.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisarAluno_Click(object sender, EventArgs e)
        {
            dt = ClsAlunos.pesquisar(txtNomeAluno.Text);
            dgvAlunos.DataSource = dt;
        }

        private void btnListarAlunos_Click(object sender, EventArgs e)
        {
            carregarDataGrid();
            txtNomeAluno.Clear();
        }

        //mandar aluno escolhido para o form principal ao pressionar enter para matricular
        private void dgvAlunos_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter)&&(statusForm==eStatusForm.search))
            {
                idAluno=Convert.ToInt32((dt.Rows[dgvAlunos.CurrentRow.Index]["id_aluno"].ToString()));
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            acaoAluno("", false);
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

        private void txtNomeAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                dt = ClsAlunos.pesquisar(txtNomeAluno.Text);
                dgvAlunos.DataSource = dt;
                e.Handled = true;
            }
        }

        private void btmImprimir_Click(object sender, EventArgs e)
        {
            frmRelatorios relatorios = new frmRelatorios(dt,frmRelatorios.eStatusForm.alunos);
            relatorios.Show(this);
        }

        private void dgvAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(statusForm==eStatusForm.search)
            {
                idAluno=Convert.ToInt32((dt.Rows[dgvAlunos.CurrentRow.Index]["id_aluno"].ToString()));
                Close();
            }
        }
    }

}
