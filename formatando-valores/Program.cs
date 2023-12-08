using System.Globalization;

decimal valorMonetario = 1080.05M;

Console.WriteLine($"{valorMonetario:C}"); //formata a string para o tipo currency(C)


//formatar porcentagem
double porcentagem = .765;

Console.WriteLine(porcentagem.ToString("P"));


//formatar número
int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));


//obter data e hora atual
DateTime data1 = DateTime.Now;

//formatar data
Console.WriteLine(data1.ToString("yyyy-MM-dd HH:mm"));

//converter com TryParse
string dataString = "2023-01-120 08:50";
//tentar converter o dataString para uma data válida
bool sucesso = DateTime.TryParseExact (dataString, 
                        "yyyy-MM-dd HH:mm", //formato que a variável está
                        CultureInfo.InvariantCulture, //InvariantCulture - independente de cultura específica
                        DateTimeStyles.None, out DateTime data2); //DateTimeStyles.None - nenhum tipo específico

if (sucesso) {
    Console.WriteLine($"Conversão feita com sucesso!\n Data: {data2}");
}
else {
    Console.WriteLine($"{dataString} não é uma data válida");
}