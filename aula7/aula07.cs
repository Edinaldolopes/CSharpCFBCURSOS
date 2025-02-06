using System;

class aula07{

  static void Main(){
      
      string nome, apelido;
      int idade;
     
     Console.WriteLine();

      Console.Write("Digite seu nome.....:");
      nome=(Console.ReadLine());


      Console.Write("digite sua idade....:");
      idade=Convert.ToInt32(Console.ReadLine());


      Console.Write("Digite seu apelido..:");
      apelido=(Console.ReadLine());

      Console.WriteLine();

      Console.WriteLine("....SEUS DADOS FORAM REGISTRADOS NO BANCO.... "  );

      Console.WriteLine();

      Console.WriteLine("NOME.....:  "  + nome  );
      Console.WriteLine("IDADE....:  "  + idade + " anos" );
      Console.WriteLine("APELIDO..:  "  + apelido  );

       


  } 


}