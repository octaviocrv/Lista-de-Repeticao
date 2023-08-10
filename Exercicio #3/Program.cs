// Faça um programa que RECEBA DEZ NUMEROS e verifique se eles são divisíveis por 
// 3 e 9 (ao mesmo tempo), 
// por 2 e por 5. 

// Caso algum número não seja divisível por nenhum desses
// números mostre a mensagem “Número não é divisível pelos valores”. 

//Apresente também
// ao final a quantidade de números divisíveis por 3 e 9, por 2 e por 5.



int numero = 0;
int m = 0;
int n = 0;
char op;
do
{
    Console.WriteLine("Informe um numero para saber por qual numero ele é divisivel");
    numero = int.Parse(Console.ReadLine());
    if (numero % 3 == 0 && numero % 9 == 0)
    {
        Console.WriteLine("O numero digitado é divisivel por 3 e por 9 ao mesmo tempo");
        m++;
    }
    else if (numero % 2 == 0 && numero % 5 == 0)
    {
        Console.WriteLine("O numero digitado é divisivel por 2 e por 5 ao mesmo tempo");
        n++;
    }
    else
    {
        Console.WriteLine("O numero não é divisivel simultanemente nem por 2 e 5 nem por 3 e 9");
    }
    Console.WriteLine("Deseja parar? (s / n)");
    op = char.Parse(Console.ReadLine().ToUpper());
} while (op == 'N');
Console.WriteLine("Multiplos de 3 e 9: " + m);
Console.WriteLine("Multiplos de 2 e 5: " + n);
