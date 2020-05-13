using System;

namespace ExcCkasseAbstrata2 {
    class Pfisica : Contribuinte {
        protected string cpf;

        public Pfisica (string nome, double rendaBruta, string cpf) : base (nome, rendaBruta) {
            this.cpf = cpf;

        }
        public override double calcImposto () 
        {
            if (getRendaBruta () < 1400)
                return 0;
            else if (getRendaBruta () < 2100)
                return (getRendaBruta () - 100) * 0.10;
            else if (getRendaBruta () < 2800)
                return (getRendaBruta () - 270) * 0.15;
            else if (getRendaBruta () < 3600)
                return (getRendaBruta () - 500) * 0.25;
            else
                return (getRendaBruta () - 700) * 0.30;
        }

    }
}