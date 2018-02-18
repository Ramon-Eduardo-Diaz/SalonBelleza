using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SalonDeBelleza.Clases
{
    class Reservaciones
    {
        public int idreservacion { get; set; }
        public int idCliente { get; set; }
        public string fechaReservacion { get; set; }
        public string fechaAtencion { get; set; }
        public string hora { get; set; }

        public Reservaciones() { }

        public static int agregarReservacion(MySqlConnection con, Reservaciones pReservacion)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO `salonbelleza`.`reservaciones` (`Cliente_idCliente`, `FechaAtencion`, `FechaReservacion`, `horaAtencion`) VALUES ('{1}', '{2}', '{3}','{4}');", pReservacion.idreservacion ,pReservacion.idCliente, pReservacion.fechaAtencion, pReservacion.fechaReservacion, pReservacion.hora), con);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ActualizarReservacion(MySqlConnection con, Reservaciones pReservacion)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE `salonbelleza`.`reservaciones` SET `FechaAtencion`='{1}', `FechaReservacion`='{2}', `horaAtencion`='{3}' WHERE `Cliente_idCliente`='{0}';", pReservacion.idCliente, pReservacion.fechaAtencion, pReservacion.fechaReservacion, pReservacion.hora), con);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int EliminarReservacion(MySqlConnection con, Reservaciones pReservacion)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM `salonbelleza`.`reservaciones` WHERE `idReservacion`='{0}' ;", pReservacion.idreservacion, pReservacion.fechaAtencion, pReservacion.fechaReservacion, pReservacion.hora), con);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
