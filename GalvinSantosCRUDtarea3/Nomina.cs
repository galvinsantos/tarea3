﻿using System;
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
                DataSet ds = oper.ConsultaConResultado(" select empleado.id, empleado.nombre, empleado.apellido, empleado.cedula, sueldo, (sueldo * ss) as 'descuento ss', (sueldo * isr) as 'descuento isr', (sueldo * .19) as 'descuento total', sueldo - (sueldo * .19) as 'sueldo neto' from empleado,detalle_nomina where empleado.id = detalle_nomina.id; ");
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch
            {

            }      


        }


        private void btnbuscar_Click(object sender, EventArgs e)
        {
            buscar(txtnomina.Text);
        }

        private void buscar(string id)
        {
            //busqueda de nomina
            /*try
            {
                operacion oper = new operacion();
                DataSet ds = oper.ConsultaConResultado(" select empleado.id, empleado.nombre, empleado.apellido, empleado.cedula from empleado where id= '" + txtnomina.Text + "'  ");
                //("SELECT * FROM empleado WHERE id='" + txtnomina.Text + "' "); 
                dataGridView1.DataSource = ds.Tables[0];

                DataSet dt = oper.ConsultaConResultado(" select detalle_nomina.sueldo, (sueldo * ss) as 'descuento ss', (sueldo * isr) as 'descuento isr', (sueldo * .19) as 'descuento total', sueldo - (sueldo * .19) as 'sueldo neto' from detalle_nomina where id = '" + txtnomina.Text + "'  ");
                dataGridView1.DataSource = dt.Tables[0];
            }
            catch
            {

            }*/
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
            // Exportando la data a formato XML
            try
            {
                operacion oper = new operacion();
                DataSet dt = oper.ConsultaConResultado(" select empleado.id, empleado.nombre, empleado.apellido, empleado.cedula, sueldo, (sueldo * ss) as 'descuento ss', (sueldo * isr) as 'descuento isr', (sueldo * .19) as 'descuento total', sueldo - (sueldo * .19) as 'sueldo neto' from empleado,detalle_nomina where empleado.id = detalle_nomina.id;");
                dt.WriteXml("c:\\Sistemas\\todonomina.xml");
                reportnom f = new reportnom("reportenomina.rpt"); //("C:\\Users\\santo\\Documents\\Visual Studio 2017\\Projects\\GalvinSantosCRUDtarea3\\GalvinSantosCRUDtarea3\\reportenomina.rpt");
                f.Show();
            }
        
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Se cargó correctamente :D");
            }
            
        }

    

        private void btnborrar_Click(object sender, EventArgs e)
        {
            //eliminando contenido
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
    }

}
