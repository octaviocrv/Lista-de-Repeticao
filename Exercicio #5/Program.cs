// 5. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, coletando dados sobre o salário e 
            // número de filhos de cada habitante. A prefeitura deseja saber:
            // a) média do salário da população;
            // b) média do número de filhos;
            // c) maior salário;
            // d) percentual de pessoas com salário até R$100,00.
            // O final da leitura de dados se dará com a entrada de um salário negativo.     

            // Entrada de dados
            double salario, salariopop = 0, numfilhos = 0, salariomaior = 0, percentual = 0;
            int filhostotal = 0, cont = 0;

            Console.WriteLine("Pesquisa");
            do
            {
                //Entrada de dados
                Console.Write($"Digite o valor do salario: ");
                salario = double.Parse(Console.ReadLine()!);
                Console.Write("Digite a quantidade de filhos: ");
                filhostotal = int.Parse(Console.ReadLine()!);
                Console.Clear();
                if (salario > 0)
                {
                    cont++;

                    if (salario > salariomaior)
                    {
                        salariomaior = salario;
                    }

                    if (salario <= 100)
                    {
                        percentual++;
                    }

                    salariopop += salario;

                    numfilhos += filhostotal;
                }
            } while (salario > 0);

            numfilhos /= cont;
            salariopop /= cont;
            percentual = (percentual * 100) / cont;
            Console.WriteLine("Pesquisa");
            Console.WriteLine(@$"Resultado:
Media do Salario da População: {salariopop:F2}
média do número de filhos: {numfilhos:F2}
maior salário: R${salariomaior:F2}
percentual de pessoas com salário até R$100,00: {percentual}%");
