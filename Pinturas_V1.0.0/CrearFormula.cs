using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pinturas_V1._0._0
{
    public partial class CrearFormula : Form
    {
        Conexion nueva = new Conexion();
        public CrearFormula()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrearFormula_Load(object sender, EventArgs e)
        {
            
            if (nueva.crear_conexion())
            {
                SqlDataReader reader;
                reader = nueva.Consultar("select * from Medida;");
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[1].ToString());
                    comboBox1.Text = reader[1].ToString();
                }
                reader = nueva.Consultar("select * from Vehiculo;");
                while (reader.Read())
                {
                    comboautos.Items.Add(reader[2].ToString() + "-"+reader[1].ToString()+"-"+ reader[3].ToString());
                    comboautos.Text = reader[2].ToString() + "-" + reader[1].ToString() + "-" + reader[3].ToString();
                }
                reader = nueva.Consultar("select * from Medida;");
                while (reader.Read())
                {
                    combomedida.Items.Add(reader[1].ToString());
                    combomedida.Text = reader[1].ToString();
                }
            }
            else {

            } 
            
        }
    }
}
