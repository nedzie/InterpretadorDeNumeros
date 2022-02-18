using System;

namespace InterpretadorDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {                 //........................................
            string texto = "     __  __      __  __ __   __  __  __ \n" +
                           "  |  __| __||__||__ |__   | |__||__||  |\n" +
                           "  | |__  __|   | __||__|  | |__| __||__|\n";
            System.IO.StringReader leitorDeCodigos = new System.IO.StringReader(texto);
            string primeiraLinha = leitorDeCodigos.ReadLine();
            string segundaLinha = leitorDeCodigos.ReadLine();
            string terceiraLinha = leitorDeCodigos.ReadLine();

            char[] arrPrimeiraLinha = primeiraLinha.ToCharArray();
            char[] arrSegundaLinha = segundaLinha.ToCharArray();
            char[] arrTerceiraLinha = terceiraLinha.ToCharArray();

            string linhaUm = "";
            string linhaDois = "";
            string linhaTres = "";

            int contador = 0;

            for (int colunas = 0; colunas < 40; colunas++)
            {
                linhaUm += arrPrimeiraLinha[colunas];
                linhaDois += arrSegundaLinha[colunas];
                linhaTres += arrTerceiraLinha[colunas];
                if(linhaUm == "    " && linhaDois == "  | " && linhaTres == "  | ") // if 1
                {
                    Console.Write("1");
                }
                if (linhaUm == " __ " && linhaDois == " __|" && linhaTres == "|__ ") // if 2
                {
                    Console.Write("2");
                }
                if (linhaUm == " __ " && linhaDois == " __|" && linhaTres == " __|") // if 3
                {
                    Console.Write("3");
                }
                if (linhaUm == "    " && linhaDois == "|__|" && linhaTres == "   |") // if 4
                {
                    Console.Write("4");
                }
                if (linhaUm == " __ " && linhaDois == "|__ " && linhaTres == " __|") // if 5
                {
                    Console.Write("5");
                }
                if (linhaUm == " __ " && linhaDois == "|__ " && linhaTres == "|__|") // if 6
                {
                    Console.Write("6");
                }
                if (linhaUm == "__  " && linhaDois == "  | " && linhaTres == "  | ") // if 7
                {
                    Console.Write("7");
                }
                if (linhaUm == " __ " && linhaDois == "|__|" && linhaTres == "|__|") // if 8
                {
                    Console.Write("8");
                }
                if (linhaUm == " __ " && linhaDois == "|__|" && linhaTres == " __|") // if 9
                {
                    Console.Write("9");
                }
                if (linhaUm == " __ " && linhaDois == "|  |" && linhaTres == "|__|") // if 0
                {
                    Console.Write("0");
                }
                contador += 1;
                if(contador == 4)
                {
                    linhaUm = "";
                    linhaDois = "";
                    linhaTres = "";
                    contador = 0;
                }
            }
        }
    }
}