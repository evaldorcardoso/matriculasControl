using Microsoft.Reporting.WinForms;
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
    public partial class frmRelatorios : Form
    {
        public enum eStatusForm
        {
            alunos,
            disciplinas,
            matriculas,
            semestres
        }
        private eStatusForm statusForm;
        public frmRelatorios(DataTable pSource, eStatusForm tipo)
        {
            InitializeComponent();
            ReportDataSource report = new ReportDataSource();
            report.Name = "DataSet1";
            report.Value = pSource;
            rpwViewer.LocalReport.DataSources.Add(report);
            statusForm = tipo;
            switch (statusForm)
            {
                case eStatusForm.alunos:
                    rpwViewer.LocalReport.ReportEmbeddedResource = "matriculasControl.rptListaAlunos.rdlc";
                    break;
                case eStatusForm.disciplinas:
                    rpwViewer.LocalReport.ReportEmbeddedResource = "matriculasControl.rptListaDisciplinas.rdlc";
                    break;
                case eStatusForm.matriculas:
                    rpwViewer.LocalReport.ReportEmbeddedResource = "matriculasControl.rptListaMatriculados.rdlc";
                    break;
                case eStatusForm.semestres:
                    break;
                default:
                    break;
            }
            rpwViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rpwViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rpwViewer.RefreshReport();
        }

        private void frmRelatorioAlunos_Load(object sender, EventArgs e)
        {

            this.rpwViewer.RefreshReport();
        }
    }
}
