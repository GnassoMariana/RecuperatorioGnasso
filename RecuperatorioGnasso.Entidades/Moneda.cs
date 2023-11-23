
using System.Text;

namespace RecuperatorioGnasso.Entidades
{
    public abstract class Moneda
    {
        protected decimal cantidad;
        public virtual decimal Cantidad
        {
            get { return cantidad;}
            set 
            { 
                if (cantidad > 0 && cantidad <200)
                {
                    cantidad = value;
                }
            }
        }
        public Moneda(decimal cantidad)
        {
            Cantidad = cantidad;
        }

        public decimal GetCantidad()
        {
            return cantidad;
        }
        public abstract decimal CalcularValorEnDolares();
        public abstract decimal CalcularValorEnPesos();

        public virtual string MostrarInfo()
        {
            return "";
        }

        public static bool operator ==(Moneda a, Moneda b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Moneda a, Moneda b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            return obj.GetType() == this.GetType();  
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}