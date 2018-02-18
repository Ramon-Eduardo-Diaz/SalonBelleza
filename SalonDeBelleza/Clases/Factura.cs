using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SalonDeBelleza.Clases
{
    class Factura
    {
        public int idFactura { get; set; }
        public String FechaFactura { get; set; }
        public int IdDetalle { get; set; }
        public int IdServicio { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public decimal subtotal { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        public String TipoPago { get; set; }

        public Factura() { }

        public static int AgregarFactura(MySqlConnection conexion, Factura pFactura)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO `salonbelleza`.`factura` (`idFactura`, `FechaFactura`, `Empleado_idEmpleado`, `Servicios_idServicios`, `Cliente_idCliente`, `SubTotal`, `Impuesto`, `Total`, `TipoPago`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}','{8}');", pFactura.idFactura, pFactura.FechaFactura, pFactura.IdEmpleado, pFactura.IdServicio, pFactura.IdCliente, pFactura.subtotal, pFactura.impuesto, pFactura.total,pFactura.TipoPago), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ActualizarFactura(MySqlConnection conexion, Factura pFactura)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE `salonbelleza`.`factura` SET `FechaFactura`='{1}', `Empleado_idEmpleado`='{2}', `Servicios_idServicios`='{3}', `Cliente_idCliente`='{4}', `SubTotal`='{5}', `Impuesto`='{6}', `Total`='{7}', `TipoPago`='{8}' WHERE `idFactura`='{0}';", pFactura.idFactura, pFactura.FechaFactura, pFactura.IdEmpleado, pFactura.IdServicio, pFactura.IdCliente, pFactura.subtotal, pFactura.impuesto, pFactura.total, pFactura.TipoPago), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int EliminarFactura(MySqlConnection conexion, Factura pFactura)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM `salonbelleza`.`factura` WHERE `idFactura`='{0}';", pFactura.idFactura), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
