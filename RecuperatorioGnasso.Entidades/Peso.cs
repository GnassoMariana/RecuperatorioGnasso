using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioGnasso.Entidades
{
    public class Peso : Moneda
    {
        private static decimal cotizacionRespectoAlDolar;
        public override decimal Cantidad 
        {
            get { return cantidad; }
            set
            {
                if(cantidad > 0)
                {
                    cantidad = value;
                }
            }
        }
        static Peso()
        {
            cotizacionRespectoAlDolar = 0m;
        }
        public Peso(decimal cantidad) : base(cantidad)
        {
        }

        public override decimal CalcularValorEnDolares()
        {
            return Cantidad * cotizacionRespectoAlDolar;
        }

        public override decimal CalcularValorEnPesos()
        {
            return Cantidad;
        }

        public override string MostrarInfo()
        { 
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Peso");
            datos.AppendLine($"Contidad: {Cantidad}");
            datos.AppendLine($"Valor en dolares: {CalcularValorEnDolares()}");

            return datos.ToString();

        }
    }
}
