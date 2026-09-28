using System;

class Program
{
    static void Main()
    {
     
        Persona p1 = new Persona { Nombre = "Ana", Edad = 25 };
        Persona p2 = new Persona { Nombre = "Luis", Edad = 15 };

      
        p1.Presentarse();
        Console.WriteLine(p1.EsMayor());

        p2.Presentarse();
        Console.WriteLine(p2.EsMayor());

      
        Rectangulo rect = new Rectangulo { Ancho = 5, Alto = 10 };
        Console.WriteLine(rect.Area());
        Console.WriteLine(rect.Perimetro());

      
        Auto auto1 = new Auto { Marca = "Toyota", Modelo = "Corolla", Anio = 2020 };
        Auto auto2 = new Auto { Marca = "Ford", Modelo = "Focus", Anio = 2018 };
        Auto auto3 = new Auto { Marca = "Fiat", Modelo = "Cronos", Anio = 2022 };

       
        auto1.DescripcionCompleta();
        auto2.DescripcionCompleta();
        auto3.DescripcionCompleta();

       
        Persona[] personas = new Persona[]
        {
            new Persona { Nombre = "Carlos", Edad = 30 },
            new Persona { Nombre = "Maria", Edad = 17 },
            new Persona { Nombre = "Juan", Edad = 40 }
        };

        foreach (Persona p in personas)
        {
            p.Presentarse();
        }
    }
}


public class Persona
{
    public string Nombre;
    public int Edad;

    public void Presentarse()
    {
        Console.WriteLine($"{Nombre} - {Edad} años");
    }

    public bool EsMayor()
    {
        return Edad >= 18;
    }
}


public class Rectangulo
{
    public double Ancho;
    public double Alto;

    public double Area()
    {
        return Ancho * Alto;
    }

    public double Perimetro()
    {
        return 2 * (Ancho + Alto);
    }
}


public class Auto
{
    public string Marca;
    public string Modelo;
    public int Anio;

    public void DescripcionCompleta()
    {
        Console.WriteLine($"{Marca} {Modelo} ({Anio})");
    }
}