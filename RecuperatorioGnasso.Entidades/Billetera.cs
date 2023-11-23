using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioGnasso.Entidades
{
    public class Billetera
    {
        private List<Moneda> monedas;

        public Billetera()
        {
            monedas = new List<Moneda>();
        }

        public static bool operator ==(Billetera billetera, Moneda moneda )
        {
            foreach (var mon in billetera.monedas)
            {
                if (mon == moneda)
                {
                    return true;
                }
            }
            return false;

        }

        public static bool operator !=(Billetera billetera, Moneda moneda)
        {
            return !(billetera == moneda);
        }

        public static bool operator +(Moneda mon, Billetera billetera)
        { 
            if (billetera!= mon)
            {
                billetera.monedas.Add(mon);
                return true;
            }
            else 
            {

            }

          
            return false;

        }





        //public static bool operator -(Moneda moneda, Billetera billetera)
        //{
        //    if (billetera.monedas.Contains(moneda))
        //    {
        //        if (moneda.GetCantidad() < billetera.monedas)
        //        {

        //        }
        //    }

        //}


    }
}
