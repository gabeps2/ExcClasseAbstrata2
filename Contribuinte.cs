using System;

namespace ExcCkasseAbstrata2
{
    abstract class Contribuinte
    {
        double rendaBruta;
        string nome;

        public Contribuinte(string nome, double rendaBruta)
        {
            this.nome = nome;
            this.rendaBruta = rendaBruta;
        }
        public string getNome()
        {
            return nome;
        }
        
        protected double getRendaBruta()
        {
            return rendaBruta;
        }

        public abstract double calcImposto();
        public static Contribuinte[] listaContr()
        {
            Contribuinte[] lst = new Contribuinte[6];
            lst[0] = new Pfisica("Joao Santos",3000.00,"11111");
            lst[1] = new Pjuridica("Lojas AA",150000.00,"10055");
            lst[2] = new Pfisica("Maria Soares",5000.00,"22222");
            lst[3] = new Pjuridica("Supermercados B",2000000.00,"10066");
            lst[4] = new Pfisica("Joao Santos",3000.00,"33333");
            lst[5] = new Pjuridica("Posto XX",500000.00,"10077");
            return lst;
        }
    }
}