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

namespace EjSQL
{
    public partial class Form1 : Form
    {
        SqlConnection miConexion;//puente
        //quien lleva la consulta
        SqlDataReader objetOfRead;//quien trae los datos
        DataTable miTabla;
        public Form1()
        {
            miConexion = new SqlConnection("Data Source = DESKTOP-RBE9LU4\\SQLEXPRESS; Database = utnfra; Trusted_Connection=True;");
            //trusted_connection credenciales 
            
            miTabla = new DataTable();
            InitializeComponent();
        }        
        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand miComando = new SqlCommand();//consultas a la base de datos    
                miComando.Connection = miConexion;//termina de unir el puente conexion con el comando
                miComando.CommandType = CommandType.Text;
                miComando.CommandText = "SELECT * FROM Alumnos WHERE curso = @cursoAFiltrar";//parametrizado

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                miTabla.Rows.Clear();
                miComando.Parameters.Add(new SqlParameter("cursoAFiltrar", int.Parse(textBox1.Text)));
                if (miConexion.State != ConnectionState.Open)
                    miConexion.Open();// abre la conexion

                //TODO ANTES DEL EXECUTEREADER
                objetOfRead = miComando.ExecuteReader();//hace la consulta y devuelve el dato que necesitamos

                miTabla.Load(objetOfRead);
                dataGridView1.DataSource = miTabla;

                string consulta = "INSERT INTO Alumnos VALUES(233213,'Sergio','Cardozo',2)";
                
                #region MyRegion

                //while (objetOfRead.Read())//mientras el objeto que recibe la info.read
                //{//se va moviendo de una linea a otra
                //    auxNombre = objetOfRead["nombre"].ToString();
                //    auxApellido = objetOfRead["apellido"].ToString();

                //} 
                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                miConexion.Close();//si no cierro tira error porque la conexion esta abierta
            }
        }
    }
}
