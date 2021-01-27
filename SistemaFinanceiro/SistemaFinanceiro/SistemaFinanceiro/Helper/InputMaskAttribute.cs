using System;

namespace SistemaFinanceiro.Helper
{
    public class InputMaskAttribute : Attribute
    {
        public string Mask { get; set; }
        public bool IsReverso { get; set; }
        public InputMaskAttribute(string mask)
        {
            Mask = mask;
            IsReverso = false;
        }
    }
}
