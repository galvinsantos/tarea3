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
            //busqueda de cargo
            try
            {
                operacion oper = new operacion();
                DataSet ds = oper.ConsultaConResultado("SELECT * FROM cargo WHERE id='" + txtidcargo.Text + "' ");
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    if (fila["id"] != null) txtidcargo.Text = fila["id"].ToString();
                    if (fila["departamento"] != null) cmbdepartamento.Text = fila["departamento"].ToString();

                }
            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void btnmostrar_Click(object sender, EventArgs e)
        {

        }

        private void Cargo_Load(object sender, EventArgs e)
        {
            //tabla de cargo
            
            try
            {
                
                operacion oper = new operacion();
                DataSet ds = oper.ConsultaConResultado(" select empleado.id, empleado.nombre, empleado.apellido, empleado.estatus, cargo.departamento from empleado,cargo where empleado.id = cargo.id; ");
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();

            }
            catch
            {

            }
        }

        private void llena_departamento()
        {

            //no nesesario
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                operacion oper = new operacion();
                oper.ConsultaSinResultado(" UPDATE cargo SET departamento='" + cmbdepartamento.Text.ToString() + "' WHERE id= '" + txtidcargo.Text + "' ");
                operacion display = new operacion();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Se actualizo correctamente");
            }
        }

        private void cmbdepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
