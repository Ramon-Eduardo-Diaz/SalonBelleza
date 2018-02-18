using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SalonDeBelleza.Clases
{
    class Historial
    {
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public String Fecha { get; set; }
        public Historial() { }

        public static int AgregarHistorial(MySqlConnection conexion, Historial pHistoria)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO `salonbelleza`.`historial` (`Cliente_idCliente`, `Empleado_idEmpleado`, `Fecha`) VALUES ('{0}', '{1}', '{2}');", pHistoria.IdCliente, pHistoria.IdEmpleado, pHistoria.Fecha), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static IList<Historial> Buscar(MySqlConnection con, int idCliente)
        {
            List<Historial> lista = new List<Historial>();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT Cliente_idCliente, Empleado_idEmpleado, Fecha FROM salonbelleza.historial where Cliente_idCliente = {0};", idCliente), con);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Historial historial = new Historial();
                historial.IdCliente = reader.GetInt16(0);
                historial.IdEmpleado = reader.GetInt16(1);
                historial.Fecha = reader.GetString(2);

                lista.Add(historial);
            }
            return lista;
        }
    }
}
