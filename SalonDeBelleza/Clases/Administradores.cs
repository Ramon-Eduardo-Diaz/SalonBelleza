using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SalonDeBelleza.Clases
{
    public class Administradores
    {
        public int idAdministrador { get; set; }
        public String Contrasena { get; set; }

        public Administradores(){ }

        public static int AgregarAdministrador(MySqlConnection con, Administradores pAdmon)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO `salonbelleza`.`administrador` (`idAdministrador`, `Contrasena`) VALUES ('{0}', '{1}');", pAdmon.idAdministrador, pAdmon.Contrasena), con);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static int ActualizarAdministrador(MySqlConnection con, Administradores pAdmon)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE `salonbelleza`.`administrador` SET `Contrasena`='{1}' WHERE `idAdministrador`='{0}';", pAdmon.idAdministrador, pAdmon.Contrasena), con);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static int EliminarAdmon(MySqlConnection con, Administradores pAdmon)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM `salonbelleza`.`administrador` WHERE `idAdministrador`='{0}';", pAdmon.idAdministrador), con);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static String Consultar(MySqlConnection con, String idAdmon)
        {
            String Contrasena ="";
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT Contrasena FROM salonbelleza.administrador WHERE idAdministrador = '{0}';", idAdmon), con);
            MySqlDataReader reader = comando.ExecuteReader();
            if(reader.Read())
            {
                Contrasena = reader.GetString(0);
            }
            else
            {
                Contrasena = "Null";
            }
            return Contrasena;
        }
    }
}
