using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
           string Nome ; 
         double         ins, shn, she, inss, sl, sb ; 
        
         Console.WriteLine("digite seu nome:"); 
        Nome = Console.ReadLine();
        
         Console.WriteLine("digite seu numero de inscricao:"); 
         ins = float.Parse(Console.ReadLine());
        
        Console.WriteLine("digite seu Salario horas normais:"); 
        shn = float.Parse(Console.ReadLine()); 
        
        she = shn * 0.3 ; 
        sb = she + shn;
        inss =  sb * 0.11; 
        sl = sb - inss ; 
        
        Console.WriteLine("Numero de inscricao: " + ins);
        Console.WriteLine ("Nome: " + Nome);
        Console.WriteLine ("Salario horas normais:" +  shn * 1.3);  
        Console.WriteLine("Salario horas extras:" +  she); 
       Console.WriteLine("Deducao inss:" +  inss);
       Console.WriteLine("Salario liquido:" +  sl);
    }
}
