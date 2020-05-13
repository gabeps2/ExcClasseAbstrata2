using System;

namespace ExcCkasseAbstrata2
{
    class Pjuridica:Contribuinte
    {
        protected string cpnj;

        public Pjuridica(string nome, double rendaBruta, string cpnj):base(nome, rendaBruta)
        {
            this.cpnj = cpnj;
        }

        public override double calcImposto()
        {
            return getRendaBruta()*0.10;
        }
    }
}