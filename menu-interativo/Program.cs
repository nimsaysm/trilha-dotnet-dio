using System.Collections;

string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear(); //não irá repetir menu
    Console.WriteLine("Digite uma opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrando...");
            exibirMenu = false; //sai do laço
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}