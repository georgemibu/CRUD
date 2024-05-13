namespace Tienda
{
    public partial class CarritoCompras : Form
    {
        public CarritoCompras()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboProductos.Items.Add("Pantalon");
            cboProductos.Items.Add("Remera");
            cboProductos.Items.Add("Camisa");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = cboProductos.SelectedItem.ToString();
            listCarritoCompras.Items.Add(productoSeleccionado);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precioFinal = 0;
            int itemsProductosCargados = listCarritoCompras.Items.Count;

            for (int i = 0; i < itemsProductosCargados; i++)
            {
                string productoElegido = listCarritoCompras.Items[i].ToString();
                if (productoElegido == "Pantalon")
                {
                    precioFinal += 20;
                }
                if (productoElegido == "Remera")
                {
                    precioFinal += 15;
                }
                if (productoElegido == "Camisa")
                {
                    precioFinal += 17;
                }
            }
            if (txtCodigoDescuento.Text == "Navidad") ;
            {
                precioFinal = precioFinal * 0.9;
            }
            MessageBox.Show("El precio final es " + precioFinal);
        }

        private void txtCodigoDescuento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
