Console.Clear();

decimal etanol, gasolina;

Console.Write("Digite o perço do Etanol (R$)   : ");
etanol = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o perço da Gasolina (R$) : ");
gasolina = Convert.ToDecimal(Console.ReadLine());


// Console.Write("Teste etanol 1 : ");
// decimal etanol1 = Convert.ToDecimal(Console.ReadLine());

// Console.Write("teste gasolina 2 : ");
// decimal gasolina1 = Convert.ToDecimal(Console.ReadLine());


decimal percentual = PercentualEtanolGasolina(etanol, gasolina); //prim etanol

Console.WriteLine($"\nPreço do etanol corresponde a {percentual:N1}% do preço da gasolina\n");
Console.Write("Recomendamos abastecer com ");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(ValeAPena(etanol, gasolina) ? "GASOLINA" : "ETANOL");
//operador ternário                           |            |
//                                        se for vd      se n
Console.ResetColor();


// decimal percentualTeste = PercentualEtanolGasolina(etanol1, gasolina1);
// string escolhaTeste = ValeAPena(etanol1, gasolina1) ? "GASOLINA" : "ETANOL";

// Console.WriteLine($"Percentual teste {percentualTeste:N1}%\n");
// Console.WriteLine($"Recomendamos abastecer com {escolhaTeste}\n\n");




decimal PercentualEtanolGasolina(decimal e, decimal g) 
//Variáveis atribuidas respectivamente nos parâmetros
//especifique qual valor vai ser retornado

//escolher o tipo da variável a ser retornada
{
    return 100 * e / g;
}

bool ValeAPena (decimal et, decimal ga) //PRECISA SER BOOLEANO
//utiliza as variáveis que eu escolher quando for exibir???
{
    if (PercentualEtanolGasolina(et, ga) > 73)
    {
        return true; //gasolina
    }

    else
    {
        return false; //etanol
    }
}
