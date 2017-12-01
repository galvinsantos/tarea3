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
        {
            //
            
        }
        public void loadData()
        {
            listView1.Items.Clear();
            String query = "select distinct(semana) from detalle_nomina;";
            operacion oper = new operacion();
            DataSet ds = oper.ConsultaConResultado(query);
            foreach(DataRow fila in ds.Tables[0].Rows)

            for (int i = 0; i < ds.Tables.Count; i++)
            {
                ListViewItem item = new ListViewItem(ds.Tables[0].ToString());
                listView1.Items.Add(item);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int semana = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                String query = "select e.nombres || ' ' || e.apellidos AS EMPLEADO, " +
                    "c.horasTrabajadas as Horas_Trabajadas, " +
                    "c.sueldo as Sueldo, " +
                    "c.seguroSocial as Seguro_Social, " +
                    "c.cooperativa as Cooperativa, " +
                    "c.seguroMedico as Seguro_Medico, " +
                    "c.totalDevengado as Total_Devengado, " +
                    "c.totalNeto as Total_Pagar, " +
                    "c.fechaInicio as Fecha_Inicio, " +
                    "c.fechaFin as Fecha_Fin " +
                    "from nomina c, empleado e " +
                    "where c.empleadoId = e.id and c.semana = " + semana + ";";

                operacion dep = new operacion();
                DataSet dt = dep.ConsultaConResultado(query);
                foreach (DataRow fila in dt.Tables[0].Rows);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Ha sido generado");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
