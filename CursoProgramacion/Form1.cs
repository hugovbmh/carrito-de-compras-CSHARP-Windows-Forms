using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoProgramacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = cboProductos.SelectedItem.ToString();
            listaProductos.Items.Add(productoSeleccionado);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboProductos.Items.Add("Pantalon");
            cboProductos.Items.Add("Camisa");
            cboProductos.Items.Add("Zapatos");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precioFinal = 0;
            var totalProductosCargados = listaProductos.Items.Count;
            for (int i = 0; i < totalProductosCargados; i++)
            {
                string productoElegido = listaProductos.Items[i].ToString();
                if (productoElegido == "Pantalon")
                {
                    precioFinal += 20;
                }
                else if (productoElegido == "Camisa")
                {
                    precioFinal += 35;
                }
                else if (productoElegido == "Zapatos")
                {
                    precioFinal += 24;
                }
            }
            if (txtCodigoDescuento.Text == "NAVIDAD")
            {
                precioFinal = precioFinal * 0.90;
            }
            MessageBox.Show("El precio final es: $" + precioFinal);
        }
    }
}
