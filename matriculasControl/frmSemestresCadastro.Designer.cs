namespace matriculasControl
{
    partial class frmSemestresCadastro
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvSemestres = new System.Windows.Forms.DataGridView();
            this.gpxSemestresCadastrados = new System.Windows.Forms.GroupBox();
            this.gpxAcaoSemestre = new System.Windows.Forms.GroupBox();
            this.btnCancelarr = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gpxAcoes = new System.Windows.Forms.GroupBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExcluirSemestre = new System.Windows.Forms.Button();
            this.btnEditarSemestre = new System.Windows.Forms.Button();
            this.btnInserirSemestre = new System.Windows.Forms.Button();
            this.gpxPesquisar = new System.Windows.Forms.GroupBox();
            this.txtNomeSemestre = new System.Windows.Forms.TextBox();
            this.btnPesquisarSemestre = new System.Windows.Forms.Button();
            this.lblDescricaoPesquisar = new System.Windows.Forms.Label();
            this.btnListarSemestre = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsSemestresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemestres)).BeginInit();
            this.gpxAcaoSemestre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gpxAcoes.SuspendLayout();
            this.gpxPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsSemestresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(138, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(314, 26);
            this.txtNome.TabIndex = 14;
            this.txtNome.Visible = false;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(138, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(84, 20);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Descrição:";
            this.lblNome.Visible = false;
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
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::matriculasControl.Properties.Resources.tear_of_calendar_128;
            this.pictureBox1.Location = new System.Drawing.Point(27, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // dgvSemestres
            // 
            this.dgvSemestres.AllowUserToAddRows = false;
            this.dgvSemestres.AllowUserToDeleteRows = false;
            this.dgvSemestres.AutoGenerateColumns = false;
            this.dgvSemestres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSemestres.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSemestres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSemestres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemestres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dgvSemestres.DataSource = this.clsSemestresBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSemestres.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSemestres.Location = new System.Drawing.Point(200, 285);
            this.dgvSemestres.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSemestres.Name = "dgvSemestres";
            this.dgvSemestres.ReadOnly = true;
            this.dgvSemestres.RowHeadersVisible = false;
            this.dgvSemestres.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSemestres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSemestres.Size = new System.Drawing.Size(1128, 395);
            this.dgvSemestres.TabIndex = 18;
            this.dgvSemestres.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSemestres_CellMouseDoubleClick);
            this.dgvSemestres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSemestres_KeyDown);
            // 
            // gpxSemestresCadastrados
            // 
            this.gpxSemestresCadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxSemestresCadastrados.ForeColor = System.Drawing.Color.White;
            this.gpxSemestresCadastrados.Location = new System.Drawing.Point(179, 254);
            this.gpxSemestresCadastrados.Name = "gpxSemestresCadastrados";
            this.gpxSemestresCadastrados.Size = new System.Drawing.Size(1165, 433);
            this.gpxSemestresCadastrados.TabIndex = 19;
            this.gpxSemestresCadastrados.TabStop = false;
            this.gpxSemestresCadastrados.Text = "Semestres Cadastrados:";
            // 
            // gpxAcaoSemestre
            // 
            this.gpxAcaoSemestre.Controls.Add(this.btnCancelarr);
            this.gpxAcaoSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxAcaoSemestre.ForeColor = System.Drawing.Color.White;
            this.gpxAcaoSemestre.Location = new System.Drawing.Point(3, 3);
            this.gpxAcaoSemestre.Name = "gpxAcaoSemestre";
            this.gpxAcaoSemestre.Size = new System.Drawing.Size(621, 145);
            this.gpxAcaoSemestre.TabIndex = 20;
            this.gpxAcaoSemestre.TabStop = false;
            this.gpxAcaoSemestre.Text = "Cadastrar:";
            this.gpxAcaoSemestre.Visible = false;
            // 
            // btnCancelarr
            // 
            this.btnCancelarr.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCancelarr.BackgroundImage = global::matriculasControl.Properties.Resources.delete_256;
            this.btnCancelarr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelarr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarr.FlatAppearance.BorderSize = 0;
            this.btnCancelarr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarr.Location = new System.Drawing.Point(489, 80);
            this.btnCancelarr.Name = "btnCancelarr";
            this.btnCancelarr.Size = new System.Drawing.Size(82, 46);
            this.btnCancelarr.TabIndex = 0;
            this.btnCancelarr.UseVisualStyleBackColor = false;
            this.btnCancelarr.Click += new System.EventHandler(this.btnCancelarr_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::matriculasControl.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(630, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(610, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // gpxAcoes
            // 
            this.gpxAcoes.Controls.Add(this.btnVoltar);
            this.gpxAcoes.Controls.Add(this.btnExcluirSemestre);
            this.gpxAcoes.Controls.Add(this.btnEditarSemestre);
            this.gpxAcoes.Controls.Add(this.btnInserirSemestre);
            this.gpxAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxAcoes.ForeColor = System.Drawing.Color.White;
            this.gpxAcoes.Location = new System.Drawing.Point(3, 160);
            this.gpxAcoes.Name = "gpxAcoes";
            this.gpxAcoes.Size = new System.Drawing.Size(154, 527);
            this.gpxAcoes.TabIndex = 34;
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
            this.btnVoltar.Location = new System.Drawing.Point(27, 240);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(94, 59);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnExcluirSemestre
            // 
            this.btnExcluirSemestre.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExcluirSemestre.BackgroundImage = global::matriculasControl.Properties.Resources.Delete_tear_of_calendar_256;
            this.btnExcluirSemestre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluirSemestre.FlatAppearance.BorderSize = 0;
            this.btnExcluirSemestre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnExcluirSemestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirSemestre.Location = new System.Drawing.Point(27, 173);
            this.btnExcluirSemestre.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirSemestre.Name = "btnExcluirSemestre";
            this.btnExcluirSemestre.Size = new System.Drawing.Size(94, 59);
            this.btnExcluirSemestre.TabIndex = 12;
            this.btnExcluirSemestre.UseVisualStyleBackColor = false;
            this.btnExcluirSemestre.Click += new System.EventHandler(this.btnExcluirSemestre_Click);
            // 
            // btnEditarSemestre
            // 
            this.btnEditarSemestre.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEditarSemestre.BackgroundImage = global::matriculasControl.Properties.Resources.Edit_tear_of_calendar_256;
            this.btnEditarSemestre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditarSemestre.FlatAppearance.BorderSize = 0;
            this.btnEditarSemestre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarSemestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarSemestre.Location = new System.Drawing.Point(27, 106);
            this.btnEditarSemestre.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarSemestre.Name = "btnEditarSemestre";
            this.btnEditarSemestre.Size = new System.Drawing.Size(94, 59);
            this.btnEditarSemestre.TabIndex = 11;
            this.btnEditarSemestre.UseVisualStyleBackColor = false;
            this.btnEditarSemestre.Click += new System.EventHandler(this.btnEditarSemestre_Click);
            // 
            // btnInserirSemestre
            // 
            this.btnInserirSemestre.BackColor = System.Drawing.Color.CadetBlue;
            this.btnInserirSemestre.BackgroundImage = global::matriculasControl.Properties.Resources.Add_tear_of_calendar_256;
            this.btnInserirSemestre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInserirSemestre.FlatAppearance.BorderSize = 0;
            this.btnInserirSemestre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInserirSemestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirSemestre.Location = new System.Drawing.Point(27, 40);
            this.btnInserirSemestre.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserirSemestre.Name = "btnInserirSemestre";
            this.btnInserirSemestre.Size = new System.Drawing.Size(94, 59);
            this.btnInserirSemestre.TabIndex = 10;
            this.btnInserirSemestre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInserirSemestre.UseVisualStyleBackColor = false;
            this.btnInserirSemestre.Click += new System.EventHandler(this.btnInserirSemestre_Click);
            // 
            // gpxPesquisar
            // 
            this.gpxPesquisar.Controls.Add(this.txtNomeSemestre);
            this.gpxPesquisar.Controls.Add(this.btnPesquisarSemestre);
            this.gpxPesquisar.Controls.Add(this.lblDescricaoPesquisar);
            this.gpxPesquisar.Controls.Add(this.btnListarSemestre);
            this.gpxPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxPesquisar.ForeColor = System.Drawing.Color.White;
            this.gpxPesquisar.Location = new System.Drawing.Point(179, 154);
            this.gpxPesquisar.Name = "gpxPesquisar";
            this.gpxPesquisar.Size = new System.Drawing.Size(1165, 94);
            this.gpxPesquisar.TabIndex = 35;
            this.gpxPesquisar.TabStop = false;
            this.gpxPesquisar.Text = "Pesquisar:";
            // 
            // txtNomeSemestre
            // 
            this.txtNomeSemestre.BackColor = System.Drawing.Color.PowderBlue;
            this.txtNomeSemestre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeSemestre.Location = new System.Drawing.Point(10, 45);
            this.txtNomeSemestre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeSemestre.Name = "txtNomeSemestre";
            this.txtNomeSemestre.Size = new System.Drawing.Size(933, 22);
            this.txtNomeSemestre.TabIndex = 29;
            this.txtNomeSemestre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeSemestre_KeyPress);
            // 
            // btnPesquisarSemestre
            // 
            this.btnPesquisarSemestre.AccessibleDescription = "Pesquisar";
            this.btnPesquisarSemestre.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPesquisarSemestre.BackgroundImage = global::matriculasControl.Properties.Resources.search_512;
            this.btnPesquisarSemestre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarSemestre.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnPesquisarSemestre.FlatAppearance.BorderSize = 0;
            this.btnPesquisarSemestre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnPesquisarSemestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarSemestre.Location = new System.Drawing.Point(953, 20);
            this.btnPesquisarSemestre.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarSemestre.Name = "btnPesquisarSemestre";
            this.btnPesquisarSemestre.Size = new System.Drawing.Size(94, 59);
            this.btnPesquisarSemestre.TabIndex = 2;
            this.btnPesquisarSemestre.UseVisualStyleBackColor = false;
            this.btnPesquisarSemestre.Click += new System.EventHandler(this.btnPesquisarSemestre_Click);
            // 
            // lblDescricaoPesquisar
            // 
            this.lblDescricaoPesquisar.AutoSize = true;
            this.lblDescricaoPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoPesquisar.ForeColor = System.Drawing.Color.Black;
            this.lblDescricaoPesquisar.Location = new System.Drawing.Point(6, 20);
            this.lblDescricaoPesquisar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricaoPesquisar.Name = "lblDescricaoPesquisar";
            this.lblDescricaoPesquisar.Size = new System.Drawing.Size(84, 20);
            this.lblDescricaoPesquisar.TabIndex = 28;
            this.lblDescricaoPesquisar.Text = "Descrição:";
            // 
            // btnListarSemestre
            // 
            this.btnListarSemestre.BackColor = System.Drawing.Color.CadetBlue;
            this.btnListarSemestre.BackgroundImage = global::matriculasControl.Properties.Resources.refresh_512_;
            this.btnListarSemestre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListarSemestre.FlatAppearance.BorderSize = 0;
            this.btnListarSemestre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnListarSemestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarSemestre.Location = new System.Drawing.Point(1055, 20);
            this.btnListarSemestre.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarSemestre.Name = "btnListarSemestre";
            this.btnListarSemestre.Size = new System.Drawing.Size(94, 59);
            this.btnListarSemestre.TabIndex = 7;
            this.btnListarSemestre.UseVisualStyleBackColor = false;
            this.btnListarSemestre.Click += new System.EventHandler(this.btnListarSemestre_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.Location = new System.Drawing.Point(1264, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(37, 33);
            this.btnMaximize.TabIndex = 51;
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
            this.btnFechar.Location = new System.Drawing.Point(1307, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(37, 33);
            this.btnFechar.TabIndex = 50;
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
            this.btnMinimize.Location = new System.Drawing.Point(1221, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 33);
            this.btnMinimize.TabIndex = 49;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Código:";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição:";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clsSemestresBindingSource
            // 
            this.clsSemestresBindingSource.DataSource = typeof(matriculasControl.clsSemestres);
            // 
            // frmSemestresCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.CancelButton = this.btnCancelarr;
            this.ClientSize = new System.Drawing.Size(1350, 699);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.gpxPesquisar);
            this.Controls.Add(this.gpxAcoes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvSemestres);
            this.Controls.Add(this.gpxSemestresCadastrados);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.gpxAcaoSemestre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSemestresCadastro";
            this.Text = "Semestres";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemestres)).EndInit();
            this.gpxAcaoSemestre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gpxAcoes.ResumeLayout(false);
            this.gpxPesquisar.ResumeLayout(false);
            this.gpxPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsSemestresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvSemestres;
        private System.Windows.Forms.GroupBox gpxSemestresCadastrados;
        private System.Windows.Forms.BindingSource clsSemestresBindingSource;
        private System.Windows.Forms.GroupBox gpxAcaoSemestre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gpxAcoes;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExcluirSemestre;
        private System.Windows.Forms.Button btnEditarSemestre;
        private System.Windows.Forms.Button btnInserirSemestre;
        private System.Windows.Forms.GroupBox gpxPesquisar;
        private System.Windows.Forms.TextBox txtNomeSemestre;
        private System.Windows.Forms.Button btnPesquisarSemestre;
        private System.Windows.Forms.Label lblDescricaoPesquisar;
        private System.Windows.Forms.Button btnListarSemestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCancelarr;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimize;
    }
}