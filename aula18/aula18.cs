using System;

class aula17{

    static void Main(){
        int n1,n2,n3,n4,n5;
        int[] n=new int[3,5]; 

        /*
        10 20 30 40 50
        60 70 80 90 15
        25 45 45 55 65
        */

        
        n[0,0]=10;
        n[0,1]=20;
        n[0,2]=30;
        n[0,3]=40;
        n[0,4]=50;

        Console.WriteLine(n[0]);
    }
}