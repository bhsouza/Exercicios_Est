//  Escreva um programa que inverta os caracteres de um string.

using System;

class Exercicio5 {
    static void Main() {
        Console.WriteLine("Insira um texto para ser invertido: ");
        string texto = Console.ReadLine();
        string textoInvertido = "";

        for (int i = texto.Length - 1; i >= 0; i--) {
            textoInvertido += texto[i];
        }

        Console.WriteLine(textoInvertido);

        Console.ReadLine();
    }
}