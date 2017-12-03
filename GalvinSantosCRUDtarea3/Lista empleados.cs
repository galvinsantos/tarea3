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
        {    //ver lista de los empleados
            try
            {
                operacion oper = new operacion();
                DataSet ds = oper.ConsultaConResultado(" select empleado.id, empleado.nombre, empleado.apellido, empleado.telefono, empleado.cedula, cargo.departamento from empleado,cargo where empleado.id = cargo.id; ");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch
            {

            }

           
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Form2 frm = new Form2 (dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 frm = new Form2(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnborrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("El contenido a sido eliminado");
            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            DataSet ds = oper.ConsultaConResultado(" select empleado.id, empleado.nombre, empleado.apellido, empleado.telefono, empleado.cedula, cargo.departamento from empleado,cargo where empleado.id = cargo.id;");
            ds.WriteXml("c:\\Sistemas\\tarea3.xml");
            reportviewer f = new reportviewer("Reporte3.rpt");
            f.Show();
        }
    }
}
