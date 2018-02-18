using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SalonDeBelleza.Clases
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public String NombreServicio { get; set; }
        public String Horas { get; set; }
        public int Empleado { get; set; }
        public String Genero { get; set; }

        public Servicio()
        {
        }

        public static int AgregarServicio(MySqlConnection conexion, Servicio pServicio)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO `salonbelleza`.`servicios` (`idServicios`, `Nombre`, `Horas`, `Empleado_idEmpleado`, `Genero`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');", pServicio.IdServicio, pServicio.NombreServicio, pServicio.Horas, pServicio.Empleado, pServicio.Genero), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ActualizarServicio(MySqlConnection conexion, Servicio pServicio)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE `salonbelleza`.`servicios` SET `Nombre`='{1}', `Horas`='{2}',`Empleado_idEmpleado`='{3}', `Genero`='{4}' WHERE `idServicios`='{0}';", pServicio.IdServicio, pServicio.NombreServicio, pServicio.Horas, pServicio.Empleado, pServicio.Genero), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static int EliminarServicio(MySqlConnection conexion, Servicio pServicio)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM `salonbelleza`.`servicios` WHERE `idServicios`='{0}';", pServicio.IdServicio), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;

        }




    }
}
