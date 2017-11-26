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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista_empleados form = new Lista_empleados();
            form.Show();
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargo form = new Cargo();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
