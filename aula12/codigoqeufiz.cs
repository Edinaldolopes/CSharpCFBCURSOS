using System;

class Aula12
{
    static void Main()
    {
            

        while (true) // Loop infinito até que o usuário decida parar
        {
            


            string inva="\nEntrada inválida! Digite um número válido para a nota: ";
            int n1,n2,n3,n4,res;
            res=n1=n2=n3=n4=0;

            Console.Write("\ndigite nota 1..: ");
             while (!int.TryParse(Console.ReadLine(), out n1))
            
            {
                Console.Write(inva);
            }

            Console.Write("digite nota 2..: ");
             while (!int.TryParse(Console.ReadLine(), out n2))
            
            {
                Console.Write(inva);
            }

            Console.Write("digite nota 3..: ");
             while (!int.TryParse(Console.ReadLine(), out n3))

            {
                Console.Write(inva);
            }

            Console.Write("digite nota 4..: ");
             while (!int.TryParse(Console.ReadLine(), out n4))

            {
                Console.Write(inva);
            }
            
            
            

            res=n1+n2+n3+n4;

            if(res < 40 )
            {

                Console.WriteLine("\nsua nota foi " +res+ " e Voce foi reprovado");

                Console.Write("\nDeseja informar outra  nota? (S/N): ");
                        string resposta = Console.ReadLine().ToUpper();

                        if (resposta != "S")
                        {
                            Console.WriteLine("\nEncerrando o programa...");
                            break; // Sai do loop se o usuário não digitar "S"
                        } 

            }

            else
            {

                if (res < 60 )
                {

                    Console.WriteLine("\nVoce esta de recuperacao");

                    Console.Write("\nDeseja informar outra  nota? (S/N): ");
                        string resposta = Console.ReadLine().ToUpper();

                        if (resposta != "S")
                        {
                            Console.WriteLine("\nEncerrando o programa...");
                            break; // Sai do loop se o usuário não digitar "S"
                        } 
                }

                else
                {

                    if (res > 100) 
                    {

                        Console.WriteLine("\nO valor total da media nao pode passar de 100, coloque novamente as notas");
                        continue;// Volta para o início do loop e pede novas notas

                    }


                    else
                    {

                        if (res >= 60)
                        {
                            Console.WriteLine("\nResultado: voçe tirou " +res+ " E foi aprovado, Parabens!!!");
                        }
                        

                        Console.Write("\nDeseja informar outra  nota? (S/N): ");
                        string resposta = Console.ReadLine().ToUpper();

                        if (resposta != "S")
                        {
                            Console.WriteLine("\nEncerrando o programa...");
                            break; // Sai do loop se o usuário não digitar "S"
                        } 
                    }
                }
            }  
        }
    }
}
