
using System;

class Aula07 {
    static void Main() {
        while (true) { // Loop para permitir várias execuções
            Console.Clear(); // Limpa a tela a cada nova execução

            Console.WriteLine("=== CADASTRO DE USUÁRIO ===\n");

            Console.Write("Digite seu nome.....: ");
            // Variável
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade....: ");
            // Variável
            int idade;
            while (!int.TryParse(Console.ReadLine(), out idade)) {
                Console.Write("Entrada inválida! Digite um número para idade: ");
            }

            Console.Write("Digite seu apelido..: ");
            // Variável
            string apelido = Console.ReadLine();

            Console.WriteLine("\n....SEUS DADOS FORAM REGISTRADOS NO BANCO....\n");

            
            Console.WriteLine("NOME.....:  " + nome);
            Console.WriteLine("IDADE....:  " + idade + " anos"); 
            Console.WriteLine("APELIDO..:  " + apelido);

            Console.WriteLine("\nDeseja cadastrar outro usuário? (S/N)");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta != "S") break; // Sai do loop se o usuário digitar algo diferente de "S"
        }
    }
}
