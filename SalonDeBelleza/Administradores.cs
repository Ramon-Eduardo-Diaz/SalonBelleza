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
    public partial class Administradores : Form
    {
        Clases.Conexion conexion = new Clases.Conexion();
        public Administradores()
        {
            InitializeComponent();
        }

        private void txtServicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (txtContrasena.Text != txtVerificacion.Text)
                {
                    MessageBox.Show("Las Contraseña no coinciden!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        if (conexion.abrirConexion() == true)
                        {
                            Clases.Administradores pAdmon = new Clases.Administradores();
                            pAdmon.idAdministrador = Convert.ToInt32(txtIdAmon.Text);
                            pAdmon.Contrasena = txtContrasena.Text;


                            int resultado;
                            resultado = Clases.Administradores.AgregarAdministrador(conexion.conexion, pAdmon);
                            if (resultado > 0)
                            {
                                txtIdAmon.Clear();
                                txtContrasena.Clear();
                                txtVerificacion.Clear();
                            }
                            conexion.cerrarConexion();
                        }
                        else
                        {
                            MessageBox.Show("No se Conecto!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                try
                {
                    if (conexion.abrirConexion() == true)
                    {
                        Clases.Administradores pAdmon = new Clases.Administradores();
                        pAdmon.idAdministrador = Convert.ToInt32(txtIdAmon.Text);
                        pAdmon.Contrasena = txtContrasena.Text;


                        int resultado;
                        resultado = Clases.Administradores.EliminarAdmon(conexion.conexion, pAdmon);
                        if (resultado > 0)
                        {
                            txtIdAmon.Clear();
                            txtContrasena.Clear();
                            txtVerificacion.Clear();
                        }
                        conexion.cerrarConexion();
                    }
                    else
                    {
                        MessageBox.Show("No se Conecto!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (txtContrasena.Text != txtVerificacion.Text)
                {
                    MessageBox.Show("Las Contraseña no coinciden!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        if (conexion.abrirConexion() == true)
                        {
                            Clases.Administradores pAdmon = new Clases.Administradores();
                            pAdmon.idAdministrador = Convert.ToInt32(txtIdAmon.Text);
                            pAdmon.Contrasena = txtContrasena.Text;


                            int resultado;
                            resultado = Clases.Administradores.ActualizarAdministrador(conexion.conexion, pAdmon);
                            if (resultado > 0)
                            {
                                txtIdAmon.Clear();
                                txtContrasena.Clear();
                                txtVerificacion.Clear();
                            }
                            conexion.cerrarConexion();
                        }
                        else
                        {
                            MessageBox.Show("No se Conecto!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Administradores_Load(object sender, EventArgs e)
        {

        }

        private void txtIdAmon_KeyPress(object sender, KeyPressEventArgs e)
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

        private Boolean Validar()
        {
            if(txtIdAmon.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtIdAmon, "Este Campo es Obligatorio");
                return false;
            }
            else if(txtContrasena.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtContrasena, "Este Campo es Obligatorio");
                return false;
            }
            else if (txtVerificacion.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtVerificacion, "Este Campo es Obligatorio");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }
    }
}
