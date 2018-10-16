using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoWilliam
{
    class Calculos
    {

        // Variables 
        private int cantidad;
        private double iva;
        private double total;
        
        //variables get y set
        public int Cantidad { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }



        // Declara nuevo objeto
        ProductoWilliam producto = new ProductoWilliam();



        // Metodos


        // Metodo para calcular el iva 
        public double calcularIva(double valor, int cant)
        {
            iva =  (valor * 16 / 100);
           
            return cant * iva;

        }

        // Metodo para calcular el total a pagar 

        public double TotalPagar(double ValorPagar, int cant )
        {
            total = cant * (ValorPagar + iva);

            return total;
        }

            




    }
}
