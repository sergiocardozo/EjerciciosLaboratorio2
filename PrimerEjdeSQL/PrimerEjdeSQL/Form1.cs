using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrimerEjdeSQL
{
    public partial class Form1 : Form
    {
        SqlConnection miConexion;//puente
        SqlCommand miComando;//quien lleva la consulta
        SqlDataReader objetOfRead;//quien trae los datos
        public Form1()
        {
            
            miConexion = new SqlConnection("Data Source = .\\SQLEXPRESS; Database = utnfra; Trusted_Connection=True;");
            //trusted_connection credenciales 
            miComando = new SqlCommand();//consultas a la base de datos

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string auxNombre;
            string auxApellido;
            miComando.Connection = miConexion;//termina de unir el puente conexion con el comando
            miComando.CommandType = CommandType.Text;
            miComando.CommandText = "SELECT * FROM Alumnos";
            miConexion.Open();// abre la conexion

            objetOfRead = miComando.ExecuteReader();//hace la consulta y devuelve el dato que necesitamos

            while (objetOfRead.Read())//mientras el objeto que recibe la info.read
            {//se va moviendo de una linea a otra
                auxNombre = objetOfRead["nombre"].ToString();
                auxApellido = objetOfRead["apellido"].ToString();
            
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
