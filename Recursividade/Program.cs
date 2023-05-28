using Recursividade;

int exercicio;

Console.WriteLine("Escolha o exercício");
exercicio = int.Parse(Console.ReadLine());

switch (exercicio)
{
    case 0:
        Console.WriteLine("Potência");
        Potencia();
        break;

    case 1:
        Console.WriteLine("Fatorial");
        Fatorial();
        break;

    default:
        Console.WriteLine("Exercício inválido");
        break;

}

void Potencia()
{
    int numeroBase;
    int expoente;
    int resultado = 1;
    Metodos metodos = new Metodos();

    Console.WriteLine("Digite a base");
    numeroBase = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o expoente");
    expoente = int.Parse(Console.ReadLine());

    Console.WriteLine($"O valor de {numeroBase} elevado a {expoente} é {metodos.CalcularPotencia(numeroBase, expoente, resultado)}");
}


void Fatorial()
{
    int fatorial = 1;
    int numero;
    Metodos metodos = new Metodos();

    Console.WriteLine("Digite o valor do número");
    numero = int.Parse(Console.ReadLine());

    Console.WriteLine($"O valor do fatorial de {numero} é {metodos.CalcularFatorial(numero)}");   
}


