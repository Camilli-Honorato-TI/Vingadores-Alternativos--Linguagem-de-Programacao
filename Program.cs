using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Grupo: Vingadores Alternativos
            //Camilli,Matheus, Leonardo, Yasmin
            //Atividade: Fazer as 4 operações

            string nome;
            int n1, n2, soma, subtracao, divisao, multiplicacao;
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;
            subtracao = n1 - n2;
            multiplicacao = n1 * n2;
            divisao = n1 / n2;

            Console.Write(nome + "\n a soma de {0} e {1} é {2}", n1, n2, soma);
            Console.Write("\n a subtração de {0} e {1} é {2}", n1, n2, subtracao);
            Console.Write("\n a divisão de {0} e {1} é {2}", n1, n2, divisao);
            Console.Write("\n a multiplicação de {0} e {1} é {2}", n1, n2, multiplicacao);
            Console.ReadKey();


        }
    }
}
