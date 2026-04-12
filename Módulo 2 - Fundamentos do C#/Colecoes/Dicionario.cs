/*
 *  AULA 4 - DICIONÁRIO NO C#
 *  MÓDULO 2 - COLEÇÕES 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Colecoes;

class Dicionario
{
    public static void dicionarios()
    {
        /* --- DICIONÁRIOS (Dictionary<TKey, TValue>) --- *
         * Um dicionário armazena dados no formato "Chave e Valor"
         * As CHAVES devem sempre ÚNICAS, mas os VALORES podem se repetir. */

        // Criando um dicionário onde a chave é um número (int) e o valor é um texto (string).
        Dictionary<int, string> dicionario = new Dictionary<int, string>();

        /* 1. Adicionando elementos ao dicionário usando o método Add(): */
        dicionario.Add(1, "Gabriel");
        dicionario.Add(2, "Silva");
        dicionario.Add(3, "De Paula Leite");
        // Tentar adicionar uma chave duplicada (como a chave 2) resultará em uma exceção, pois as chaves devem ser únicas.


        /* 2. Lendo e atualizando valores: */
        string valor = dicionario[1];           // Acessa o valor associado à chave 1 ("Gabriel").
        dicionario[1] = "Gabriel Atualizado";   // Atualiza o valor associado à chave 1 para "Gabriel Atualizado".


        /* 3. Verificando se uma chave existe usando ContainsKey():
         * Muito útil para evitar erros ao tentar acessar uma chave que talvez não esteja lá. */
        bool existeChave = dicionario.ContainsKey(2);
        Console.WriteLine($"A chave 2 existe no dicionário? {existeChave}");



        /* --- OPERAÇÕES ESSENCIAIS COM DICIONÁRIOS --- */

        /* 1. Busca mais segura - TryGetValue():
         * Tentar pegar o valor. Se a chave (3) existir, ele joga o resultado na variável e retorna true. 
         * Se não existir, retorna false e não quebra o seu código. */
        if (dicionario.TryGetValue(3, out string sobrenome))
        {
            Console.WriteLine($"Sucesso na busca! O valor da chave 3 é: {sobrenome}");
        }
        else
        {
            Console.WriteLine("A chave 3 não existe no dicionário.");
        };


        /* 2. Removendo um elemento usando Remove():
         * Removendo um item informando a chave dele. */
        dicionario.Remove(2);


        /* 3. Percorrendo o dicionário usando foreach:
         * Como não há indices sequênciais (0, 1, 2), ao varrer o dicionário nós recebemos
         * um objeto do tipo KeyValuePair<TKey, TValue> (Par Chave-Valor), em cada volta do laço */
        foreach (KeyValuePair<int, string> item in dicionario)
        {
            Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
        }
    }
}