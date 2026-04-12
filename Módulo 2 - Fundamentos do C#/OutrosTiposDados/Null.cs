namespace OutrosTiposDados;

class Null
{
    static void Main() {

        int? idade = 25; // Variável do tipo int? (nullable int) que pode conter um valor inteiro ou null

        int? idade2 = null;

        int minhaIdade = idade.Value; // Acessa o valor da variável, mas pode lançar uma exceção se for null

        bool informouIdade = idade.HasValue; // Verifica se a variável tem um valor atribuído

        DateTime? date = null;

        if (date.HasValue)
        {
            Console.WriteLine(date.Value);
        }
        else
        {
            Console.WriteLine("A data é nula.");
        }


    }
    
}
