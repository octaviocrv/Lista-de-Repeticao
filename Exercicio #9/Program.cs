int Tmercadorias, x=0;
double pc, pv, la=0, lb=0, lc=0, lt=0, tc = 0, tv = 0, l = 0;
char NomeMercadoria;

Console.WriteLine("Quantas mercadorias você quer calcular: ");
Tmercadorias = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o nome da mercadoria ");
NomeMercadoria = char.Parse(Console.ReadLine());

Console.WriteLine("Qual o preço de compra: ");
pc = double.Parse(Console.ReadLine());

Console.WriteLine("Qual o preço de venda: ");
pv = double.Parse(Console.ReadLine());

while (x < Tmercadorias)
{
    if (pv > pc)
    {
        l = ((pv / pc) - 1) * 1000;

        if (l <= 10)
        {
            la++;
        }
        else if (l > 10 && l <= 20)
        {
            lb++;
        }
        else if (l > 20)
        {
            lc++;
        }
    }
    x++;
}

lt = pv - pc;
tc = pc;
tv = pv;

Console.WriteLine("O total de mercadorias que apresentam 10% de lucro é: {0}", la);
Console.WriteLine("O total de mercadorias que apresentam 10% e 20% de lucro é: {0}", lb);
Console.WriteLine("O total de mercadorias que apresentam mais que 20% de lucro é: {0}", lc);
Console.WriteLine("O Lucro total é: {0}", lt);
Console.WriteLine("O Total de vendas é: {0}", tv);
Console.WriteLine("O Total de compras é: {0}", tc);