namespace matriculasControl
{
    partial class frmDisciplinasCadastro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.dgvDisciplinas = new System.Windows.Forms.DataGridView();
            this.ddescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpxAcaoDisciplina = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNomeDisciplina = new System.Windows.Forms.TextBox();
            this.lblDescricaoPesquisar = new System.Windows.Forms.Label();
            this.gpxPesquisar = new System.Windows.Forms.GroupBox();
            this.btnPesquisarDisciplina = new System.Windows.Forms.Button();
            this.btnListarDisciplinas = new System.Windows.Forms.Button();
            this.gpxAcoes = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExcluirDisciplina = new System.Windows.Forms.Button();
            this.btnEditarDisciplina = new System.Windows.Forms.Button();
            this.btnInserirDisciplina = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.iddisciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsDisciplinasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinas)).BeginInit();
            this.gpxAcaoDisciplina.SuspendLayout();
            this.gpxPesquisar.SuspendLayout();
            this.gpxAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDisciplinasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(138, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(314, 26);
            this.txtNome.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(138, 14);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(84, 20);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Descrição:";
            // 
            // dgvDisciplinas
            // 
            this.dgvDisciplinas.AllowUserToAddRows = false;
            this.dgvDisciplinas.AllowUserToDeleteRows = false;
            this.dgvDisciplinas.AutoGenerateColumns = false;
            this.dgvDisciplinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisciplinas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisciplinas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddisciplinaDataGridViewTextBoxColumn,
            this.ddescricao});
            this.dgvDisciplinas.DataSource = this.clsDisciplinasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisciplinas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDisciplinas.Location = new System.Drawing.Point(200, 285);
            this.dgvDisciplinas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDisciplinas.Name = "dgvDisciplinas";
            this.dgvDisciplinas.ReadOnly = true;
            this.dgvDisciplinas.RowHeadersVisible = false;
            this.dgvDisciplinas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDisciplinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisciplinas.Size = new System.Drawing.Size(1137, 401);
            this.dgvDisciplinas.TabIndex = 19;
            // 
            // ddescricao
            // 
            this.ddescricao.DataPropertyName = "ddescricao";
            this.ddescricao.HeaderText = "Descrição:";
            this.ddescricao.Name = "ddescricao";
            this.ddescricao.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(179, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1165, 439);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disciplinas Cadastradas:";
            // 
            // gpxAcaoDisciplina
            // 
            this.gpxAcaoDisciplina.Controls.Add(this.txtNome);
            this.gpxAcaoDisciplina.Controls.Add(this.lblNome);
            this.gpxAcaoDisciplina.Controls.Add(this.btnSalvar);
            this.gpxAcaoDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxAcaoDisciplina.ForeColor = System.Drawing.Color.White;
            this.gpxAcaoDisciplina.Location = new System.Drawing.Point(3, 3);
            this.gpxAcaoDisciplina.Name = "gpxAcaoDisciplina";
            this.gpxAcaoDisciplina.Size = new System.Drawing.Size(621, 145);
            this.gpxAcaoDisciplina.TabIndex = 28;
            this.gpxAcaoDisciplina.TabStop = false;
            this.gpxAcaoDisciplina.Text = "Cadastrar:";
            this.gpxAcaoDisciplina.Visible = false;
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
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNomeDisciplina
            // 
            this.txtNomeDisciplina.BackColor = System.Drawing.Color.PowderBlue;
            this.txtNomeDisciplina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDisciplina.Location = new System.Drawing.Point(10, 45);
            this.txtNomeDisciplina.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeDisciplina.Name = "txtNomeDisciplina";
            this.txtNomeDisciplina.Size = new System.Drawing.Size(923, 22);
            this.txtNomeDisciplina.TabIndex = 31;
            this.txtNomeDisciplina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeDisciplina_KeyPress);
            // 
            // lblDescricaoPesquisar
            // 
            this.lblDescricaoPesquisar.AutoSize = true;
            this.lblDescricaoPesquisar.ForeColor = System.Drawing.Color.Black;
            this.lblDescricaoPesquisar.Location = new System.Drawing.Point(6, 20);
            this.lblDescricaoPesquisar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricaoPesquisar.Name = "lblDescricaoPesquisar";
            this.lblDescricaoPesquisar.Size = new System.Drawing.Size(84, 20);
            this.lblDescricaoPesquisar.TabIndex = 30;
            this.lblDescricaoPesquisar.Text = "Descrição:";
            // 
            // gpxPesquisar
            // 
            this.gpxPesquisar.Controls.Add(this.txtNomeDisciplina);
            this.gpxPesquisar.Controls.Add(this.btnPesquisarDisciplina);
            this.gpxPesquisar.Controls.Add(this.lblDescricaoPesquisar);
            this.gpxPesquisar.Controls.Add(this.btnListarDisciplinas);
            this.gpxPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxPesquisar.ForeColor = System.Drawing.Color.White;
            this.gpxPesquisar.Location = new System.Drawing.Point(179, 154);
            this.gpxPesquisar.Name = "gpxPesquisar";
            this.gpxPesquisar.Size = new System.Drawing.Size(1165, 94);
            this.gpxPesquisar.TabIndex = 32;
            this.gpxPesquisar.TabStop = false;
            this.gpxPesquisar.Text = "Pesquisar:";
            // 
            // btnPesquisarDisciplina
            // 
            this.btnPesquisarDisciplina.AccessibleDescription = "Pesquisar";
            this.btnPesquisarDisciplina.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPesquisarDisciplina.BackgroundImage = global::matriculasControl.Properties.Resources.search_512;
            this.btnPesquisarDisciplina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarDisciplina.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnPesquisarDisciplina.FlatAppearance.BorderSize = 0;
            this.btnPesquisarDisciplina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnPesquisarDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarDisciplina.Location = new System.Drawing.Point(953, 20);
            this.btnPesquisarDisciplina.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarDisciplina.Name = "btnPesquisarDisciplina";
            this.btnPesquisarDisciplina.Size = new System.Drawing.Size(94, 59);
            this.btnPesquisarDisciplina.TabIndex = 2;
            this.btnPesquisarDisciplina.UseVisualStyleBackColor = false;
            this.btnPesquisarDisciplina.Click += new System.EventHandler(this.btnPesquisarDisciplina_Click);
            // 
            // btnListarDisciplinas
            // 
            this.btnListarDisciplinas.BackColor = System.Drawing.Color.CadetBlue;
            this.btnListarDisciplinas.BackgroundImage = global::matriculasControl.Properties.Resources.refresh_512_;
            this.btnListarDisciplinas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListarDisciplinas.FlatAppearance.BorderSize = 0;
            this.btnListarDisciplinas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnListarDisciplinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarDisciplinas.Location = new System.Drawing.Point(1055, 20);
            this.btnListarDisciplinas.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarDisciplinas.Name = "btnListarDisciplinas";
            this.btnListarDisciplinas.Size = new System.Drawing.Size(94, 59);
            this.btnListarDisciplinas.TabIndex = 7;
            this.btnListarDisciplinas.UseVisualStyleBackColor = false;
            this.btnListarDisciplinas.Click += new System.EventHandler(this.btnListarDisciplinas_Click);
            // 
            // gpxAcoes
            // 
            this.gpxAcoes.Controls.Add(this.btnImprimir);
            this.gpxAcoes.Controls.Add(this.btnVoltar);
            this.gpxAcoes.Controls.Add(this.btnExcluirDisciplina);
            this.gpxAcoes.Controls.Add(this.btnEditarDisciplina);
            this.gpxAcoes.Controls.Add(this.btnInserirDisciplina);
            this.gpxAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxAcoes.ForeColor = System.Drawing.Color.White;
            this.gpxAcoes.Location = new System.Drawing.Point(3, 154);
            this.gpxAcoes.Name = "gpxAcoes";
            this.gpxAcoes.Size = new System.Drawing.Size(154, 539);
            this.gpxAcoes.TabIndex = 33;
            this.gpxAcoes.TabStop = false;
            this.gpxAcoes.Text = "Ações:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.CadetBlue;
            this.btnImprimir.BackgroundImage = global::matriculasControl.Properties.Resources.print_256;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(27, 240);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(94, 59);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
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
            this.btnVoltar.Location = new System.Drawing.Point(27, 311);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(94, 59);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnExcluirDisciplina
            // 
            this.btnExcluirDisciplina.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExcluirDisciplina.BackgroundImage = global::matriculasControl.Properties.Resources.Delete_document_512;
            this.btnExcluirDisciplina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluirDisciplina.FlatAppearance.BorderSize = 0;
            this.btnExcluirDisciplina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnExcluirDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirDisciplina.Location = new System.Drawing.Point(27, 173);
            this.btnExcluirDisciplina.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirDisciplina.Name = "btnExcluirDisciplina";
            this.btnExcluirDisciplina.Size = new System.Drawing.Size(94, 59);
            this.btnExcluirDisciplina.TabIndex = 12;
            this.btnExcluirDisciplina.UseVisualStyleBackColor = false;
            this.btnExcluirDisciplina.Click += new System.EventHandler(this.btnExcluirDisciplina_Click);
            // 
            // btnEditarDisciplina
            // 
            this.btnEditarDisciplina.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEditarDisciplina.BackgroundImage = global::matriculasControl.Properties.Resources.Edit_document_512;
            this.btnEditarDisciplina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditarDisciplina.FlatAppearance.BorderSize = 0;
            this.btnEditarDisciplina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarDisciplina.Location = new System.Drawing.Point(27, 106);
            this.btnEditarDisciplina.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarDisciplina.Name = "btnEditarDisciplina";
            this.btnEditarDisciplina.Size = new System.Drawing.Size(94, 59);
            this.btnEditarDisciplina.TabIndex = 11;
            this.btnEditarDisciplina.UseVisualStyleBackColor = false;
            this.btnEditarDisciplina.Click += new System.EventHandler(this.btnEditarDisciplina_Click);
            // 
            // btnInserirDisciplina
            // 
            this.btnInserirDisciplina.BackColor = System.Drawing.Color.CadetBlue;
            this.btnInserirDisciplina.BackgroundImage = global::matriculasControl.Properties.Resources.Add_document_256;
            this.btnInserirDisciplina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInserirDisciplina.FlatAppearance.BorderSize = 0;
            this.btnInserirDisciplina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInserirDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirDisciplina.Location = new System.Drawing.Point(27, 40);
            this.btnInserirDisciplina.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserirDisciplina.Name = "btnInserirDisciplina";
            this.btnInserirDisciplina.Size = new System.Drawing.Size(94, 59);
            this.btnInserirDisciplina.TabIndex = 10;
            this.btnInserirDisciplina.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInserirDisciplina.UseVisualStyleBackColor = false;
            this.btnInserirDisciplina.Click += new System.EventHandler(this.btnInserirDisciplina_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::matriculasControl.Properties.Resources.document_512;
            this.pictureBox1.Location = new System.Drawing.Point(27, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::matriculasControl.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(630, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(610, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(495, 80);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 46);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.Location = new System.Drawing.Point(1265, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(37, 33);
            this.btnMaximize.TabIndex = 45;
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
            this.btnFechar.Location = new System.Drawing.Point(1308, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(37, 33);
            this.btnFechar.TabIndex = 44;
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
            this.btnMinimize.Location = new System.Drawing.Point(1222, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 33);
            this.btnMinimize.TabIndex = 43;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // iddisciplinaDataGridViewTextBoxColumn
            // 
            this.iddisciplinaDataGridViewTextBoxColumn.DataPropertyName = "id_disciplina";
            this.iddisciplinaDataGridViewTextBoxColumn.HeaderText = "Código:";
            this.iddisciplinaDataGridViewTextBoxColumn.Name = "iddisciplinaDataGridViewTextBoxColumn";
            this.iddisciplinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddisciplinaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.iddisciplinaDataGridViewTextBoxColumn.Visible = false;
            // 
            // clsDisciplinasBindingSource
            // 
            this.clsDisciplinasBindingSource.DataSource = typeof(matriculasControl.ClsDisciplinas);
            // 
            // frmDisciplinasCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1350, 699);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpxAcoes);
            this.Controls.Add(this.gpxPesquisar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gpxAcaoDisciplina);
            this.Controls.Add(this.dgvDisciplinas);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDisciplinasCadastro";
            this.Text = "Disciplina";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinas)).EndInit();
            this.gpxAcaoDisciplina.ResumeLayout(false);
            this.gpxAcaoDisciplina.PerformLayout();
            this.gpxPesquisar.ResumeLayout(false);
            this.gpxPesquisar.PerformLayout();
            this.gpxAcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDisciplinasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvDisciplinas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource clsDisciplinasBindingSource;
        private System.Windows.Forms.GroupBox gpxAcaoDisciplina;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtNomeDisciplina;
        private System.Windows.Forms.Label lblDescricaoPesquisar;
        private System.Windows.Forms.GroupBox gpxPesquisar;
        private System.Windows.Forms.Button btnPesquisarDisciplina;
        private System.Windows.Forms.Button btnListarDisciplinas;
        private System.Windows.Forms.GroupBox gpxAcoes;
        private System.Windows.Forms.Button btnExcluirDisciplina;
        private System.Windows.Forms.Button btnEditarDisciplina;
        private System.Windows.Forms.Button btnInserirDisciplina;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCancelar;
        //private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddisciplinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddescricao;
        private System.Windows.Forms.Button btnImprimir;
    }
}