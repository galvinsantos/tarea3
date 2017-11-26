using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalvinSantosCRUDtarea3
{
    public partial class Cargo : Form
    {
        public Cargo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscar(txtidcargo.Text);
        }    

        private void buscar(string id)
            {
                operacion oper = new operacion();
                DataSet ds = oper.ConsultaConResultado("SELECT * FROM cargo WHERE id='" + txtidcargo.Text + "' ");
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                if (fila["id"] != null) txtidcargo.Text = fila["id"].ToString();
                if (fila["departamento"] != null) cmbdepartamento.Text = fila["departamento"].ToString();
                   
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            oper.ConsultaSinResultado(" DELETE FROM cargo WHERE id='" + txtidcargo.Text + "' ");
        }
    }
}
