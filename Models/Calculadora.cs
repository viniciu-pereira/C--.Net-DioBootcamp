using Example.Models;
using System;

namespace Example.Models
{
	public class Calculadora
    {
		public int Somar(int x, int y)
		{
			int soma = x + y;
			Console.WriteLine($"{x} + {y} = {soma}");
			return soma;
		}

		public int Subtrair(int x, int y)
		{
			int subtracao = x - y;
			Console.WriteLine($"{x} - {y} = {subtracao}");
			return subtracao;
		}

        public int Multiplicar(int x, int y)
        {
            int multiplicacao = x * y;
            Console.WriteLine($"{x} * {y} = {multiplicacao}");
			return multiplicacao;
        }

		public int Dividir(int x, int y)
		{
			int divisao = x / y;
			Console.Write($"{x} / {y} = {divisao}");
			return divisao;
		}
	
    }
}