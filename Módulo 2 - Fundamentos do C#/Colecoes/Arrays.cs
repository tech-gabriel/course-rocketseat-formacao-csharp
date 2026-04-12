/*
 *  AULA 1 - ARRAYS
 *  MÓDULO 2 - COLEÇÕES 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Colecoes
{
    internal class Arrays
    {
        public static void arrays()   
        {
            /* --- ARRAYS UNIDIMENSIONAIS (VETORES) ---
             *  Cria uma array de inteiros com tamanho fixo em 10 posições
             *  Em C#, posições não atribuidas recebem o valor padrão do tipo, que para inteiros é 0 */

            int[] inteiros = new int[10];

            /* 1. Atribui valores às posições do array:
             * A contagem dos índices sempre começa em 0, então o último índice de um array de tamanho 10 é 9 */
            inteiros[0] = 1;
            inteiros[1] = 2;
            inteiros[2] = 3;

            // A propriedade Length retorna a capacidade total do array (neste caso, 10)
            Console.WriteLine(inteiros.Length);

            // Acessa e imprime os valores armazenados nas posições do array.
            Console.WriteLine(inteiros[0]);
            Console.WriteLine(inteiros[1]);
            Console.WriteLine(inteiros[2]);


            /* 2. Forma mais direta: Cria e preenche o array na mesma linha
             * O C# infere o tamanho do array com base no número de elementos fornecidos */
            int[] numeros = [1,2,3,4,5];
            Console.WriteLine(numeros.Length);



            /* --- ARRAYS MULTIDIMENSIONAIS (MATRIZES) --- */

            /* 1. Cria uma matriz bidimensional (linhas e colunas) de tamanho 10x10 */
            int[,] matriz = new int[10,10];

            // Para acessar ou atribuir valores, usa-se a sintaxe [linha, coluna].
            matriz[0,0] = 1;
            matriz[0,2] = 2;

            Console.WriteLine(matriz[0,0]);     // Imprime 1
            Console.WriteLine(matriz[0,1]);     // Imprime 0, pois esta posição não foi atribuída e o valor padrão para inteiros é 0
            Console.WriteLine(matriz[0,2]);     // Imprime 2
        }
    }
}