using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosPOO.Classes
{
    // Classe: Representação de elementos do mundo real
    public class Carro
    {
        // Atributos: características dos elementos

        // DEFAULT QUER DIZER PADRAO.

        // Valor padrão de string é null, que é a mesma coisa que default(string)
        // default(string) = null

        // set = definir
        // get = obter/ler
        public string Marca { get; set; }

        // valor padrão de int é 0, que é a mesma coisa que default(int)
        // default(int) = 0
        public int Preco { get; set; }

        // Valor padrão de string é null, que é a mesma coisa que default(string)
        // default(string) = null
        public string Cor { get; set; }

    }
}
