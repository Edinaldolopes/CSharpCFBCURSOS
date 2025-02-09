using System;

class Aula16
{
    static void Main()
    {
        char escolha;
        int tempo = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("\nParaná a Goiás");
            Console.WriteLine("\nEscolha o transporte: [A] Avião | [C] Carro | [O] Ônibus");

            // Leitura e validação do transporte
            escolha = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine(); // Para quebrar a linha após a escolha

            switch (escolha)
            {
                case 'A':
                    tempo = 50;
                    break;
                case 'C':
                    tempo = 480;
                    break;
                case 'O':
                    tempo = 660;
                    break;
                default:
                    tempo = -1;
                    break;
            }

            if (tempo < 0)
            {
                Console.WriteLine("\nTransporte indisponível. Tente novamente.");
            }
            else
            {
                Console.WriteLine("\nPara o transporte escolhido, o tempo é de " +tempo+ " minutos...");
            }

            // Pergunta se deseja escolher outro transporte
            do
            {
                Console.Write("\nDeseja escolher outro transporte? (S/N): ");
                escolha = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine(); // Para quebrar a linha após a escolha

                if (escolha != 'S' && escolha != 'N')
                {
                    Console.WriteLine("\nEntrada inválida! Digite apenas 'S' para SIM ou 'N' para NÃO.");
                }

            } while (escolha != 'S' && escolha != 'N');

        } while (escolha == 'S');

        Console.Clear();
        Console.WriteLine("\nFim do programa.");
    }
}
