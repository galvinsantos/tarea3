using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace GalvinSantosCRUDtarea3
{
    public partial class reportviewer2 : Form
    {
        public reportviewer2(string nombre_reporte)
        {
            
                InitializeComponent();
                ReportDocument nomina = new ReportDocument();
                nomina.Load(nombre_reporte);
                crystalReportViewer2.ReportSource = nomina;
                crystalReportViewer2.Refresh();
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
