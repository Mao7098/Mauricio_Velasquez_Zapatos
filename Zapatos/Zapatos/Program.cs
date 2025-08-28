// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Marcas
{
    public int Id;
    public string? Nombre;
}
public class Personas
{
    public int Id;
    public string? Nombre;

    public string? Telefono;
}

public class Catalogo
{
    public List<Zapatos>? Zapatos;
}

public class Zapatos
{
    public int Id;

    public string? Nombre;

    public Marcas? Marca;
}