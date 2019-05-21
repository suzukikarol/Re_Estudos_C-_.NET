using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();
            idades.Add(1);
            idades.Add(23);
            idades.Add(32);

            //idades.AddRange(1,1,2,3,4,13);

            ListExtensions.AdicionarVarios(idades, 23 ,12);




            for (int i = 0; i < idades.Count; i++)
            {
                //mostra cada valor de idade digitada acima
                Console.WriteLine(idades[i]);
                Console.ReadLine();
            }


        }
    }
}
