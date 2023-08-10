// Fazer um programa leia uma sequência de valores inteiros fornecida pelo usuário em uma
// linha de entrada e conte o número de valores positivos, negativos e zeros.


int valoresint; // declarando variavel de resposta do usuario
int valoresp=0,valoresn=0,zeros=0; // declarando variavel de condição
char valoropcao; // declarando variavel de opçao

do // enquanto
{
    Console.WriteLine("Insira seu numero inteiro: "); // o usuario digitar numero inteiro
    valoresint=int.Parse(Console.ReadLine());// guardando informaçao

    if (valoresint>0) { // se caso o usuario digitar valores inteiros maiores que 0 faça 
        valoresp++; // isso, dê 1 para a valores positivos
    }

    else if ( valoresint<0) { // se nao caso o usuario digitar valores inteiros menores que 0 faça
        valoresn++;// isso/ dê 1 para a variavel valores negativos
    }

    else if (valoresint==0) { // se nao ou "de resto" faça isso, se ele digitar 0
        zeros++;// de pontos para a varaivel zero
    }
    

    Console.WriteLine("Você deseja continuar ? 's' ou 'n' s para sim e n para n "); // opção para o loop acabar quer continuar sim ou nao ?
    valoropcao=char.Parse(Console.ReadLine()); // guardando a informação
    

}while(valoropcao=='s'); // faça o loop enquanto o usuario escolher o o char SIM OU 'S'  

Console.WriteLine("O numero de valores positivos é: {0} de negativo é: {1} e de zeros são: {2}",valoresp, valoresn,zeros); // se ele nao escolher sim... termina o programa 
   
    