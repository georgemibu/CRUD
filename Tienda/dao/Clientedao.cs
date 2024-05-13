using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using Tienda.modelos;

namespace Tienda.dao
{
    internal class Clientedao
    {
        public MySqlConnection Conectar()
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "";
            string baseDeDatos = "clientes";

            string cadenaConexion = "Database=" + baseDeDatos + "; Data source=" + servidor + "; User id=" + usuario + "; Password=" + password + "";
            MySqlConnection conexionDB = new MySqlConnection(cadenaConexion);
            conexionDB.Open();

            return conexionDB;

        }

        public List<Cliente> ObtenerlistadoClientes()
        {
            List<Cliente> lista = new List<Cliente>();

                string consulta = "SELECT * FROM `clientes`";
                MySqlCommand comando = new MySqlCommand(consulta);
                comando.Connection = Conectar();
                MySqlDataReader lectura = comando.ExecuteReader();



                while (lectura.Read())
                {
                    Cliente cliente= new Cliente();
                    cliente.Id = lectura.GetInt32("id").ToString();

                    cliente.Nombre = lectura.GetString("nombre");
                    cliente.Apellido = lectura.GetString("apellido");
                    cliente.Telefono = lectura.GetString("telefono");
                    cliente.TarjetaCredito = lectura.GetString("tarjeta_de_credito");
                    lista.Add(cliente); 


            }
            comando.Connection.Close();
            return lista;
        }

        internal void Eliminar(Cliente cliente)
        {
            string consulta = "DELETE FROM `clientes` WHERE `clientes`.`id` = "+ cliente.Id+ ";";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();


            comando.Connection.Close();
        }

        public void Guardar(Cliente cliente)
        {
            if (cliente.Id  == null)
            {
                insert(cliente);
            } else
            {
                update(cliente);
            }
        }
        private void insert(Cliente cliente)
        {
            string consulta = "INSERT INTO `clientes` (`id`, `nombre`, `apellido`, `telefono`, `tarjeta_de_credito`) VALUES (NULL, '" + cliente.Nombre + "', '" + cliente.Apellido + "', '" + cliente.Telefono + "', '" + cliente.TarjetaCredito + "');";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();


            comando.Connection.Close();
        }
        private void update(Cliente cliente)
        {
            string consulta = "UPDATE `clientes` SET `nombre` = '" + cliente.Nombre + "', `apellido` = '" + cliente.Apellido + "', `telefono` = '" + cliente.Telefono + "', `tarjeta_de_credito` = '" + cliente.TarjetaCredito + "' WHERE `clientes`.`id` = " + cliente.Id + ";";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();


            comando.Connection.Close();
        }
    }
}
