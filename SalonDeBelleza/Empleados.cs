﻿using System;
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
    public partial class Empleados : Form
    {
        Clases.Conexion conexion = new Clases.Conexion();
        public Empleados()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource2.Fill();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }
        private Boolean Validar()
        {
            if (txtIdentidad.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtIdentidad, "Este Campo es Obligatorio");
                return false;
            }
            else if (txtNombre.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtNombre, "Este Campo es Obligatorio");
                return false;
            }
            else if (txtApellido.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtApellido, "Este Campo es Obligatorio");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexion.abrirConexion() == true)
                {
                    Clases.Empleados pEmpleados = new Clases.Empleados();
                    pEmpleados.Identidad = Convert.ToInt32(txtIdentidad.Text);

                    int resultado;
                    resultado = Clases.Empleados.EliminarEmpleado(conexion.conexion, pEmpleados);
                    if (resultado > 0)
                    {
                        txtIdentidad.Clear();
                        txtNombre.Clear();
                        txtApellido.Clear();
                        txtTelefono.Clear();
                        txtDireccion.Clear();
                        txtAreaTrabajo.Clear();
                        sqlDataSource2.Fill();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                try
                {
                    if (conexion.abrirConexion() == true)
                    {
                        Clases.Empleados pEmpleados = new Clases.Empleados();
                        pEmpleados.Identidad = Convert.ToInt32(txtIdentidad.Text);
                        pEmpleados.Nombre = txtNombre.Text;
                        pEmpleados.Apellido = txtApellido.Text;
                        pEmpleados.Telefono = Convert.ToInt32(txtTelefono.Text);
                        pEmpleados.Direccion = txtDireccion.Text;
                        pEmpleados.AreaTrabajo = txtAreaTrabajo.Text;

                        int resultado;
                        resultado = Clases.Empleados.AgregarEmpleado(conexion.conexion, pEmpleados);
                        if (resultado > 0)
                        {
                            txtIdentidad.Clear();
                            txtNombre.Clear();
                            txtApellido.Clear();
                            txtTelefono.Clear();
                            txtDireccion.Clear();
                            txtAreaTrabajo.Clear();
                            sqlDataSource2.Fill();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                try
                {
                    if (conexion.abrirConexion() == true)
                    {
                        Clases.Empleados pEmpleados = new Clases.Empleados();
                        pEmpleados.Identidad = Convert.ToInt32(txtIdentidad.Text);
                        pEmpleados.Nombre = txtNombre.Text;
                        pEmpleados.Apellido = txtApellido.Text;
                        pEmpleados.Telefono = Convert.ToInt32(txtTelefono.Text);
                        pEmpleados.Direccion = txtDireccion.Text;
                        pEmpleados.AreaTrabajo = txtAreaTrabajo.Text;

                        int resultado;
                        resultado = Clases.Empleados.ActualizarEmpleado(conexion.conexion, pEmpleados);
                        if (resultado > 0)
                        {
                            txtIdentidad.Clear();
                            txtNombre.Clear();
                            txtApellido.Clear();
                            txtTelefono.Clear();
                            txtDireccion.Clear();
                            txtAreaTrabajo.Clear();
                            sqlDataSource2.Fill();
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

        private void txtIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
