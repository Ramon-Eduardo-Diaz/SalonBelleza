using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace SalonDeBelleza
{
    public partial class Administrador : DevExpress.XtraEditors.XtraForm
    {
        Clases.Conexion conexion = new Clases.Conexion();
        public Administrador()
        {
            InitializeComponent();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }
        public Clases.Administradores administradores = new Clases.Administradores();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexion.abrirConexion() == true)
                {
                    String resultado = Clases.Administradores.Consultar(conexion.conexion, txtId.Text);
                    if (resultado == txtContra.Text)
                    {
                        Menú menú = new Menú();
                        this.Hide();
                        txtId.Clear();
                        txtContra.Clear();
                        menú.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Contaseña o Usuario Incorrecto!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}