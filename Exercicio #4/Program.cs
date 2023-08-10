

// Escrever um algoritmo que lê um valor N inteiro e positivo e que calcula e escreve o valor de E:
//E = 1 + 1 / 1! + 1 / 2! + 1 / 3! + .... + 1 / N!


Console.WriteLine("Digite o seu numero"); // Pedindo variavel

int numeron = int.Parse(Console.ReadLine()); // guardando variavel
double fat = 1, soma = 0; // criando variavel loop


for ( int n = 1; n<=numeron; n++) { // fazer a repeticao comecando do 1, enquanto n for menor ou igual o numero digitado, sempre acrescentando 1 a mais

    soma += 1/fat; // conta
    fat *= n; // conta
}

Console.WriteLine("O valor de E é {0}" , soma); // resultado
