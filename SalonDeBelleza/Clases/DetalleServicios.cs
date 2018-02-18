using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SalonDeBelleza.Clases
{
    class DetalleServicios
    {
        public int idServico { get; set; }
        public int IdReservacion { get; set; }

        public DetalleServicios() { }

        public static int agregarDetalle(MySqlConnection con, DetalleServicios pDetalleServicios)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO `salonbelleza`.`servicios_has_reservaciones` (`Servicios_idServicios`, `Reservaciones_Cliente_idCliente`) VALUES ('{0}', '{1}');", pDetalleServicios.idServico, pDetalleServicios.IdReservacion), con);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
