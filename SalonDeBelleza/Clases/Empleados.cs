using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SalonDeBelleza.Clases
{
    class Empleados
    {
        public int Identidad { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int Telefono { get; set; }
        public String Direccion { get; set; }
        public String AreaTrabajo { get; set; }

        public Empleados()
        {

        }

        public Empleados(int pIdentidad, String pNombre, String pApellido, int pTelefono, String pDireccion, String pAreaTrabajo)
        {
            this.Identidad = pIdentidad;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Telefono = pTelefono;
            this.Direccion = pDireccion;
            this.AreaTrabajo = pAreaTrabajo;
        }

        public static int AgregarEmpleado(MySqlConnection conexion, Empleados pEmpleado)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO `salonbelleza`.`empleado` (`idEmpleado`, `Nombre`, `Apellido`, `Telefono`, `Direccion`, `AreaTrabajo`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');", pEmpleado.Identidad, pEmpleado.Nombre, pEmpleado.Apellido, pEmpleado.Telefono, pEmpleado.Direccion, pEmpleado.AreaTrabajo), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ActualizarEmpleado(MySqlConnection conexion, Empleados pEmpleado)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE `salonbelleza`.`empleado` SET `Nombre`='{1}', `Apellido`='{2}', `Telefono`='{3}', `Direccion`='{4}', `AreaTrabajo`='{5}' WHERE `idEmpleado`='{0}';", pEmpleado.Identidad, pEmpleado.Nombre,  pEmpleado.Apellido, pEmpleado.Telefono, pEmpleado.Direccion, pEmpleado.AreaTrabajo), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static int EliminarEmpleado(MySqlConnection conexion, Empleados pEmpleado)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM `salonbelleza`.`empleado` WHERE `idEmpleado`='{0}';", pEmpleado.Identidad), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;

        }
    }
}
