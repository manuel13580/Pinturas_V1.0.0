using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Pinturas_V1._0._0
{
    public class Conexion
    {
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;
        public Conexion() {

        }
        public Boolean crear_conexion()
        {
            Boolean respuesta = false;
            try
            {
                //esta cadena se tiene que cambiar por la que les de su base de datos
                conn = new SqlConnection("Data Source=.;Initial Catalog=practica1;Integrated Security=True");
                conn.Open();
                MessageBox.Show("Conectado");
                respuesta = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexion Fallida: " + ex.ToString());
            }
            return respuesta;
        }
    }
}
