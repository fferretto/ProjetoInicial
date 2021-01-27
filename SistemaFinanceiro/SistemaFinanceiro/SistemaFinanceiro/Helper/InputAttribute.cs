using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Helper
{
    public class InputAttributeAux : Attribute
    {
        public string Final { get; set; }
        public string Inicio { get; set; }
        public string ValorMaximo { get; set; }
        public string ValorMinimo { get; set; }
        public string Type { get; set; }

        public bool TemFinal
        {
            get { return !String.IsNullOrWhiteSpace(Final); }
        }
        public bool TemInicio
        {
            get { return !String.IsNullOrWhiteSpace(Inicio); }
        }
        public bool TemValorMaximo
        {
            get { return !String.IsNullOrWhiteSpace(ValorMaximo); }
        }
        public bool TemValorMinimo
        {
            get { return !String.IsNullOrWhiteSpace(ValorMinimo); }
        }
        public bool TemTypo
        {
            get { return !String.IsNullOrWhiteSpace(Type); }
        }
    }
}
