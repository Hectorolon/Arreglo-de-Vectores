using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuradeArreglo
{
    public partial class Form1 : Form
    {
        Inventario inventario;
        public Form1()
        {
            inventario = new Inventario(15);
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int precio = Convert.ToInt32(txtPrecio.Text);
            inventario.agregar(new Producto(codigo, txtNombre.Text, txtDescripcion.Text,
                cantidad, precio));
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = inventario.listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int posicion = Convert.ToInt32(txtEliminar.Text);
            inventario.eliminar(posicion);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtbuscar.Text);
            Producto buscar = inventario.buscar(codigo);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int posicion = Convert.ToInt32(txtInsertar.Text);
            int codigo = Convert.ToInt32(txtCodigo.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int precio = Convert.ToInt32(txtPrecio.Text);
            inventario.insertar(posicion, new Producto(codigo,
                txtNombre.Text, txtDescripcion.Text, cantidad,
                precio));
        }
    }
}
