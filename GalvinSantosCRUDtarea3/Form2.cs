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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            oper.ConsultaSinResultado(" INSERT INTO empleado (nombre, apellido)VALUES('" + txtnombre.Text.ToString() + "','" + txtapellido.Text.ToString() + "')");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            oper.ConsultaSinResultado(" UPDATE empleado SET nombre='" + txtnombre.Text.ToString() + "', apellido='" + txtapellido.Text.ToString() + "' WHERE id='" + txtid.Text + "')");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscar(txtid.Text);
        }

        private void buscar(string id)
        { 
            operacion oper = new operacion();
            DataSet ds = oper.ConsultaConResultado("SELECT * FROM empleado WHERE id='" + txtid.Text +"' ");
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                if (fila["id"] != null) txtid.Text = fila["id"].ToString();
                if (fila["nombre"] != null) txtnombre.Text = fila["nombre"].ToString();
                if (fila["apellido"] != null) txtapellido.Text = fila["apellido"].ToString();

            }
        }

    }
}
