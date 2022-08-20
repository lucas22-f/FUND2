using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FUND2.Models
{
    internal class Cconexion
    {

        MySqlConnection conex = new MySqlConnection();
        static string server = "localhost";
        static string database = "pruebac";
        static string username = "root";
        static string password = "elfigue";
        static string port ="3306";
        string cadenaConex = "server=" + server + ";" + "port=" + port + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database="+database+";";


        public List<Cerveza> GetCervezas(){ // ESTE ES NUESTRO METODO GET QUE TRAE TODA LA INFO BREO

            List<Cerveza> listCervezas = new List<Cerveza>();
            string query = "select nombre, marca, alcohol, cantidad "+"from cerveza";
            using (MySqlConnection conection = new MySqlConnection(cadenaConex))
            {
                MySqlCommand command = new MySqlCommand(query, conection);

                conection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int cantidad = reader.GetInt32(3);
                    string nombre = reader.GetString(0);
                    Cerveza cerveza = new Cerveza(cantidad, nombre);
                    cerveza.Alcohol = reader.GetInt32(2);
                    cerveza.Marca = reader.GetString(1);


                    listCervezas.Add(cerveza);
                }
                reader.Close();
                conection.Close();
            }
            return listCervezas;
        }

        public void Add(Cerveza cerveza){//Este es nuestro metodo para Insertar una Nueva Cerveza Anashei 
            string query = "insert into cerveza(nombre, marca, alcohol, cantidad) "+ "values(@nombre, @marca, @alcohol, @cantidad)";

            using(var conection = new MySqlConnection(cadenaConex))
            {
                var command = new MySqlCommand(query,conection);
                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);

                conection.Open();
                command.ExecuteNonQuery();
                conection.Close();





            }

        }

        public void Edit(Cerveza cerveza, int Id)
        {
            string query = "update cerveza set nombre=@nombre, marca=@marca, alcohol=@alcohol, cantidad=@cantidad where id=@id";

            using (var conection = new MySqlConnection(cadenaConex))
            {
                var command = new MySqlCommand(query, conection);
                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);
                command.Parameters.AddWithValue("@id", Id);

                 
                conection.Open();
                command.ExecuteNonQuery();
                conection.Close();





            }

        }

        public void Delete(int Id)
        {
            string query = "delete from cerveza where id=@id";

            using (var conection = new MySqlConnection(cadenaConex))
            {
                var command = new MySqlCommand(query, conection);
                command.Parameters.AddWithValue("@id", Id);


                conection.Open();
                command.ExecuteNonQuery();
                conection.Close();





            }

        }

    }
}
