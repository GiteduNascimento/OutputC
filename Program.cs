using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Sobre__Formatação_de_SAIDA_no_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double valorCompra = 5.50;
            double valorVenda;
            double lucro = 0.1;
            string produto = "Pastel";

            valorVenda = valorCompra + (valorCompra * lucro);

            Console.WriteLine("Produto.....:{0,15}",produto);
            Console.WriteLine("Val.Compra..:{0,15:c}", valorCompra);
            Console.WriteLine("Lucro.......:{0,15:p}", lucro);
            Console.WriteLine("Val.Venda...:{0,15:c}", valorVenda);
            Console.ReadLine();
        }
    }
}
int n1, n2, n3;

n1 = 10;
n2 = 20;
n3 = 30;
//O "\n" tem a função de quebrar a linha e por uma linha a baixo.
//O "\t" tem a função de adcionar um espaço entre as informações.
Console.WriteLine("\nn1=\t{0}\nn2=\t{1}\nn3=\t{2}\n", n1, n2, n3);
Console.ReadLine();
