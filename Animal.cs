using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosPOO.Classes
{
    // Classes: Representação de elementos do mundo real
    public class Animal
    {
        // Atributos: características dos elementos

        // Default: significa "PADRÂO"

        // valor padrão de strings é null, que é a mesma coisa que default(string)
        // default(string) = null

        // get = obter/ ler
        // set = definir
        public string Raca { get; set; }
        

        // valor padrão de int é 0, que é a mesma coisa que default(int)
        // default(int) = 0
        public int Altura { get; set; }


        // valor padrão de int é 0, que é amesma coisa que default(int)
        // default(int) = 0
        public int Idade { get; set; }
        
    }
}
