/*
 *  AULA 3 - MAIS SOBRE LISTAS NO C#
 *  MÓDULO 2 - COLEÇÕES 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Colecoes;

class MaisListas
{
    public static void maisListas()
    {
        /* --- LISTAS DE TEXTOS (STRINGS) --- */
        List<string> nomes = new List<string>();
        nomes.Add("Gabriel");
        nomes.Add("Silva");
        nomes.Add("De Paula Leite");

        /* 1. O método string.Join() é excelente para "colar" todos os itens da lista.
         * Ele recebe um separador (que pode ser um espaço, vírgula, ou qualquer outro caractere) e a coleção de itens que queremos juntar. */
        string nomeCompleto = string.Join(" ", nomes);
        Console.WriteLine($"Primeiro nome: {nomes[0]}");



        /* --- LISTAS DE OUTROS TIPOS PRIMITIVOS --- */

        /* 1.Lista de decimais (muito usado para valores financeiros):
         * Lembrete-se de usar o sufixo 'm' ou 'M' para indicar que o número é do tipo decimal, caso contrário, ele será tratado como um double por padrão. */
        List<decimal> decimais = new List<decimal>();
        decimais.Add(2.5m);
        decimais.Add(150.99m);


        /* 2. Lista de valores booleanos (true/false): */
        List<bool> booleanos = new List<bool>();
        booleanos.Add(true);
        booleanos.Add(false);



        /* --- LISTA DE OBJETOS (Tipos mistos) --- */

        /* 1. Como 'object' é a classe "pai" de todos os tipos no C#,
         * uma List<objects> permite armazenar QUALQUER  coisa misturada, desde strings e números até objetos personalizados. */
        List<object> objetos = new List<object>();
        objetos.Add("Uma string");
        objetos.Add(20);
        objetos.Add(3.14m);
    }
}
