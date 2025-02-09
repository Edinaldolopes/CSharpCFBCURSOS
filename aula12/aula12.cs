using System;

class Aula12
{
    static void Main()
    {
        while (true) // Loop infinito até que o usuário decida parar
        {
            string mensagemErro = "\nEntrada inválida! Digite um número válido para a nota: ";
            int n1, n2, n3, n4, res;
            res = n1 = n2 = n3 = n4 = 0;

            // Captura das notas
            Console.Write("\nDigite nota 1..: ");
            while (!int.TryParse(Console.ReadLine(), out n1)) Console.Write(mensagemErro);

            Console.Write("Digite nota 2..: ");
            while (!int.TryParse(Console.ReadLine(), out n2)) Console.Write(mensagemErro);

            Console.Write("Digite nota 3..: ");
            while (!int.TryParse(Console.ReadLine(), out n3)) Console.Write(mensagemErro);

            Console.Write("Digite nota 4..: ");
            while (!int.TryParse(Console.ReadLine(), out n4)) Console.Write(mensagemErro);

            res = n1 + n2 + n3 + n4;

            // Verificações
            if (res > 100)
            {
                Console.WriteLine("\nO valor total da média não pode passar de 100. Insira as notas novamente.");
                continue; // Reinicia o loop sem perguntar se deseja continuar
            }
            else if (res < 40)
            {
                Console.WriteLine("\nSua nota foi " + res + " e você foi REPROVADO.");
            }
            else if (res < 60)
            {
                Console.WriteLine("\nSua nota foi " + res + " e você está de RECUPERAÇÃO.");
            }
            else
            {
                Console.WriteLine("\nParabéns! Você tirou " + res + " e foi APROVADO.");
            }

            // Pergunta se deseja continuar, garantindo que o usuário insira "S" ou "N"
            string resposta;
            do
            {
                Console.Write("\nDeseja informar outra nota? (S/N): ");
                resposta = Console.ReadLine().Trim().ToUpper();

                if (resposta != "S" && resposta != "N")
                {
                    Console.WriteLine("\nEntrada inválida! Digite apenas 'S' para SIM ou 'N' para NÃO.");
                }

            } while (resposta != "S" && resposta != "N");

            if (resposta == "N")
            {
                Console.WriteLine("\nEncerrando o programa...");
                break; // Sai do loop se o usuário digitar "N"
            }
        }
    }
}

