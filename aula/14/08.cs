/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("DIGITE UM NUMERO:");
        int num = Convert.ToInt32(Console.ReadLine());
            
      for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{ num} x { i} = { num * i}");
        }

       
    }
}

using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
           
            Console.WriteLine(i);
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        double numero3 = Convert.ToDouble(Console.ReadLine());

        double media = (numero1 + numero2 + numero3) / 3;

        Console.WriteLine("A média dos três números é: " + media);

    }


}


using System;

class Program
{
    static void main()
    {
        // double = ponto flutuante com alta precisão e intervalos grandes;

        // float = ponto flutuante quando a memória é uma preocupação. f

        // decimal (m) = cálculos de alta precisão (128 bits) - Stock Market

        // int, long (L), short, byte - números inteiros de diferentes tamanhos.
    }
}



using System;

class Program
{
    static void Main()
    {

        Console.Write("Digite o nome do funcionário: ");
        string nomeFuncionario = Console.ReadLine();

        Console.Write("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        double numero3 = Convert.ToDouble(Console.ReadLine());

        double media = (numero1 + numero2 + numero3) / 3;

        Console.WriteLine($"Funcionário: {nomeFuncionario}");
        Console.WriteLine($"A média dos três números é: {media}");
    }
}


using System;

class Program
{
    static void Main()
    {

        Console.Write("Digite o nome do funcionário: ");
        string nomeFuncionario = Console.ReadLine();


        Console.Write("Digite as horas trabalhadas na semana: ");
        int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a taxa de pagamento por hora: ");
        double taxaPagamentoPorHora = Convert.ToDouble(Console.ReadLine());


        Console.Write("Digite o valor das comissões recebidas na semana: ");
        decimal valorComissoes = Convert.ToDecimal(Console.ReadLine());

        decimal salarioBruto = (decimal)(horasTrabalhadas * taxaPagamentoPorHora);


        decimal salarioTotal = salarioBruto + valorComissoes;


        Console.WriteLine($"Funcionário: {nomeFuncionario}");
        Console.WriteLine($"Salário Total: {salarioTotal:C}");
    }
}/*

