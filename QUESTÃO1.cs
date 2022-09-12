 
      using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n1, n2, n3, M, P ,S; 
        
         Console.WriteLine("Digite o primeiro numero:"); 
         n1 = int.Parse(Console.ReadLine());  
         
          Console.WriteLine("Digite o segundo numero:"); 
           n2 = int.Parse(Console.ReadLine()); 
           
           Console.WriteLine("Digite o terceiro numero:"); 
           n3 = int.Parse(Console.ReadLine()); 
           
           M = n1 + n2 + n3/3 ; 
           P = n1 * n2 * n3 ; 
           S = n1 + n2 + n3; 
           
           Console.WriteLine("a media e = " + M); 
             Console.WriteLine("a produto e = " + P); 
             Console.WriteLine("a somatorio e = " + S);  
        } 
    }
