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


decimal percentual = PercentualEtanolGasolina(etanol, gasolina);
string escolha = ValeAPena(etanol, gasolina);

Console.WriteLine($"\nPreço do Etanol corresponde a {percentual:N1}% do preço da gasolina\n");
Console.WriteLine($"Recomendamos abastecer com: {escolha}\n\n");


// decimal percentualTeste = PercentualEtanolGasolina(etanol1, gasolina1);
// string escolhaTeste = ValeAPena(gasolina1, etanol1);

// Console.WriteLine($"Percentual teste {percentualTeste:N1}%\n");
// Console.WriteLine($"Recomendamos abastecer com: {escolhaTeste}\n\n");




static decimal PercentualEtanolGasolina(decimal a, decimal b) 
//Variáveis atribuidas respectivamente
//especifique qual valor vai ser retornado

//void - Execução de tarefa, não retorna resultado
//escolher o tipo da variável a ser retornada
{
    return 100 * a / b;
}

static string ValeAPena (decimal a, decimal b)
//utiliza as variáveis que eu escolher quando for exibir???
{
    if(100 * a / b > 73)//teria como n repetir a equação? Como chamar a subrotina a cima???
    {
        return "Gasolina";
    }

    else
    {
        return "Etanol";
    }
}
