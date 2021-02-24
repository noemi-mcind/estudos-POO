using EstudosPOO.Classes;
using System;

namespace EstudosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando objeto a partir da classe
            // ou seja: criando uma instância a partir da classe
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Nome da pessoa: " + pessoa.Nome);
            Console.WriteLine("CPF da pessoa: " + pessoa.Cpf);
            Console.WriteLine("Idade da pessoa: " + pessoa.Idade);
            Console.WriteLine("Pessoa possui CNH: " + pessoa.PossuiCnh);

            // Agora atribuindo os DEFAULTs de cada um NÃO muda o que foi exibido acima.
            pessoa.Nome = default(string);
            pessoa.Cpf = default(int);
            pessoa.Idade = default(int);
            pessoa.PossuiCnh = default(bool);

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Depois das atribuições aos atributos com DEFAULT");
            Console.WriteLine("Nome da pessoa: " + pessoa.Nome);
            Console.WriteLine("CPF da pessoa: " + pessoa.Cpf);
            Console.WriteLine("Idade da pessoa: " + pessoa.Idade);
            Console.WriteLine("Pessoa possui CNH: " + pessoa.PossuiCnh);

            // Agora atribuindo valores reais.
            pessoa.Nome = "Gabriel Vicente";
            pessoa.Cpf = 28936718290;
            pessoa.Idade = 24;
            pessoa.PossuiCnh = true;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Depois das atribuições aos atributos com VALORES reais");
            Console.WriteLine("Nome da pessoa: " + pessoa.Nome);
            Console.WriteLine("CPF da pessoa: " + pessoa.Cpf);
            Console.WriteLine("Idade da pessoa: " + pessoa.Idade);
            Console.WriteLine("Pessoa possui CNH: " + pessoa.PossuiCnh);

            // CRIAR 3 CLASSES, com varios atributos e instanciar objetos abaixo:
            // CONTINUE A LIÇÃOZINHA A PARTIR DAQUI LEK:

            //...

            // clase 1: animal

            // Instanciando objeto a partir da classe 
            // ou seja: criando uma instância a partir da classe
            Animal animal = new Animal();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Raça do animal: " + animal.Raca);
            Console.WriteLine("Altura do animal: " + animal.Altura);
            Console.WriteLine("Idade do animal: " + animal.Idade);

            // Agora atribuindo os DEFAULTs de cada um NÃO muda o que foi exibido acima.
            animal.Raca = default(string);
            animal.Altura = default(int);
            animal.Idade = default(int);

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Depois das atribuições aos atributos com DEFAULT");
            Console.WriteLine("Raça do animal: " + animal.Raca);
            Console.WriteLine("Altura do animal: " + animal.Altura);
            Console.WriteLine("Idade do animal: " + animal.Idade);

            // Agora atribuindo valores REAIS.
            animal.Raca = "Pastor Alemão";
            animal.Altura = 60;
            animal.Idade = 9;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Depois das atribuições aos atributos com VALORES reais");
            Console.WriteLine("Raça do animal: " + animal.Raca);
            Console.WriteLine("Altura do animal: " + animal.Altura);
            Console.WriteLine("Idade do animal: " + animal.Idade);

            //Classe 2: Carro

            // Instanciando objeto a partir da classe 
            // ou seja: criando uma instância a partir da classe
            Carro carro = new Carro();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Marca do carro: "  + carro.Marca);
            Console.WriteLine("Preço do carro: " + carro.Preco);
            Console.WriteLine("Cor do carro: " + carro.Cor);

            // Agora atribuindo os DEFAULTs de cada um NÃO muda o que foi exibido acima.
            carro.Marca = default(string);
            carro.Preco = default(int);
            carro.Cor = default(string);


            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Depois das atribuições aos atributos com DEFAULT");
            Console.WriteLine("Marca do carro: " + carro.Marca);
            Console.WriteLine("Preço do carro: " + carro.Preco);
            Console.WriteLine("Cor do carro: " + carro.Cor);


            // Agora atribuindo valores REAIS.
            carro.Marca = "Chevrolet";
            carro.Preco = 60590;
            carro.Cor = "Branco";

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Depois das atribuições aos atributos com VALORES reais");
            Console.WriteLine("Marca do carro: " + carro.Marca);
            Console.WriteLine("Preço do carro: " + carro.Preco);
            Console.WriteLine("Cor do carro: " + carro.Cor);


            // Classe 3: Movel

            // Instanciando objeto a partir da classe
            // ou seja: criando uma instância a partir da classe

            Movel movel = new Movel();

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Tipo da madeira do movel: " + movel.Madeira);
            Console.WriteLine("Largura do movel: " + movel.Largura);
            Console.WriteLine("Altura do movel: " + movel.Altura);
            Console.WriteLine("Cor do movel: " + movel.Cor);

            // Agora atribuindo os DEFAULTs de cada um NÂO muda o que foi exibido acima
            movel.Madeira = default(string);
            movel.Largura = default(int);
            movel.Altura = default(int);
            movel.Cor = default(string);

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Depois das atribuições aos atributos com DEFAULT");
            Console.WriteLine("Tipo da madeira do movel: " + movel.Madeira);
            Console.WriteLine("Largura do movel: " + movel.Largura);
            Console.WriteLine("Altura do movel" + movel.Altura);
            Console.WriteLine("Cor do movel: " + movel.Cor);

            // Agora atribuindo valores REAIS

            movel.Madeira = "Mogno";
            movel.Largura = 362;
            movel.Altura = 90;
            movel.Cor = "Vermelho";

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Depois das atribuições aos atributos com VALORES reais");
            Console.WriteLine("Tipo de madeira do movel: " + movel.Madeira);
            Console.WriteLine("Largura do movel: " + movel.Largura);
            Console.WriteLine("Altura do movel: " + movel.Altura);
            Console.WriteLine("Cor do movel: " + movel.Cor);


            
            Console.Read();

   

        }
    }
}
