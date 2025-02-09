using System;

class aula15{

    static void Main(){
        
        int tempo=0;
        char escolha;

        Console.WriteLine("\nparana a goias");
        Console.WriteLine("\nEscolha o trnsporte:[a]=aviao [c]=carro [o]=onibus");

        while (!char.TryParse(Console.ReadLine(), out escolha)) ;

        switch(escolha){
            case 'a':
            case 'A':
                tempo=50;
                break;
            case 'c':
            case 'C':
                tempo=480;
                break;
            case 'o':
            case 'O':
                tempo=660;
                break;
            default:
                tempo=-1;
                break;
        }
        if(tempo<0){
            Console.WriteLine("tranporte indisponivel");
        
        }else{
            Console.WriteLine("para o tranporte escolhido o etempo e de "+tempo+ " minutos...");
        }
    }
}