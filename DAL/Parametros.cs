using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Parametros
    {
        public static byte IntentosFallidos()
        {
            var bd = new BD();
            var parametro = bd.Parametros.SingleOrDefault(p => p.IdParametro == (byte)EL.Enums.eParametro.IntentosFallidos);
            if (parametro != null)
            {
                return byte.Parse(parametro.Valor);
            }
            return 0;
        }
        public static string Parametro(byte idParametro)
        {
            var bd = new BD();
            var parametro = bd.Parametros.SingleOrDefault(p => p.IdParametro == idParametro);
            if (parametro != null)
            {
                return parametro.Valor;
            }
            return string.Empty;
        }
    }
}
