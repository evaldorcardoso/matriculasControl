namespace matriculasControl
{
    partial class frmRelatorios
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
            this.rpwViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpwViewer
            // 
            this.rpwViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpwViewer.Location = new System.Drawing.Point(0, 0);
            this.rpwViewer.Name = "rpwViewer";
            this.rpwViewer.Size = new System.Drawing.Size(843, 474);
            this.rpwViewer.TabIndex = 0;
            // 
            // frmRelatorioAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(843, 474);
            this.Controls.Add(this.rpwViewer);
            this.Name = "frmRelatorioAlunos";
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.frmRelatorioAlunos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpwViewer;
    }
}