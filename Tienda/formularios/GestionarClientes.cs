using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda.dao;
using Tienda.modelos;

namespace Tienda
{
    public partial class GestionarClientes : Form
    {
        public GestionarClientes()
        {
            InitializeComponent();
        }

        private void GestionarClientes_Load(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void actualizarLista()
        {
            Clientedao baseDeDatos = new Clientedao();
            List<Cliente> listadb = baseDeDatos.ObtenerlistadoClientes();

            listClientes.Items.Clear();
            for (int i = 0; i < listadb.Count; i++)
            {
                Cliente cliente = listadb[i];
                listClientes.Items.Add(cliente);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.TarjetaCredito = txtTarjetaCredito.Text;

            if(lblId.Text != "")
            {
                cliente.Id = lblId.Text;
            }

            Clientedao baseDeDatos = new Clientedao();
            baseDeDatos.Guardar(cliente);
            actualizarLista();

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;


            Clientedao baseDeDatos = new Clientedao();
            baseDeDatos.Eliminar(cliente);
            actualizarLista();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono;
            txtTarjetaCredito.Text = cliente.TarjetaCredito;
            lblId.Text = cliente.Id;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text ="";
            txtTarjetaCredito.Text = "";
            lblId.Text = "";
        }
    }
}
