using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.Extensoes
{
    public static class ListExtensoes<T>
    {
        //criando lista generica
        public static void AdicionarVarios (List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }


        //teste estático pra ver funcionamento do método criado acima
        //nesse caso o T virou um int
        static void Teste ()
        {
            List<int> idades = new List<int>();
            idades.Add(12);
            idades.Add(23);
            idades.Add(65);
            idades.Add(75);
            idades.Add(35);

            ListExtensoes<int>.AdicionarVarios(idades, 2, 3, 4, 65, 35);

            List<string> nomes = new List<string>();

            nomes.Add("Micalateia");
            nomes.Add("Malaquias");

            ListExtensoes<string>.AdicionarVarios(nomes, "Lua vai ", "iluimar ", "os pensamentos ", "dela...");

            //Porem essa classe genérica não pode ser static para ser exteniva

        }
    }
}
