// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



public class Marcas
{
    public int Id;
    public string? Nombre;

    public string? Nacionalidad;
}
public class Locales
{
    public int id;
    public string? Direccion;
    public List<Zapatos>? ZapatosDisponibles;

    
}

public class Personas
{
    public int Id;
    public string? Nombre;

    public string? Telefono;

    public List<Zapatos>? ZapatosComprados;
}

public class Zapatos
{
    public int Id;

    public string? Nombre;

    public Marcas? Marca;

    public int CantidadVendida;
}