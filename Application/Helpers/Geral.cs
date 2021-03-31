using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Helpers
{
    public class Geral
    {
        public static string FormataCPFCnPj(string val)
        {
            if (val == null)
                return "";

            val = val ?? "";
            if (val.Length == 13) val = "0" + val;
            string valor = val.Replace("-", "").Replace("/", "").Replace(" ", "").Replace("\\", "").Replace(".", "");

            if (valor.Length == 11)
                valor = Convert.ToUInt64(valor).ToString(@"000\.000\.000\-00");
            else if (valor.Length == 14)
                valor = Convert.ToUInt64(valor).ToString(@"00\.000\.000\/0000\-00");

            return valor;

        }
        public static string RemoveCaracteres(string val)
        {
            string valor = val.Replace("-", "").Replace("/", "").Replace(" ", "").Replace("\\", "").Replace(".", "").Replace(",", "");
            return valor;
        }

    }
}
