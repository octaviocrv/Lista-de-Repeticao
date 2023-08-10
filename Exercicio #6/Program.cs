
// Escreva um algoritmo que lê um valor n inteiro e positivo e que calcula a seguinte soma:
// S = 1 + 1/2 + 1/3 + 1/4 + ... + 1/n

int n;
double resultado=0;

Console.WriteLine("Calculo da soma dos n primeiros inteiros positivos");

Console.WriteLine("Digite o valor de N");
n = int.Parse(Console.ReadLine());

for (int i=1; i<=n; i++) {
    resultado += 1 / i;
}

Console.WriteLine("A soma dos n primeiros inteiros positivos de {0} é {1}:", n, resultado);