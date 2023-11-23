using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioGnasso.Entidades
{
    public class Dolar : Moneda
    {
        private static decimal cotizacionCompra;
        private static decimal cotizacionVenta;

        
        static Dolar()
        {
            cotizacionCompra = 348.50m;
            cotizacionVenta = 368.50m;
        }
        public Dolar(decimal cantidad) : base(cantidad)
        {
        }

        public decimal CotizacionCompra()
        {
            return cotizacionCompra;
        }

        public decimal CotizacionVenta()
        {
            return cotizacionVenta;
        }

        public override decimal CalcularValorEnDolares()
        {
            return Cantidad;
        }

        public override decimal CalcularValorEnPesos()
        {
           return Cantidad * cotizacionCompra;
        }

        public override string MostrarInfo()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Dolar");
            datos.AppendLine($"Cantidad: {Cantidad}");
            datos.AppendLine($"Valor en pesos: {cotizacionVenta}");

            return datos.ToString();
        }
    }
}
