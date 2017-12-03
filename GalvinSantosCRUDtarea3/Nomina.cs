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
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
        }

        private void Nomina_Load(object sender, EventArgs e)
        //vista detalles nomina
        {
            try
            {
                operacion oper = new operacion();
                //DataSet ds = oper.ConsultaConResultado("SELECT * FROM detalle_nomina");
                DataSet ds = oper.ConsultaConResultado(" select empleado.id, empleado.nombre, empleado.apellido, empleado.cedula, detalle_nomina.sueldo, " +
                    "detalle_nomina.isr, detalle_nomina.ss, detalle_nomina.ahorro, detalle_nomina.total_descuento, detalle_nomina.total_descuento, " +
                    "detalle_nomina.sueldo_neto   from empleado,detalle_nomina where empleado.id = detalle_nomina.id; ");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("La información se correctamente");
            }


        }
        public void loadData()
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {



        }

    }

}
