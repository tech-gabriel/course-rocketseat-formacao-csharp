
namespace HelloWorld;

class Carro
{
    public void Ligar()
    {
        Console.WriteLine("O carro está ligado.");
    }

    public void Desligar()
    {
        Console.WriteLine("O carro está desligado.");
    }

    private void Acelerar()
    {
        Console.WriteLine("O carro está acelerando.");
    }

    internal void Frear()
    {
        Acelerar();
        Console.WriteLine("O carro está freando.");
    }
}

