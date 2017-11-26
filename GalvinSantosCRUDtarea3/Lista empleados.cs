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
    public partial class Lista_empleados : Form
    {
        public Lista_empleados()
        {
            InitializeComponent();
        }

        private void Lista_empleados_Load(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            DataSet ds = oper.ConsultaConResultado(" select empleado.id, empleado.nombre, empleado.apellido, empleado.telefono, empleado.cedula as departamento FROM empleado left join cargo on empleado.id = cargo.id; ");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
