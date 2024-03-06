// Enunciado: Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

using System;

class Exercicio2 {
  static void Main() {
    Console.WriteLine("Informe um número para verificar se ele pertence à sequência de Fibonacci:");
    int numRecebido = int.Parse(Console.ReadLine());
    int atual = 0;
    int proximo = 1;
    bool pertence = false;

    while (atual <= numRecebido) {
      if (atual == numRecebido) {
        pertence = true;
        break;
      }

      int temp = atual;
      atual = proximo;
      proximo = temp + proximo;
    }

    if (pertence) {
      Console.WriteLine("O número "+ numRecebido +" pertence à sequência de Fibonacci.");
    } else {
      Console.WriteLine("O número "+ numRecebido +" não pertence à sequência de Fibonacci.");
    }

    Console.ReadLine();
  }
}