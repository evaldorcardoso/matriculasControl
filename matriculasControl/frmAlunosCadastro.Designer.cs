namespace matriculasControl
{
    partial class frmAlunosCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btmImprimir = new System.Windows.Forms.Button();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.gpxPesquisarAluno = new System.Windows.Forms.GroupBox();
            this.btnPesquisarAluno = new System.Windows.Forms.Button();
            this.btnListarAlunos = new System.Windows.Forms.Button();
            this.gpxAcoes = new System.Windows.Forms.GroupBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnNovoAluno = new System.Windows.Forms.Button();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.btnEditarAluno = new System.Windows.Forms.Button();
            this.gpxAcaoAluno = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.idalunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsAlunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.gpxPesquisarAluno.SuspendLayout();
            this.gpxAcoes.SuspendLayout();
            this.gpxAcaoAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsAlunosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(138, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(314, 26);
            this.txtNome.TabIndex = 3;
            this.txtNome.Visible = false;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.Location = new System.Drawing.Point(138, 64);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(158, 20);
            this.lblDataNasc.TabIndex = 4;
            this.lblDataNasc.Text = "Data de Nascimento:";
            this.lblDataNasc.Visible = false;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNasc.Location = new System.Drawing.Point(138, 85);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(311, 26);
            this.dtpDataNasc.TabIndex = 5;
            this.dtpDataNasc.Visible = false;
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.AutoGenerateColumns = false;
            this.dgvAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlunos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalunoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.datanascDataGridViewTextBoxColumn});
            this.dgvAlunos.DataSource = this.clsAlunosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlunos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlunos.Location = new System.Drawing.Point(200, 285);
            this.dgvAlunos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.RowHeadersVisible = false;
            this.dgvAlunos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunos.Size = new System.Drawing.Size(1137, 401);
            this.dgvAlunos.TabIndex = 9;
            this.dgvAlunos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellDoubleClick);
            this.dgvAlunos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAlunos_KeyDown);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(138, 14);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome:";
            this.lblNome.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(179, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1165, 439);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alunos Cadastrados:";
            // 
            // btmImprimir
            // 
            this.btmImprimir.BackColor = System.Drawing.Color.CadetBlue;
            this.btmImprimir.BackgroundImage = global::matriculasControl.Properties.Resources.print_256;
            this.btmImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btmImprimir.FlatAppearance.BorderSize = 0;
            this.btmImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btmImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmImprimir.Location = new System.Drawing.Point(30, 391);
            this.btmImprimir.Name = "btmImprimir";
            this.btmImprimir.Size = new System.Drawing.Size(94, 69);
            this.btmImprimir.TabIndex = 0;
            this.btmImprimir.UseVisualStyleBackColor = false;
            this.btmImprimir.Click += new System.EventHandler(this.btmImprimir_Click);
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.BackColor = System.Drawing.Color.PowderBlue;
            this.txtNomeAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(10, 45);
            this.txtNomeAluno.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(923, 22);
            this.txtNomeAluno.TabIndex = 16;
            this.txtNomeAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeAluno_KeyPress);
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAluno.ForeColor = System.Drawing.Color.Black;
            this.lblNomeAluno.Location = new System.Drawing.Point(6, 20);
            this.lblNomeAluno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(55, 20);
            this.lblNomeAluno.TabIndex = 15;
            this.lblNomeAluno.Text = "Nome:";
            // 
            // gpxPesquisarAluno
            // 
            this.gpxPesquisarAluno.Controls.Add(this.txtNomeAluno);
            this.gpxPesquisarAluno.Controls.Add(this.btnPesquisarAluno);
            this.gpxPesquisarAluno.Controls.Add(this.lblNomeAluno);
            this.gpxPesquisarAluno.Controls.Add(this.btnListarAlunos);
            this.gpxPesquisarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxPesquisarAluno.ForeColor = System.Drawing.Color.White;
            this.gpxPesquisarAluno.Location = new System.Drawing.Point(179, 154);
            this.gpxPesquisarAluno.Name = "gpxPesquisarAluno";
            this.gpxPesquisarAluno.Size = new System.Drawing.Size(1165, 94);
            this.gpxPesquisarAluno.TabIndex = 17;
            this.gpxPesquisarAluno.TabStop = false;
            this.gpxPesquisarAluno.Text = "Pesquisar:";
            // 
            // btnPesquisarAluno
            // 
            this.btnPesquisarAluno.AccessibleDescription = "Pesquisar";
            this.btnPesquisarAluno.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPesquisarAluno.BackgroundImage = global::matriculasControl.Properties.Resources.search_512;
            this.btnPesquisarAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarAluno.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnPesquisarAluno.FlatAppearance.BorderSize = 0;
            this.btnPesquisarAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnPesquisarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarAluno.Location = new System.Drawing.Point(953, 20);
            this.btnPesquisarAluno.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarAluno.Name = "btnPesquisarAluno";
            this.btnPesquisarAluno.Size = new System.Drawing.Size(94, 59);
            this.btnPesquisarAluno.TabIndex = 2;
            this.btnPesquisarAluno.UseVisualStyleBackColor = false;
            this.btnPesquisarAluno.Click += new System.EventHandler(this.btnPesquisarAluno_Click);
            // 
            // btnListarAlunos
            // 
            this.btnListarAlunos.BackColor = System.Drawing.Color.CadetBlue;
            this.btnListarAlunos.BackgroundImage = global::matriculasControl.Properties.Resources.refresh_512_;
            this.btnListarAlunos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListarAlunos.FlatAppearance.BorderSize = 0;
            this.btnListarAlunos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnListarAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarAlunos.Location = new System.Drawing.Point(1055, 20);
            this.btnListarAlunos.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarAlunos.Name = "btnListarAlunos";
            this.btnListarAlunos.Size = new System.Drawing.Size(94, 59);
            this.btnListarAlunos.TabIndex = 7;
            this.btnListarAlunos.UseVisualStyleBackColor = false;
            this.btnListarAlunos.Click += new System.EventHandler(this.btnListarAlunos_Click);
            // 
            // gpxAcoes
            // 
            this.gpxAcoes.Controls.Add(this.btnVoltar);
            this.gpxAcoes.Controls.Add(this.btnNovoAluno);
            this.gpxAcoes.Controls.Add(this.btnExcluirAluno);
            this.gpxAcoes.Controls.Add(this.btnEditarAluno);
            this.gpxAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxAcoes.ForeColor = System.Drawing.Color.White;
            this.gpxAcoes.Location = new System.Drawing.Point(3, 154);
            this.gpxAcoes.Name = "gpxAcoes";
            this.gpxAcoes.Size = new System.Drawing.Size(154, 539);
            this.gpxAcoes.TabIndex = 12;
            this.gpxAcoes.TabStop = false;
            this.gpxAcoes.Text = "Ações:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnVoltar.BackgroundImage = global::matriculasControl.Properties.Resources.undo_256;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(27, 313);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(94, 59);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnNovoAluno
            // 
            this.btnNovoAluno.BackColor = System.Drawing.Color.CadetBlue;
            this.btnNovoAluno.BackgroundImage = global::matriculasControl.Properties.Resources.add_user_512;
            this.btnNovoAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovoAluno.FlatAppearance.BorderSize = 0;
            this.btnNovoAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnNovoAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoAluno.Location = new System.Drawing.Point(27, 40);
            this.btnNovoAluno.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovoAluno.Name = "btnNovoAluno";
            this.btnNovoAluno.Size = new System.Drawing.Size(94, 59);
            this.btnNovoAluno.TabIndex = 12;
            this.btnNovoAluno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovoAluno.UseVisualStyleBackColor = false;
            this.btnNovoAluno.Click += new System.EventHandler(this.btnNovoAluno_Click);
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExcluirAluno.BackgroundImage = global::matriculasControl.Properties.Resources.remove_user_512;
            this.btnExcluirAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluirAluno.FlatAppearance.BorderSize = 0;
            this.btnExcluirAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnExcluirAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirAluno.Location = new System.Drawing.Point(27, 173);
            this.btnExcluirAluno.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(94, 57);
            this.btnExcluirAluno.TabIndex = 14;
            this.btnExcluirAluno.UseVisualStyleBackColor = false;
            this.btnExcluirAluno.Click += new System.EventHandler(this.btnExcluirAluno_Click);
            // 
            // btnEditarAluno
            // 
            this.btnEditarAluno.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEditarAluno.BackgroundImage = global::matriculasControl.Properties.Resources.edit_user_512_;
            this.btnEditarAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditarAluno.FlatAppearance.BorderSize = 0;
            this.btnEditarAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAluno.Location = new System.Drawing.Point(27, 106);
            this.btnEditarAluno.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.Size = new System.Drawing.Size(94, 59);
            this.btnEditarAluno.TabIndex = 13;
            this.btnEditarAluno.UseVisualStyleBackColor = false;
            this.btnEditarAluno.Click += new System.EventHandler(this.btnEditarAluno_Click);
            // 
            // gpxAcaoAluno
            // 
            this.gpxAcaoAluno.Controls.Add(this.btnCancelar);
            this.gpxAcaoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxAcaoAluno.ForeColor = System.Drawing.Color.White;
            this.gpxAcaoAluno.Location = new System.Drawing.Point(3, 3);
            this.gpxAcaoAluno.Name = "gpxAcaoAluno";
            this.gpxAcaoAluno.Size = new System.Drawing.Size(621, 145);
            this.gpxAcaoAluno.TabIndex = 18;
            this.gpxAcaoAluno.TabStop = false;
            this.gpxAcaoAluno.Text = "Cadastrar:";
            this.gpxAcaoAluno.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCancelar.BackgroundImage = global::matriculasControl.Properties.Resources.delete_256;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(489, 82);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 46);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.Location = new System.Drawing.Point(1266, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(37, 33);
            this.btnMaximize.TabIndex = 48;
            this.btnMaximize.Text = "[]";
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(1309, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(37, 33);
            this.btnFechar.TabIndex = 47;
            this.btnFechar.Text = "x";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(1223, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 33);
            this.btnMinimize.TabIndex = 46;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::matriculasControl.Properties.Resources.user_256;
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSalvar.BackgroundImage = global::matriculasControl.Properties.Resources.checkmark_256;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnSalvar.Location = new System.Drawing.Point(492, 17);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 46);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::matriculasControl.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(630, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(610, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // idalunoDataGridViewTextBoxColumn
            // 
            this.idalunoDataGridViewTextBoxColumn.DataPropertyName = "id_aluno";
            this.idalunoDataGridViewTextBoxColumn.HeaderText = "Código:";
            this.idalunoDataGridViewTextBoxColumn.Name = "idalunoDataGridViewTextBoxColumn";
            this.idalunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idalunoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idalunoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome do Aluno:";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // datanascDataGridViewTextBoxColumn
            // 
            this.datanascDataGridViewTextBoxColumn.DataPropertyName = "data_nasc";
            this.datanascDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento:";
            this.datanascDataGridViewTextBoxColumn.Name = "datanascDataGridViewTextBoxColumn";
            this.datanascDataGridViewTextBoxColumn.ReadOnly = true;
            this.datanascDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clsAlunosBindingSource
            // 
            this.clsAlunosBindingSource.DataSource = typeof(matriculasControl.ClsAlunos);
            // 
            // frmAlunosCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1350, 699);
            this.Controls.Add(this.btmImprimir);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.gpxPesquisarAluno);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpxAcoes);
            this.Controls.Add(this.gpxAcaoAluno);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmAlunosCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.gpxPesquisarAluno.ResumeLayout(false);
            this.gpxPesquisarAluno.PerformLayout();
            this.gpxAcoes.ResumeLayout(false);
            this.gpxAcaoAluno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsAlunosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource clsAlunosBindingSource;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.Button btnEditarAluno;
        private System.Windows.Forms.Button btnNovoAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.GroupBox gpxPesquisarAluno;
        private System.Windows.Forms.Button btnPesquisarAluno;
        private System.Windows.Forms.Button btnListarAlunos;
        private System.Windows.Forms.GroupBox gpxAcoes;
        private System.Windows.Forms.GroupBox gpxAcaoAluno;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btmImprimir;
    }
}