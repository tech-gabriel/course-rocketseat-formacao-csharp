namespace OutrosTiposDados;

class Enum
{
    enum DiasDaSemana
    {
        Domingo = 1,
        Segunda = 2,
        Terca = 3,
        Quarta = 4,
        Quinta = 5,
        Sexta = 6,
        Sabado = 7
    }

    static void Main()
    {
        DiasDaSemana dia = DiasDaSemana.Segunda;
        
        int valorNumerico = (int)dia;   // Convertendo o enum para um valor numérico

        Console.WriteLine(valorNumerico);
        Console.WriteLine(dia);
  
    }
}
