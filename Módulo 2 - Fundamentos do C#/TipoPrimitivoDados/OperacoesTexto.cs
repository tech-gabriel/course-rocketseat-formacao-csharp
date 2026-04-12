using System.Text;

namespace TipoPrimitivoDados;

class OperacoesTexto
{
    static void operacoesTexto() { 
    
        string texto1 = "A primeira frase.";
        string texto2 = "A segunda frase.";

        // CONCATENAÇÃO SIMPLES: Une as strings usando os operador '+'
        // Útil para junções rápidas e curtas
        string textoConcatenado = texto1 + " " + texto2;
        Console.WriteLine(textoConcatenado);

        // INTERPOLAÇÃO DE STRINGS: A forma mais moderna e legível (usa o cifrão $)
        // Permite inserir variáveis diretamente dentro da string, melhorando a legibilidade e evitando erros comuns de concatenação
        string textoInterpolado = $"Texto 1: {texto1}, Texto 2: {texto2}";
        Console.WriteLine(textoInterpolado);

        // STRINGBUILDER: Ideal para concatenações em loops ou quando a string resultante é muito grande, pois é mais eficiente em termos de desempenho
        // Diferente das strings comuns, ele não cria um novo objeto na memória a cada concatenação, o que pode melhorar significativamente o desempenho em casos de muitas concatenações
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(texto1);
        stringBuilder.Append(texto2);  
        string resultadoStringBuilder = stringBuilder.ToString();
        Console.WriteLine(resultadoStringBuilder);

        // LITERAL DE STRING: Usando @ para criar uma string literal, onde os caracteres de escape são tratados como texto normal, facilitando a escrita de caminhos de arquivos ou strings com muitas barras
        // Essencial para caminhos de arquivos ou textos com múltiplas linhas
        string caminhoArquivo = @"C:\Users\Gabriel\Documents\arquivo.txt";

        // FORMATAÇÃO DE STRINGS: Usando string.Format para formatar uma string com parâmetros, onde os placeholders {0}, {1}, etc. são substituídos pelos valores fornecidos
        // Útil para criar strings dinâmicas com múltiplos valores, especialmente quando a formatação é complexa ou quando os valores são fornecidos em tempo de execução
        string textoComParametros = "Este é o primeiro parametro {0}. Este é o segundo parametro {1}";
        string textoFormatado = string.Format(textoComParametros, "parametro1", "parametro2"); // Usando string.Format para formatar a string com parâmetros  
        Console.WriteLine(textoFormatado);

    }
}
