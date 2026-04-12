/*
 *  AULA 2 - LISTAS EM C#
 *  MÓDULO 2 - COLEÇÕES 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Colecoes
{ 
    internal class Listas
    {
        public static void listas()
        {
            /* --- LISTAS (List<T>) --- 
             *  Diferente dos arrays (que têm tamanho fixo), as listas são dinâmicas.
             *  Elas podem crescer ou encolher automaticamente conforme elementos são adicionados ou removidos. */
        
            List<int> inteiros = new List<int>();

            /* 1. Adiciona elementos à lista usando o método Add: */
            inteiros.Add(1);
            inteiros.Add(2);
            inteiros.Add(3);
            inteiros.Add(4);


            /* 2. Remove() apaga a primeira ocorrência do valor informado, e não a posição do elemento.
             * Se quisermos remover um elemento por índice, devemos usar RemoveAt() */
            inteiros.Remove(1);

            // A propriedade Count retorna o número atual de elementos na lista (neste caso, 3)
            Console.WriteLine(inteiros.Count);

            // O acesso via índice funciona exatamente igual aos arrays (começando em 0)
            Console.WriteLine($"Índice 0: {inteiros[0]}");
            Console.WriteLine($"Índice 1: {inteiros[1]}");



            /* --- OPERAÇÕES ESSENCIAIS COM LISTAS --- */

            /* 1. Removendo por índice:
             * RemoveAt() remove o elemento na posição especificada. */
            inteiros.RemoveAt(0);       // Remove o elemento na posição 0, resultando em [3, 4]


            /* 2. Verificando se um item existe:
             * Contains() retorna true se o item estiver presente na lista. */
            bool existeQuatro = inteiros.Contains(4);


            /* 3. Percorrendo a lista inteira:
             * Podemos usar um loop foreach para iterar sobre os elementos da lista. */
            Console.WriteLine("Itens restantes na lista:");
            foreach (int numero in inteiros) 
            {
                Console.WriteLine($"- {numero}");
            };


            /* 4. Criação e preenchimento direto:
             * Assim como os arrays, podemos criar e preencher uma lista na mesma linha usando a sintaxe de inicialização. 
             * Usar colchetes para instanciar listas é uma funcionalidade moderna do C# 12+ */
            List<int> numerosProntos = [10, 20, 30, 40];
        }
    }
}