using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int tam;
            int suma = 0;
            int sumados = 0;
            Console.WriteLine("Ingrese numero maximo a buscar, centro numerico ");
            tam = int.Parse(Console.ReadLine());
            Console.Clear();
            for(int i=1;i<tam;i++)
            {
                suma = 0;
                sumados = 0;
                for(int j=1;j<1000000 ;j++)

                {
                    if(i>j)
                    {
                        suma = suma + j;
                    }
                    else
                    {
                        if(i<j)
                        {
                            sumados = sumados + j;
                        }
                    }
                    if(sumados>suma)
                    {
                        break;

                    }
                    else
                    {
                        if(sumados==suma&& suma!=0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
