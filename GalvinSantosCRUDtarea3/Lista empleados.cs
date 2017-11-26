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
            DataSet ds = oper.ConsultaConResultado(" select empleado.id, empleado.nombre, empleado.apellido, empleado.telefono, empleado.cedula, cargo.departamento from empleado,cargo where empleado.id = cargo.id; ");
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
