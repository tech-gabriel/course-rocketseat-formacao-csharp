namespace TipoPrimitivoDados;

class TiposTexto
{
    static void tiposTexto (){

        /* CHAR: Armazena apenas UM caractere */
        // Usa obrigatoriamente aspas simples ' ' para representar um único caractere
        char letra = 'A'; 
        char numeroComoChar = '1'; // É um texto, não serve para cálculos matemáticos.
        char simbolo = '@';
        char letraComUnicode = '\u0041'; // Representa o mesmo caractere 'A' usando Unicode


        /* STRING: Cadeia de caracteres (texto completo) */
        // Usa obrigatoriamente aspas duplas " " para representar uma sequência de caracteres.
        string texto = "Olá, mundo!";

        // Strings são coleções: podemos acessar letras individuais usando índices, onde o primeiro caractere tem índice 0.
        char primeiraLetra = texto[0]; // Retorna 'O'
        char ultimaLetra = texto[11]; // Retorna '!'

        Console.WriteLine(texto);
        Console.WriteLine(primeiraLetra);


        /* MÉTODOS ÚTEIS PARA STRINGS */
        string meuNome = "     Gabriel      ";

        // Limpeza: Remove espaços em branco no início e no final da string
        string nomeSemEspacos = meuNome.Trim();

        // Busca: Verifica se um trecho existe dentro da string (Retorna True ou False)
        bool nomeContemGabriel = meuNome.Contains("Gabriel");

        // Validação: Verifica se a string começa ou termina com um trecho específico (Retorna True ou False)
        bool nomeComecaComG = meuNome.StartsWith("G"); 
        bool nomeTerminaComL = meuNome.Trim().EndsWith("l"); // Dica: Trim() ajuda a ignorar espaços antes de validar

        // Transformação: Converte a string para maiúsculas ou minúsculas
        string nomeMinusculo = meuNome.ToLower(); // "     gabriel      "
        string nomeMaiusculo = meuNome.ToUpper(); // "     GABRIEL      "

        // Substituição: Substitui um trecho por outro dentro da string
        string nomeSubstituido = meuNome.Replace("Gabriel", "Maria");

    }
}
