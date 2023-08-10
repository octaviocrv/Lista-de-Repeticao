// Adaptar o programa acima para que ele calcule o percentual dos valores positivos,
// negativos e zeros em relação ao total de valores fornecidos.

int valoresint;
int valoresp = 0, valoresn=0, valoreszeros=0;
char resposta= 's';
double total=0.0;

 
do {

Console.WriteLine("Digite o valor do numero inteiro");
valoresint = int.Parse(Console.ReadLine());

if (valoresint>0) { 
        valoresp++;
}

else if (valoresint<0) {
        valoresn++;
}

else  {
    valoreszeros++;
}
        Console.WriteLine("Voce deseja continuar? [s] para sim e [n] para não");
        resposta = char.Parse(Console.ReadLine().ToLower());
}
while (resposta=='s');  

Console.WriteLine("O numero de valores positivos é {0} de negativos é {1} e zeros {2}",valoresp,valoresn,valoreszeros);

Console.WriteLine("Positivos: "+ ((valoresp/ (valoresp+valoresn+valoreszeros))*100));
Console.WriteLine("Negativos : "+ ((valoresn/ (valoresp+valoresn+valoreszeros))*100));
Console.WriteLine("Zero: "+ ((valoreszeros/ (valoresp+valoresn+valoreszeros))*100));
    