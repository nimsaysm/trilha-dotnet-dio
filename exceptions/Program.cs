using Exceptions.Models;

new ExemploExcecao().Metodo1();

// try 
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

//     foreach(string linha in linhas) 
//     {
//         Console.WriteLine(linha);
//     }
// } catch (FileNotFoundException ex) 
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo nao encontrado. {ex.Message}");
// }
//  catch(Exception ex) 
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// } 
// finally //finalmente/então, faça - ocorre sempre, mesmo se ocorreu a exceção ou não
// {
//     Console.WriteLine("Chegou até aqui!");
// }

