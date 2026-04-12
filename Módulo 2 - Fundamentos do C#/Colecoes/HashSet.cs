/*
 *  AULA 5 - HASHSET NO C#
 *  MÓDULO 2 - COLEÇÕES 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Colecoes
{
    class ExemploHashSet
    {
        public static void hashSet()
        {
            /* --- HASHSET ---
             * O HashSet<T> é focado em três coisas princiais:
             *      1. Garantir que NÃO existam itens repetidos
             *      2. Ser extremamente rápido na busca de elementos (graças à estrutura de tabela de hash)
             *      3. Permitir operações matemáticos de conjuntos (União, Interseção, etc.) */

            HashSet<int> numeros = new HashSet<int>();

            /* 1. Adicionando itens ao HashSet usando o método Add():
             * O método Add() retorna true se o item foi adicionado com sucesso, ou false se o item já existia no conjunto. */
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);
            bool inseriuNumero = numeros.Add(5);
            Console.WriteLine($"Conseguiu inserir o número 5? {inseriuNumero}");

            // Tentativa de duplicata: Não gera erro e não trava o sistema. Ele simplesmente ignora a adição, mantendo o conjunto inalterado.
            bool inseriuDuplicata = numeros.Add(1);
            Console.WriteLine($"Conseguiu inserir o 1 de novo? {inseriuDuplicata}");


            /* 2. Busca de elementos usando Contains():
             * Em coleções gigantescas, o Contains do HashSet acha o item quase instantaneamente, enquanto em uma lista comum ele teria que percorrer item por item até encontrar ou chegar ao fim. */
            bool existeTres = numeros.Contains(3);
            Console.WriteLine($"O número 3 existe? {existeTres}");



            /* --- O PODER DO HASHSET: OPERAÇÕES DE CONJUNTOS --- */

            // Criando outro HashSet para comparar com o primeiro
            HashSet<int> outrosNumeros = new HashSet<int> {3, 4, 5, 6};

            /* 1. Interseção (IntersecWith):
             * Mantém no conjunto original APENAS os números que existem em AMBOS os conjuntos. */
            numeros.IntersectWith(outrosNumeros);


            /* 2. União (UnionWith):
             * Junta dois conjuntos num só, ignorando automaticamente qualquer número repetido. */
            HashSet<int> maisNumeros = new HashSet<int> {4, 8, 9};
            numeros.UnionWith(maisNumeros);


            /* 3. Remoção de elementos usando Remove()
             * Remove o valor específico. Também retorna true/false caso consiga ou não remover o item. */
            numeros.Remove(4);

        }
    }
}   