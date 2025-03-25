using System;

class Celular
{
    // Atributos
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }

    // Construtor
    public Celular(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    // Método para exibir detalhes
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
    }
}

class Program
{
    static void Main()
    {
        // Instanciando dois objetos da classe Celular
        Celular celular1 = new Celular("Samsung", "Galaxy A21", 2025);
        Celular celular2 = new Celular("Apple", "iPhone 16", 2025);

        // Chamando o método para exibir os detalhes
        Console.WriteLine("Detalhes do celular 1:");
        celular1.ExibirDetalhes();

        Console.WriteLine("\nDetalhes do celular 2:");
        celular2.ExibirDetalhes();
    }
}


