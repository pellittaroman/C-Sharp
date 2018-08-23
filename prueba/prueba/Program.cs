using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable;
            int suma=0;
            int flag = 0;
            int max=0;
            int min=999999;
            int promedio = 0;
            for(int i=0;i<5;i++)
            {
                Console.Write("Ingrese numero: ");
                variable = int.Parse (Console.ReadLine());
                suma = suma + variable;
                if (variable>max || flag==0)
                {
                    max = variable;

                }
                if(variable<min|| flag ==0)
                {
                    min = variable;
                    flag = 1;
                }
            }


            promedio = suma / 5;

            Console.Clear();
            Console.Write("El maximo es ");
            Console.WriteLine(max);
            Console.Write("El minimo es ");
            Console.WriteLine(min);
            Console.Write("El promedio es ");
            Console.WriteLine(promedio);


            Console.ReadKey();
            


































        }
    }
}
