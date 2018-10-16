using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductoWilliam
{
    public partial class FCalcularPro : Form
    {

        // Nuevo Objeto

        ProductoWilliam producto = new ProductoWilliam();
        Calculos calculos = new Calculos();




        public FCalcularPro()
        {
            InitializeComponent();

            tCantidad.KeyPress += validarCampos;
            tValorU.KeyPress += validarCampos;




        }

        // Boton para salir 

        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // textbox con el valor unitario

        private void tValorU_TextChanged(object sender, EventArgs e)
        {
            if (tValorU.Text.Equals(""))
            {
                tValorU.Text = "";

            }

            else
            {
                producto.ValorPro = Convert.ToDouble(this.tValorU.Text);
            }
        }

        //Boton calcular 

        private void bCalcular_Click(object sender, EventArgs e)
        {

            this.tTotalIva.Text = Convert.ToString(calculos.calcularIva(producto.ValorPro, calculos.Cantidad));

            this.tTotal.Text = Convert.ToString(calculos.TotalPagar(producto.ValorPro, calculos.Cantidad));

        }

        // Textbox con la cantidad del producto

        private void tCantidad_TextChanged(object sender, EventArgs e)
        {

            if (tCantidad.Text.Equals(""))
            {
                tCantidad.Text = "";
            }
            else
            {
                calculos.Cantidad = int.Parse(this.tCantidad.Text);
            }
        }

        // metodo para validar campos 

        public void validarCampos(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar < 48 || e.KeyChar > 57 || e.KeyChar == 8)
            {

                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;

            }
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {

            tCantidad.Text = "";

            tCodigo.Text = "";
            tValorU.Text = "";
            tTotal.Text = "";
         
           
           tNombrePro.Text = "";
           
            this.tTotalIva.Text = "";
            this.tTotal.Text = "";
   

        }





    }


}

