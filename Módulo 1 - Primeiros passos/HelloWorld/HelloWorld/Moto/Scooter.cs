namespace HelloWorld.Moto;

class Scooter
{
    public void Ligar()
    {
        Console.WriteLine("A moto está ligada.");
    }

    public void Desligar()
    {
        Console.WriteLine("A moto está desligada.");
    }

    private void Acelerar()
    {
        Console.WriteLine("A moto está acelerando.");
    }

    internal void Frear()
    {
        Acelerar();
        Console.WriteLine("A moto está freando.");
    }
}
