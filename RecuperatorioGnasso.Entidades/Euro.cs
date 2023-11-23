using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioGnasso.Entidades
{
    public class Euro : Moneda
    {
        private static decimal cotizacionCompra;
        private static decimal cotizacionVenta;
        private static decimal cotizacionRespectoAlDolar;

        static Euro()
        {
            cotizacionCompra = 371.17m;
            cotizacionVenta = 391.45m;
            cotizacionRespectoAlDolar = 1.07m;
        }
        public Euro(decimal cantidad) : base(cantidad)
        {
        }

        public decimal GetCotizacionVenta()
        {
            return cotizacionVenta;
        }

        public decimal GetCotizacionCompra()
        {
            return cotizacionCompra;
        }

        public decimal GetCotizacionRespectoDolar()
        {
            return cotizacionRespectoAlDolar;
        }
        public override decimal CalcularValorEnDolares()
        {
          return   Cantidad * cotizacionRespectoAlDolar;
        }

        public override decimal CalcularValorEnPesos()
        {
            return Cantidad * cotizacionCompra;
        }

        public override string MostrarInfo()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Euro");
            datos.AppendLine($"Cantidad: {Cantidad}");
            datos.AppendLine($"Valor en dolares: {CalcularValorEnDolares()}");
            datos.AppendLine($"Valor en pesos: {CalcularValorEnPesos()}");

            return datos.ToString();
        }
    }
}
