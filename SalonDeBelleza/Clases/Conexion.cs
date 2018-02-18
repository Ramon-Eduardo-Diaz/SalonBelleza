using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SalonDeBelleza.Clases
{
    public class Conexion //Declaramos la clase como pública.
    {
        public MySqlConnection conexion;


        public Conexion()
        {
            conexion = new MySqlConnection("server=127.0.0.1; port=3306; database =salonbelleza; Uid =root; pwd=1234");
        }

        public bool abrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }
        }


        public bool cerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }
        }
    }
}
