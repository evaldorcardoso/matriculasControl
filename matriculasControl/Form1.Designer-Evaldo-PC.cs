namespace matriculasControl
{
    partial class frmAlunos
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
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.idalunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsAlunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gpxAlunos = new System.Windows.Forms.GroupBox();
            this.gpxPesquisarAluno = new System.Windows.Forms.GroupBox();
            this.btnPesquisarAluno = new System.Windows.Forms.Button();
            this.btnListarAlunos = new System.Windows.Forms.Button();
            this.gpxDisciplinas = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnInserirDisciplina = new System.Windows.Forms.Button();
            this.gpxSemestre = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnInserirSemestre = new System.Windows.Forms.Button();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.btnEditarAluno = new System.Windows.Forms.Button();
            this.btnNovoAluno = new System.Windows.Forms.Button();
            this.gpxMatriculas = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRelatorioAluno = new System.Windows.Forms.Button();
            this.gpxRelatorios = new System.Windows.Forms.GroupBox();
            this.btnRelatorioDisciplina = new System.Windows.Forms.Button();
            this.clsDisciplinasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvDisciplinas = new System.Windows.Forms.DataGridView();
            this.idDisciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvSemestres = new System.Windows.Forms.DataGridView();
            this.clsSemestresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsAlunosBindingSource)).BeginInit();
            this.gpxPesquisarAluno.SuspendLayout();
            this.gpxDisciplinas.SuspendLayout();
            this.gpxSemestre.SuspendLayout();
            this.gpxMatriculas.SuspendLayout();
            this.gpxRelatorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsDisciplinasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemestres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsSemestresBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Location = new System.Drawing.Point(18, 21);
            this.lblNomeAluno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(49, 17);
            this.lblNomeAluno.TabIndex = 0;
            this.lblNomeAluno.Text = "Nome:";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.BackColor = System.Drawing.Color.PowderBlue;
            this.txtNomeAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(22, 50);
            this.txtNomeAluno.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(250, 22);
            this.txtNomeAluno.TabIndex = 1;
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.AllowUserToOrderColumns = true;
            this.dgvAlunos.AutoGenerateColumns = false;
            this.dgvAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAlunos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAlunos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalunoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.datanascDataGridViewTextBoxColumn});
            this.dgvAlunos.DataSource = this.clsAlunosBindingSource;
            this.dgvAlunos.Location = new System.Drawing.Point(101, 117);
            this.dgvAlunos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAlunos.Size = new System.Drawing.Size(299, 361);
            this.dgvAlunos.TabIndex = 3;
            // 
            // idalunoDataGridViewTextBoxColumn
            // 
            this.idalunoDataGridViewTextBoxColumn.DataPropertyName = "id_aluno";
            this.idalunoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idalunoDataGridViewTextBoxColumn.Name = "idalunoDataGridViewTextBoxColumn";
            this.idalunoDataGridViewTextBoxColumn.Width = 46;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 70;
            // 
            // datanascDataGridViewTextBoxColumn
            // 
            this.datanascDataGridViewTextBoxColumn.DataPropertyName = "data_nasc";
            this.datanascDataGridViewTextBoxColumn.HeaderText = "Data Nascimento";
            this.datanascDataGridViewTextBoxColumn.Name = "datanascDataGridViewTextBoxColumn";
            this.datanascDataGridViewTextBoxColumn.Width = 129;
            // 
            // clsAlunosBindingSource
            // 
            this.clsAlunosBindingSource.DataSource = typeof(matriculasControl.ClsAlunos);
            // 
            // gpxAlunos
            // 
            this.gpxAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxAlunos.ForeColor = System.Drawing.Color.White;
            this.gpxAlunos.Location = new System.Drawing.Point(12, 96);
            this.gpxAlunos.Name = "gpxAlunos";
            this.gpxAlunos.Size = new System.Drawing.Size(408, 403);
            this.gpxAlunos.TabIndex = 8;
            this.gpxAlunos.TabStop = false;
            this.gpxAlunos.Text = "Alunos:";
            // 
            // gpxPesquisarAluno
            // 
            this.gpxPesquisarAluno.Controls.Add(this.btnPesquisarAluno);
            this.gpxPesquisarAluno.Controls.Add(this.btnListarAlunos);
            this.gpxPesquisarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxPesquisarAluno.ForeColor = System.Drawing.Color.White;
            this.gpxPesquisarAluno.Location = new System.Drawing.Point(12, 4);
            this.gpxPesquisarAluno.Name = "gpxPesquisarAluno";
            this.gpxPesquisarAluno.Size = new System.Drawing.Size(408, 87);
            this.gpxPesquisarAluno.TabIndex = 9;
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
            this.btnPesquisarAluno.Location = new System.Drawing.Point(268, 15);
            this.btnPesquisarAluno.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarAluno.Name = "btnPesquisarAluno";
            this.btnPesquisarAluno.Size = new System.Drawing.Size(65, 65);
            this.btnPesquisarAluno.TabIndex = 2;
            this.btnPesquisarAluno.UseVisualStyleBackColor = false;
            this.btnPesquisarAluno.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnListarAlunos
            // 
            this.btnListarAlunos.BackColor = System.Drawing.Color.CadetBlue;
            this.btnListarAlunos.BackgroundImage = global::matriculasControl.Properties.Resources.refresh_512_;
            this.btnListarAlunos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListarAlunos.FlatAppearance.BorderSize = 0;
            this.btnListarAlunos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnListarAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarAlunos.Location = new System.Drawing.Point(338, 15);
            this.btnListarAlunos.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarAlunos.Name = "btnListarAlunos";
            this.btnListarAlunos.Size = new System.Drawing.Size(65, 65);
            this.btnListarAlunos.TabIndex = 7;
            this.btnListarAlunos.UseVisualStyleBackColor = false;
            this.btnListarAlunos.Click += new System.EventHandler(this.btnListarTodos_Click);
            // 
            // gpxDisciplinas
            // 
            this.gpxDisciplinas.Controls.Add(this.dgvDisciplinas);
            this.gpxDisciplinas.Controls.Add(this.button3);
            this.gpxDisciplinas.Controls.Add(this.button4);
            this.gpxDisciplinas.Controls.Add(this.btnInserirDisciplina);
            this.gpxDisciplinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxDisciplinas.ForeColor = System.Drawing.Color.White;
            this.gpxDisciplinas.Location = new System.Drawing.Point(431, 96);
            this.gpxDisciplinas.Name = "gpxDisciplinas";
            this.gpxDisciplinas.Size = new System.Drawing.Size(408, 403);
            this.gpxDisciplinas.TabIndex = 10;
            this.gpxDisciplinas.TabStop = false;
            this.gpxDisciplinas.Text = "Disciplinas:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CadetBlue;
            this.button3.BackgroundImage = global::matriculasControl.Properties.Resources.Delete_document_512;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(16, 141);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 48);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CadetBlue;
            this.button4.BackgroundImage = global::matriculasControl.Properties.Resources.Edit_document_512;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(16, 85);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 48);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnInserirDisciplina
            // 
            this.btnInserirDisciplina.BackColor = System.Drawing.Color.CadetBlue;
            this.btnInserirDisciplina.BackgroundImage = global::matriculasControl.Properties.Resources.Add_document_256;
            this.btnInserirDisciplina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInserirDisciplina.FlatAppearance.BorderSize = 0;
            this.btnInserirDisciplina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInserirDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirDisciplina.Location = new System.Drawing.Point(16, 29);
            this.btnInserirDisciplina.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserirDisciplina.Name = "btnInserirDisciplina";
            this.btnInserirDisciplina.Size = new System.Drawing.Size(67, 48);
            this.btnInserirDisciplina.TabIndex = 7;
            this.btnInserirDisciplina.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInserirDisciplina.UseVisualStyleBackColor = false;
            this.btnInserirDisciplina.Click += new System.EventHandler(this.btnInserirDisciplina_Click);
            // 
            // gpxSemestre
            // 
            this.gpxSemestre.Controls.Add(this.dgvSemestres);
            this.gpxSemestre.Controls.Add(this.button8);
            this.gpxSemestre.Controls.Add(this.button9);
            this.gpxSemestre.Controls.Add(this.btnInserirSemestre);
            this.gpxSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxSemestre.ForeColor = System.Drawing.Color.White;
            this.gpxSemestre.Location = new System.Drawing.Point(851, 96);
            this.gpxSemestre.Name = "gpxSemestre";
            this.gpxSemestre.Size = new System.Drawing.Size(408, 403);
            this.gpxSemestre.TabIndex = 16;
            this.gpxSemestre.TabStop = false;
            this.gpxSemestre.Text = "Semestres:";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.CadetBlue;
            this.button8.BackgroundImage = global::matriculasControl.Properties.Resources.Delete_tear_of_calendar_256;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(7, 143);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 48);
            this.button8.TabIndex = 9;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.CadetBlue;
            this.button9.BackgroundImage = global::matriculasControl.Properties.Resources.Edit_tear_of_calendar_256;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(8, 87);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 48);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // btnInserirSemestre
            // 
            this.btnInserirSemestre.BackColor = System.Drawing.Color.CadetBlue;
            this.btnInserirSemestre.BackgroundImage = global::matriculasControl.Properties.Resources.Add_tear_of_calendar_256;
            this.btnInserirSemestre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInserirSemestre.FlatAppearance.BorderSize = 0;
            this.btnInserirSemestre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInserirSemestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirSemestre.Location = new System.Drawing.Point(8, 31);
            this.btnInserirSemestre.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserirSemestre.Name = "btnInserirSemestre";
            this.btnInserirSemestre.Size = new System.Drawing.Size(67, 48);
            this.btnInserirSemestre.TabIndex = 7;
            this.btnInserirSemestre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInserirSemestre.UseVisualStyleBackColor = false;
            this.btnInserirSemestre.Click += new System.EventHandler(this.btnInserirSemestre_Click);
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExcluirAluno.BackgroundImage = global::matriculasControl.Properties.Resources.remove_user_512;
            this.btnExcluirAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluirAluno.FlatAppearance.BorderSize = 0;
            this.btnExcluirAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnExcluirAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirAluno.Location = new System.Drawing.Point(26, 229);
            this.btnExcluirAluno.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(67, 46);
            this.btnExcluirAluno.TabIndex = 6;
            this.btnExcluirAluno.UseVisualStyleBackColor = false;
            this.btnExcluirAluno.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditarAluno
            // 
            this.btnEditarAluno.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEditarAluno.BackgroundImage = global::matriculasControl.Properties.Resources.edit_user_512_;
            this.btnEditarAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditarAluno.FlatAppearance.BorderSize = 0;
            this.btnEditarAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAluno.Location = new System.Drawing.Point(26, 173);
            this.btnEditarAluno.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.Size = new System.Drawing.Size(67, 48);
            this.btnEditarAluno.TabIndex = 5;
            this.btnEditarAluno.UseVisualStyleBackColor = false;
            this.btnEditarAluno.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovoAluno
            // 
            this.btnNovoAluno.BackColor = System.Drawing.Color.CadetBlue;
            this.btnNovoAluno.BackgroundImage = global::matriculasControl.Properties.Resources.add_user_512;
            this.btnNovoAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovoAluno.FlatAppearance.BorderSize = 0;
            this.btnNovoAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnNovoAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoAluno.Location = new System.Drawing.Point(26, 117);
            this.btnNovoAluno.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovoAluno.Name = "btnNovoAluno";
            this.btnNovoAluno.Size = new System.Drawing.Size(67, 48);
            this.btnNovoAluno.TabIndex = 4;
            this.btnNovoAluno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovoAluno.UseVisualStyleBackColor = false;
            this.btnNovoAluno.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // gpxMatriculas
            // 
            this.gpxMatriculas.Controls.Add(this.button11);
            this.gpxMatriculas.Controls.Add(this.comboBox3);
            this.gpxMatriculas.Controls.Add(this.label5);
            this.gpxMatriculas.Controls.Add(this.comboBox2);
            this.gpxMatriculas.Controls.Add(this.label4);
            this.gpxMatriculas.Controls.Add(this.label3);
            this.gpxMatriculas.Controls.Add(this.comboBox1);
            this.gpxMatriculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxMatriculas.ForeColor = System.Drawing.Color.White;
            this.gpxMatriculas.Location = new System.Drawing.Point(12, 505);
            this.gpxMatriculas.Name = "gpxMatriculas";
            this.gpxMatriculas.Size = new System.Drawing.Size(824, 182);
            this.gpxMatriculas.TabIndex = 22;
            this.gpxMatriculas.TabStop = false;
            this.gpxMatriculas.Text = "Matriicular Aluno:";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.CadetBlue;
            this.button11.BackgroundImage = global::matriculasControl.Properties.Resources.checkmark_256;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(608, 26);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(126, 141);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(407, 66);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 28);
            this.comboBox3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selecione o Semestre:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(209, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Enter += new System.EventHandler(this.comboBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Selecione a Disciplina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Selecione o Aluno:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clsAlunosBindingSource;
            this.comboBox1.DisplayMember = "id_aluno";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "id_aluno";
            // 
            // btnRelatorioAluno
            // 
            this.btnRelatorioAluno.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRelatorioAluno.BackgroundImage = global::matriculasControl.Properties.Resources.User_purchase_order_256;
            this.btnRelatorioAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRelatorioAluno.FlatAppearance.BorderSize = 0;
            this.btnRelatorioAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnRelatorioAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioAluno.Location = new System.Drawing.Point(7, 26);
            this.btnRelatorioAluno.Margin = new System.Windows.Forms.Padding(4);
            this.btnRelatorioAluno.Name = "btnRelatorioAluno";
            this.btnRelatorioAluno.Size = new System.Drawing.Size(67, 48);
            this.btnRelatorioAluno.TabIndex = 23;
            this.btnRelatorioAluno.UseVisualStyleBackColor = false;
            // 
            // gpxRelatorios
            // 
            this.gpxRelatorios.Controls.Add(this.btnRelatorioDisciplina);
            this.gpxRelatorios.Controls.Add(this.btnRelatorioAluno);
            this.gpxRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxRelatorios.ForeColor = System.Drawing.Color.White;
            this.gpxRelatorios.Location = new System.Drawing.Point(851, 505);
            this.gpxRelatorios.Name = "gpxRelatorios";
            this.gpxRelatorios.Size = new System.Drawing.Size(408, 179);
            this.gpxRelatorios.TabIndex = 24;
            this.gpxRelatorios.TabStop = false;
            this.gpxRelatorios.Text = "Relatórios:";
            // 
            // btnRelatorioDisciplina
            // 
            this.btnRelatorioDisciplina.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRelatorioDisciplina.BackgroundImage = global::matriculasControl.Properties.Resources.Matricula_purchase_order_256;
            this.btnRelatorioDisciplina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRelatorioDisciplina.FlatAppearance.BorderSize = 0;
            this.btnRelatorioDisciplina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnRelatorioDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioDisciplina.Location = new System.Drawing.Point(96, 26);
            this.btnRelatorioDisciplina.Margin = new System.Windows.Forms.Padding(4);
            this.btnRelatorioDisciplina.Name = "btnRelatorioDisciplina";
            this.btnRelatorioDisciplina.Size = new System.Drawing.Size(67, 48);
            this.btnRelatorioDisciplina.TabIndex = 24;
            this.btnRelatorioDisciplina.UseVisualStyleBackColor = false;
            // 
            // clsDisciplinasBindingSource
            // 
            this.clsDisciplinasBindingSource.DataSource = typeof(matriculasControl.ClsDisciplinas);
            // 
            // dgvDisciplinas
            // 
            this.dgvDisciplinas.AutoGenerateColumns = false;
            this.dgvDisciplinas.BackgroundColor = System.Drawing.Color.White;
            this.dgvDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDisciplinaDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dgvDisciplinas.DataSource = this.clsDisciplinasBindingSource;
            this.dgvDisciplinas.Location = new System.Drawing.Point(90, 29);
            this.dgvDisciplinas.Name = "dgvDisciplinas";
            this.dgvDisciplinas.Size = new System.Drawing.Size(300, 353);
            this.dgvDisciplinas.TabIndex = 25;
            // 
            // idDisciplinaDataGridViewTextBoxColumn
            // 
            this.idDisciplinaDataGridViewTextBoxColumn.DataPropertyName = "idDisciplina";
            this.idDisciplinaDataGridViewTextBoxColumn.HeaderText = "idDisciplina";
            this.idDisciplinaDataGridViewTextBoxColumn.Name = "idDisciplinaDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(441, 58);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 22);
            this.textBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(431, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 87);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar:";
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "Pesquisar";
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.BackgroundImage = global::matriculasControl.Properties.Resources.search_512;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(269, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.BackgroundImage = global::matriculasControl.Properties.Resources.refresh_512_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(340, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 65);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dgvSemestres
            // 
            this.dgvSemestres.AutoGenerateColumns = false;
            this.dgvSemestres.BackgroundColor = System.Drawing.Color.White;
            this.dgvSemestres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemestres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn1});
            this.dgvSemestres.DataSource = this.clsSemestresBindingSource;
            this.dgvSemestres.Location = new System.Drawing.Point(82, 31);
            this.dgvSemestres.Name = "dgvSemestres";
            this.dgvSemestres.Size = new System.Drawing.Size(311, 351);
            this.dgvSemestres.TabIndex = 10;
            // 
            // clsSemestresBindingSource
            // 
            this.clsSemestresBindingSource.DataSource = typeof(matriculasControl.clsSemestres);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn1
            // 
            this.descricaoDataGridViewTextBoxColumn1.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn1.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn1.Name = "descricaoDataGridViewTextBoxColumn1";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(861, 58);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 22);
            this.textBox2.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(857, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(851, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 87);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar:";
            // 
            // button5
            // 
            this.button5.AccessibleDescription = "Pesquisar";
            this.button5.BackColor = System.Drawing.Color.CadetBlue;
            this.button5.BackgroundImage = global::matriculasControl.Properties.Resources.search_512;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(268, 15);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 65);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.CadetBlue;
            this.button6.BackgroundImage = global::matriculasControl.Properties.Resources.refresh_512_;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(339, 15);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 65);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // frmAlunos
            // 
            this.AcceptButton = this.btnPesquisarAluno;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1350, 699);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gpxRelatorios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpxMatriculas);
            this.Controls.Add(this.gpxSemestre);
            this.Controls.Add(this.gpxDisciplinas);
            this.Controls.Add(this.btnExcluirAluno);
            this.Controls.Add(this.btnEditarAluno);
            this.Controls.Add(this.btnNovoAluno);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.lblNomeAluno);
            this.Controls.Add(this.gpxAlunos);
            this.Controls.Add(this.gpxPesquisarAluno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alunos Cadastrados";
            this.Load += new System.EventHandler(this.frmAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsAlunosBindingSource)).EndInit();
            this.gpxPesquisarAluno.ResumeLayout(false);
            this.gpxDisciplinas.ResumeLayout(false);
            this.gpxSemestre.ResumeLayout(false);
            this.gpxMatriculas.ResumeLayout(false);
            this.gpxMatriculas.PerformLayout();
            this.gpxRelatorios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clsDisciplinasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemestres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsSemestresBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Button btnPesquisarAluno;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Button btnNovoAluno;
        private System.Windows.Forms.Button btnEditarAluno;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.BindingSource clsAlunosBindingSource;
        private System.Windows.Forms.Button btnListarAlunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gpxAlunos;
        private System.Windows.Forms.GroupBox gpxPesquisarAluno;
        private System.Windows.Forms.GroupBox gpxDisciplinas;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnInserirDisciplina;
        private System.Windows.Forms.GroupBox gpxSemestre;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnInserirSemestre;
        private System.Windows.Forms.GroupBox gpxMatriculas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnRelatorioAluno;
        private System.Windows.Forms.BindingSource clsDisciplinasBindingSource;
        private System.Windows.Forms.GroupBox gpxRelatorios;
        private System.Windows.Forms.Button btnRelatorioDisciplina;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgvDisciplinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDisciplinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvSemestres;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource clsSemestresBindingSource;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        //private System.EventHandler Form1_Load;
    }
}

