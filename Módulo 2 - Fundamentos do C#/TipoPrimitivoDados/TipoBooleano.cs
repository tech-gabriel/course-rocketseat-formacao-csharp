using System;
using System.Collections.Generic;
using System.Text;

namespace TipoPrimitivoDados;

class TipoBooleano
{
    static void tipoBooleano()
    {
        // O tipo booleano representa um valor lógico que pode ser verdadeiro (true) ou falso (false).
        bool valorVerdadeiro = true;  // Representa um valor verdadeiro
        bool valorFalso = false;      // Representa um valor falso


        // O tipo booleano é amplamente utilizado em estruturas de controle de fluxo, como if, while, for, etc.
        if (valorVerdadeiro)
        {
            Console.WriteLine("Este é um valor verdadeiro.");
        }
        else
        {
            Console.WriteLine("Este é um valor falso.");
        }


        // O tipo booleano também pode ser usado para armazenar o resultado de expressões lógicas.
        int a = 5;
        int b = 10;
        bool resultadoComparacao = a < b;  // Avalia se a é menor que b, resultando em true
        Console.WriteLine($"O resultado da comparação é: {resultadoComparacao}");
    }
}
