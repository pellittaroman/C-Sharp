using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
  class Program
  {
    static void Main(string[] args)
    {
      int tam;
      Console.Write("Ingrese numero: ");
      tam = int.Parse(Console.ReadLine());
      if(tam>7)
      {
        Console.WriteLine(1);
        Console.WriteLine(2);
        Console.WriteLine(3);
        Console.WriteLine(5);
        Console.WriteLine(7);
      }
      for(int i=0;i<tam;i++)
      {
          if (i%2!=0 && i%3!=0 && i!=1 && i%5!=0 && i%7!=0)
          {
           
            Console.WriteLine(i);
          }
      }
      Console.Read();
    }
  }
}
