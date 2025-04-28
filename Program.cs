﻿Console.Clear();

string nomePrimeiroItem = "Vitamina C";
string nomeSegundoItem = "Alcool Gel";
string nomeTerceiroItem = "Termômetro Digital";

decimal precoPrimeiroItem = 29.90m;
decimal precoSegundoItem = 134.90m;
decimal precoTerceiroItem = 189.00m;

decimal percentualImpostoVenda = 0.088m; //8,8%

int qtdItem1, qtdItem2, qtdItem3;

decimal subtotalItemUm, subTotalItemDois, 
        subTotalItemTres, totalClienteUm,
        valorDoImposto, totalComImposto;

const int TAMANHO_LINHA = 36;
const char SEPARADOR = '=';

Console.WriteLine($"{"+".PadRight(TAMANHO_LINHA, SEPARADOR)}+");
Console.WriteLine($"{"|".PadRight(10)}Farmácia BemEstar{"|".PadLeft(11)}");
Console.WriteLine($"{"+".PadRight(TAMANHO_LINHA, SEPARADOR)}+");
Console.WriteLine($"{"|".PadRight(14)}CATÁLOGO{"|".PadLeft(15)}");
Console.WriteLine($"{"+".PadRight(TAMANHO_LINHA, SEPARADOR)}+");

Console.WriteLine($"{"| ITEM",-24}{"VALOR",-12}|");
Console.WriteLine($"{"+".PadRight(TAMANHO_LINHA, SEPARADOR)}+");

Console.WriteLine($"| 1. { nomePrimeiroItem,-18} {precoPrimeiroItem,-12:C2}|");
Console.WriteLine($"| 2. { nomeSegundoItem,-18} {precoSegundoItem,-12:C2}|");
Console.WriteLine($"| 3. { nomeTerceiroItem,-18} {precoTerceiroItem,-12:C2}|");

Console.WriteLine($"{"+".PadRight(TAMANHO_LINHA, SEPARADOR)}+");
Console.WriteLine($"{"| Imposto sobre a venda: 8,8%",-TAMANHO_LINHA}|");
Console.WriteLine($"{"+".PadRight(TAMANHO_LINHA, SEPARADOR)}+");

Console.Write($"\n\nQual quantidade para o {nomePrimeiroItem}: ");
qtdItem1 = Convert.ToInt32(Console.ReadLine());

if (qtdItem1 < 0)
{Console.WriteLine("Quantidade Inválida");
return;}

Console.Write($"Qual quantidade para o {nomeSegundoItem}: ");
qtdItem2 = Convert.ToInt32(Console.ReadLine());

if (qtdItem2 < 0)
{Console.WriteLine("Quantidade Inválida");
return;}

Console.WriteLine($"Qual quantidade para o {nomeTerceiroItem}: ");
qtdItem3 = Convert.ToInt32(Console.ReadLine());

if (qtdItem3 < 0)

{Console.WriteLine("Quantidade Inválida");
return;}

subtotalItemUm = qtdItem1 * precoPrimeiroItem;
subTotalItemDois = qtdItem2 * precoSegundoItem;
subTotalItemTres = qtdItem3 * precoTerceiroItem;

totalClienteUm = subtotalItemUm + subTotalItemDois + subTotalItemTres;
valorDoImposto = totalClienteUm * percentualImpostoVenda;

totalComImposto = totalClienteUm + valorDoImposto;

Console.WriteLine("\n");
Console.WriteLine($"1. {qtdItem1}x {nomePrimeiroItem} --> {subtotalItemUm:C2}");
Console.WriteLine($"2. {qtdItem2}x {nomeSegundoItem} --> {subTotalItemDois:C2}");
Console.WriteLine($"3. {qtdItem3}x {nomeTerceiroItem} --> {subTotalItemTres:C2}");

Console.WriteLine($"\nImposto (8,8%): {valorDoImposto:C2}");
Console.WriteLine($"\nTotal: {totalComImposto:C2}");

// PARA COMPARAR
// igualdade, usar ==
// maior, usar > 
// maior ou igual, >=
// menor, usar < 
// menor ou igual, <= 
// diferente, !=
// negação, !