using System;

namespace teste03
{
    class Program
    {
        static void Main()
        {
            int v1, v2, soma;

            string nome;

            Console.Write("Digite seu nome: ");
            nome=Console.ReadLine();
            Console.WriteLine("O nome digitado é:",nome);

            Console.Write("Digite o primeiro valor que deseja somar: ");
            v1=int.Parse(Console.ReadLine());
            
            Console.Write("Digite o segundo valor: ");
            v2=Convert.ToInt32(Console.ReadLine());

            soma=v1+v2;

            Console.WriteLine("O valor de {0} + {1} é: {2} ", v1,v2,soma);

           
        }
    }
}
