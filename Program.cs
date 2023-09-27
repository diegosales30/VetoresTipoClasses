using System;
using System.Globalization;

namespace Vetores
{
  class Program
  {
    static void Main(string[] args)
    {
      //alocar tamanho do array dinamicamente
      int tamanhoArray = int.Parse(Console.ReadLine());

      //cria vetor do tipo classe -> Product e instancia com a variavel
      Product[] array = new Product[tamanhoArray];

      for (int i = 0; i < tamanhoArray; i++)
      {
        string name = Console.ReadLine();
        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        array[i] = new Product { Nome = name, Preco = price};
      }

      double soma = 0.0;
      for (int i = 0; i < tamanhoArray; i++)
      {
        soma += array[i].Preco;
       
      }

      double avg = soma / tamanhoArray;

      Console.WriteLine("Preço médio = " + avg.ToString("F2", CultureInfo.InvariantCulture));

      

    }
  }
}
