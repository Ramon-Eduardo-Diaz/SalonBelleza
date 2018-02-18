using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonDeBelleza
{
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados empleados = new Empleados();
            this.Hide();
            empleados.ShowDialog();
            this.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historial empleados = new Historial();
            this.Hide();
            empleados.ShowDialog();
            this.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void reservaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservaciones reservaciones = new Reservaciones();
            this.Hide();
            reservaciones.ShowDialog();
            this.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            this.Hide();
            clientes.ShowDialog();
            this.Show();
        }

        private void administradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administradores clientes = new Administradores();
            this.Hide();
            clientes.ShowDialog();
            this.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicios clientes = new Servicios();
            this.Hide();
            clientes.ShowDialog();
            this.Show();
        }

        private void hombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hombre clientes = new Hombre();
            this.Hide();
            clientes.ShowDialog();
            this.Show();
        }

        private void mujerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mujeres clientes = new Mujeres();
            this.Hide();
            clientes.ShowDialog();
            this.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion clientes = new Facturacion();
            this.Hide();
            clientes.ShowDialog();
            this.Show();
        }
    }
}
