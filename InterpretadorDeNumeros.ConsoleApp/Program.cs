using System;

namespace InterpretadorDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
                          //         1111111111222222222233333333334
        {                 //1234567890123456789012345678901234567890
            string texto = "     __  __      __  __ __   __  __  __ \n" +
                           "  |  __| __||__||__ |__   | |__||__||  |\n" +
                           "  | |__  __|   | __||__|  | |__| __||__|\n" +
                           " __  __ __   __  __      __  __      __ \n" +
                           "|__ |__   | |__||__|  |  __| __||__||  |\n" +
                           " __||__|  | |__| __|  | |__  __|   ||__|\n" +
                           " __     __   __      __  __  __  __  __ \n" +
                           " __||__|  | |__|  |  __||__ |__ |__||  |\n" +
                           " __|   |  | |__|  | |__  __||__| __||__|\n" +
                           " __  __  __  __  __     __   __      __ \n" +
                           " __| __||__ |__ |__||__|  | |__|  | |  |\n" +
                           " __||__  __||__| __|   |  | |__|  | |__|\n" +
                           " __  __  __  __ __   __      __      __ \n" +
                           "|  | __||__ |__   | |__|  | |__||__| __|\n" +
                           "|__||__  __||__|  | |__|  |  __|   | __|";

            System.IO.StringReader leitorDeCodigos = new System.IO.StringReader(texto);

            string primeiraLinha = leitorDeCodigos.ReadLine();
            string segundaLinha = leitorDeCodigos.ReadLine();
            string terceiraLinha = leitorDeCodigos.ReadLine(); // Até aqui linha 1
            string quartaLinha = leitorDeCodigos.ReadLine();
            string quintaLinha = leitorDeCodigos.ReadLine();
            string sextaLinha = leitorDeCodigos.ReadLine(); // Até aqui linha 2
            string setimaLinha = leitorDeCodigos.ReadLine();
            string oitavaLinha = leitorDeCodigos.ReadLine();
            string nonaLinha = leitorDeCodigos.ReadLine(); // Até aqui linha 3
            string decimaLinha = leitorDeCodigos.ReadLine();
            string decimaPrimeiraLinha = leitorDeCodigos.ReadLine();
            string decimaSegundaLinha = leitorDeCodigos.ReadLine(); // Até aqui linha 4
            string decimaTerceiraLinha = leitorDeCodigos.ReadLine();
            string decimaQuartaLinha = leitorDeCodigos.ReadLine();
            string decimaQuintaLinha = leitorDeCodigos.ReadLine(); // Até aqui linha 5

            char[] arrPrimeiraLinha = primeiraLinha.ToCharArray();
            char[] arrSegundaLinha = segundaLinha.ToCharArray();
            char[] arrTerceiraLinha = terceiraLinha.ToCharArray();
            char[] arrQuartaLinha = quartaLinha.ToCharArray();
            char[] arrQuintaLinha = quintaLinha.ToCharArray();
            char[] arrSextaLinha = sextaLinha.ToCharArray();
            char[] arrSetimaLinha = setimaLinha.ToCharArray();
            char[] arrOitavaLinha = oitavaLinha.ToCharArray();
            char[] arrNonaLinha = nonaLinha.ToCharArray();
            char[] arrDecimaLinha = decimaLinha.ToCharArray();
            char[] arrDecimaPrimeiraLinha = decimaPrimeiraLinha.ToCharArray();
            char[] arrDecimaSegundaLinha = decimaSegundaLinha.ToCharArray();
            char[] arrDecimaTerceiraLinha = decimaTerceiraLinha.ToCharArray();
            char[] arrDecimaQuartaLinha = decimaQuartaLinha.ToCharArray();
            char[] arrDecimaQuintaLinha = decimaQuintaLinha.ToCharArray();

            string linhaUm = "";
            string linhaDois = "";
            string linhaTres = "";

            Console.WriteLine("Entrada: ");
            Console.WriteLine(primeiraLinha + "\n" + 
                              segundaLinha + "\n" +
                              terceiraLinha + "\n" +
                              quartaLinha + "\n" +
                              quintaLinha + "\n" +
                              sextaLinha + "\n" +
                              setimaLinha + "\n" +
                              oitavaLinha + "\n" +
                              nonaLinha + "\n" +
                              decimaLinha + "\n" +
                              decimaPrimeiraLinha + "\n" +
                              decimaSegundaLinha + "\n" +
                              decimaTerceiraLinha + "\n" +
                              decimaQuartaLinha + "\n" +
                              decimaQuintaLinha);

            int contador = 0;
            int contadorDeLinhas = 0;
            int aconteceu = 0;
            Console.WriteLine("\n\n.....................................................................................................");
            Console.WriteLine("\n\nSaída: \n");

            for (int colunas = 0; colunas < 40; colunas++)
            {
                if(contadorDeLinhas == 0) {
                    linhaUm += arrPrimeiraLinha[colunas];
                    linhaDois += arrSegundaLinha[colunas];
                    linhaTres += arrTerceiraLinha[colunas];
                }
                if(contadorDeLinhas == 1)
                {
                    if (aconteceu == 0)
                    {
                        Console.WriteLine();
                        aconteceu++;
                    }
                    linhaUm += arrQuartaLinha[colunas];
                    linhaDois += arrQuintaLinha[colunas];
                    linhaTres += arrSextaLinha[colunas];
                }
                if (contadorDeLinhas == 2)
                {
                    if (aconteceu == 1)
                    {
                        Console.WriteLine();
                        aconteceu++;
                    }
                    linhaUm += arrSetimaLinha[colunas];
                    linhaDois += arrOitavaLinha[colunas];
                    linhaTres += arrNonaLinha[colunas];
                }
                if (contadorDeLinhas == 3)
                {
                    if (aconteceu == 2)
                    {
                        Console.WriteLine();
                        aconteceu++;
                    }
                    linhaUm += arrDecimaLinha[colunas];
                    linhaDois += arrDecimaPrimeiraLinha[colunas];
                    linhaTres += arrDecimaSegundaLinha[colunas];
                }
                if (contadorDeLinhas == 4)
                {
                    if (aconteceu == 3)
                    {
                        Console.WriteLine();
                        aconteceu++;
                    }
                    linhaUm += arrDecimaTerceiraLinha[colunas];
                    linhaDois += arrDecimaQuartaLinha[colunas];
                    linhaTres += arrDecimaQuintaLinha[colunas];
                }
                if (linhaUm == "    " && linhaDois == "  | " && linhaTres == "  | ") // if 1
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
                if(colunas == 39)
                {
                    contadorDeLinhas += 1;
                    colunas = -1;
                    
                }
            }
            Console.ReadKey();
        }
    }
}