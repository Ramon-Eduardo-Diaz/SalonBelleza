using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SalonDeBelleza.Clases
{
    public class Clientes
    {
        public int identidad { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Sexo { get; set; }
        public int Telefono { get; set; }
        public String Direccion { get; set; }
        public String Observaciones { get; set; }


        public Clientes()
        {
        }


        // Constructor.
        public Clientes(int sidCliente, String snombreCliente, String sapellidoCliente, int stelefonoCliente, String sDireccionCliente, String sObservaciones, String sSexo)
        {
            this.identidad = sidCliente;
            this.Nombre = snombreCliente;
            this.Apellido = sapellidoCliente;
            this.Telefono = stelefonoCliente;
            this.Direccion = sDireccionCliente;
            this.Observaciones = sObservaciones;
            this.Sexo = sSexo;

        }

        public static int agregarCliente(MySqlConnection con, Clientes pCliente)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO `salonbelleza`.`cliente` (`idCliente`, `Nombre`, `Apellido`, `sexo`, `Telefono`, `Direccion`, `Observaciones`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');", pCliente.identidad, pCliente.Nombre, pCliente.Apellido, pCliente.Sexo, pCliente.Telefono, pCliente.Direccion, pCliente.Observaciones), con);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ActualizarCliente(MySqlConnection con, Clientes pCliente)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE `salonbelleza`.`cliente` SET `Nombre`='{1}', `Apellido`='{2}', `sexo`='{3}', `Telefono`='{4}', `Direccion`='{5}', `Observaciones`='{6}' WHERE `idCliente`='{0}';", pCliente.identidad, pCliente.Nombre, pCliente.Apellido, pCliente.Sexo, pCliente.Telefono, pCliente.Direccion, pCliente.Observaciones), con);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int EliminarCliente(MySqlConnection con, Clientes pCliente)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM `salonbelleza`.`cliente` WHERE `idCliente`='{0}';", pCliente.identidad), con);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
