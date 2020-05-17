using System;

namespace ExcClasseAbstrata2
{
    class Teste
    {
        public static void Questao1()
        {
            Contribuinte[] lst = Contribuinte.listaContr();

            for(int i=0;i<6;i++)
            {
                System.Console.WriteLine($"\nNome: {lst[i].getNome()} \nImposto: {lst[i].calcImposto()}");
            }
        }
    }
}