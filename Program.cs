using System;

class Program
{
    static void Main(string[] args)
    {
       double Salario , INSS;
       Console.WriteLine("Digite o valor do salário: ");
       Salario = double.Parse(Console.ReadLine());
       
       if (Salario <= 1000){
            INSS = Salario * 0.08;

            Console.WriteLine("O valor do INSS é: " + INSS);
        }
        else
        {
            INSS = Salario * 0.10;

            Console.WriteLine("O valor do INSS é: " + INSS);
        }
    }
}