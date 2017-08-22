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
        SqlDataReader reader;
        SqlCommand command;
        public Conexion() {

        }
        public Boolean crear_conexion()
        {
            Boolean respuesta = false;
            try
            {
                //esta cadena se tiene que cambiar por la que les de su base de datos
                conn = new SqlConnection("Data Source=.;Initial Catalog=pinturas;Integrated Security=True;MultipleActiveResultSets=true;");
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
        public SqlDataReader Consultar(String Consulta)
        {
            try
            {
                command = new SqlCommand(Consulta, conn);
                reader = command.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la consulta: " + ex.ToString());
            }
            return reader;
        }

    }
}
