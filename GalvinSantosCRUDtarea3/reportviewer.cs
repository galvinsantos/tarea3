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
    public partial class reportviewer : Form
    {
        public reportviewer(string nombre)
        {
            InitializeComponent();          
            ReportDocument crystal = new ReportDocument();
            crystal.Load(nombre);
            crystalReportViewer1.ReportSource = crystal;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
