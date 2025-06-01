Console.Clear();

decimal etanol, gasolina;

Console.WriteLine("-- Etanol ou Gasolina? --\n\n");

etanol = ValorDigitado("Digite o preço do Etanol (R$)   : ");
gasolina = ValorDigitado("Digite o preço da Gasolina (R$) : ");

decimal percentual = PercentualEtanolGasolina(etanol, gasolina); //prim etanol

Console.WriteLine($"\nPreço do etanol corresponde a {percentual:N1}% do preço da gasolina\n");
Console.Write("Recomendamos abastecer com ");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(ValeAPena(etanol, gasolina) ? "GASOLINA" : "ETANOL");
//operador ternário                           |            |
//                                        se for vd      se n
Console.ResetColor();


decimal ValorDigitado (string mensagem)
{
    Console.Write(mensagem);

    decimal val;
    while (!Decimal.TryParse(Console.ReadLine(), out val))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nValor inválido, tente novamente");
        Console.ResetColor();

        Console.Write(mensagem);
    }
    return val;
}

decimal PercentualEtanolGasolina(decimal e, decimal g) 
//Variáveis atribuidas respectivamente nos parâmetros
//especifique qual valor vai ser retornado

//escolher o tipo da variável a ser retornada
{
    return 100 * e / g;
}

bool ValeAPena (decimal et, decimal ga) //PRECISA SER BOOLEANO
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
