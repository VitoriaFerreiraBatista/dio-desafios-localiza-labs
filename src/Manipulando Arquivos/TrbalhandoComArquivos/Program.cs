using System;
using System.Collections.Generic;
using System.IO;


namespace TrbalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\Estudos\\Programação\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3", "Subpastateste3");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste.txt");

            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia,false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);

            //Console.WriteLine("Criando diretório: "+ caminhoPathCombine);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá teste de escrita");

        }
    }   
}
