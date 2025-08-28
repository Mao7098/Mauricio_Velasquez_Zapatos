
Console.WriteLine("Hello, World!");

public class Marcas
{
    public int Id;
    public string? Nombre;

    
}

public class Zapatos
{
    
    public string? Nombre;
    public int Precio;

    public Marcas? Marca;
}


public class Ventas
{
    public Personas? Cliente;

    public Zapatos? Zapato;

}

public class Personas
{
    public int Id;
    public string? Nombre;
}
