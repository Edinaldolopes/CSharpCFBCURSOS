using System;

class aula06{

  static void Main(){

    double valorcompra=5.50;
    double valorvenda;
    double lucro=0.1;
    string produto="Pastel";

    valorvenda=valorcompra+(valorcompra*lucro);

    Console.WriteLine("produto.........:{0,15}", produto);
    Console.WriteLine("val.compra......:{0,15:c}", valorcompra);
    Console.WriteLine("lucro...........:{0,15:p}", lucro);
    Console.WriteLine("valor.venda.....:{0,15:c}", valorvenda);
  } 


}