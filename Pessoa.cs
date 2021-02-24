using System;

namespace EstudosPOO
{
    // Classe: Representação de elementos do mundo real
    public class Pessoa
    {
        // Atributos: características dos elementos

        // DEFAULT QUER DIZER PADRAO.

        // Valor padrão de string é null, que é a mesma coisa que default(string)
        // default(string) = null

        // set = definir
        // get = obter/ler
        public string Nome { get; set; }


        // valor padrão de int é 0, que é a mesma coisa que default(int)
        // default(int) = 0
        public int Idade { get; set; }


        // valor padrão de int é 0, que é a mesma coisa que default(int)
        // default(int) = 0
        public long Cpf { get; set; }


        // valor padrão de bool é false, que é a mesma coisa de default(bool)
        // default(bool) = false
        public bool PossuiCnh { get; set; }
    }
}
