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
        private string v;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string v)
        {
            this.v = v;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                operacion oper = new operacion();
                oper.ConsultaSinResultado(" INSERT INTO empleado (nombre, apellido, telefono, cedula) VALUES ('" + txtnombre.Text.ToString() + "','" + txtapellido.Text.ToString() + "','" + txttelefono.Text.ToString() + "','" + txtcedula.Text.ToString() + "')");          
            }
            catch (Exception ex)

            {
                MessageBox.Show (ex.Message);
            }

            finally
            {
                MessageBox.Show("Muchas gracias");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            oper.ConsultaSinResultado(" UPDATE empleado SET nombre='" + txtnombre.Text.ToString() + "', apellido='" + txtapellido.Text.ToString() + "', telefono'" + txttelefono.Text.ToString() + "', cedula'" + txtcedula.Text.ToString() + "' WHERE id='" + txtid.Text + "' ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscar(txtid.Text);
            buscar(txtid.Text);
            buscar(txtid.Text);
            buscar(txtid.Text);
            buscar(txtid.Text);
            buscar(txtid.Text);
        }

        private void buscar(string id)
        {
            operacion oper = new operacion();
            DataSet ds = oper.ConsultaConResultado("SELECT * FROM empleado WHERE id='" + txtid.Text + "' ");
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                if (fila["id"] != null) txtid.Text = fila["id"].ToString();
                if (fila["nombre"] != null) txtnombre.Text = fila["nombre"].ToString();
                if (fila["apellido"] != null) txtapellido.Text = fila["apellido"].ToString();
                if (fila["telefono"] != null) txttelefono.Text = fila["telefono"].ToString();
                if (fila["cedula"] != null) txtcedula.Text = fila["cedula"].ToString();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                operacion oper = new operacion();
                oper.ConsultaSinResultado(" DELETE FROM empleado WHERE id='" + txtid.Text + "' ");
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

        private void Form2_Load(object sender, EventArgs e)
        {
            //dfgdfgdfg
        }

        private void llena_departamento()
        {

            operacion oper = new operacion();
            DataSet ds = oper.ConsultaConResultado(" select * from cargo ");
            cmbdepartamento.DataSource = ds.Tables[0];
            cmbdepartamento.ValueMember = "id";
            cmbdepartamento.DisplayMember = "departamento";

        }
    }
}
