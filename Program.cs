using System;

class Program
{
    static void Main()

    {


        Console.WriteLine("Bienvenido al Mercadito Shaila \n");


        Console.WriteLine("1. Listar productos");
        Console.WriteLine("2. Cargar producto");
        Console.WriteLine("3. Listar tipos de producto");
        Console.WriteLine("4. Dar de alta tipo de producto");
        Console.WriteLine("5. Salir");

        // Creación de algunos objetos TipoProducto
        TipoProducto fruta = new TipoProducto(1, "Fruta");
        TipoProducto gaseosa = new TipoProducto(2, "Gaseosa");
        TipoProducto yerba = new TipoProducto(3, "Yerba");


        // Creación de un objeto Producto
        Producto producto1 = new Producto(1, "Banana", fruta );
        Producto producto2 = new Producto(2, "Coca Cola 1.0 lt", gaseosa);
        Producto producto3 = new Producto(3, "Union 500 grs", yerba);


        Console.WriteLine("\n Lista de productos: \n ");
        Console.WriteLine($"NroIdProducto: {producto1.IdProducto}, Producto 1: {producto1.NombreProducto}, Tipo: {producto1.Tipo.NombreTipoProducto}");
        Console.WriteLine($"NroIdProducto: {producto2.IdProducto}, Producto 1: {producto2.NombreProducto}, Tipo: {producto2.Tipo.NombreTipoProducto}");
        Console.WriteLine($"NroIdProducto: {producto3.IdProducto}, Producto 1: {producto3.NombreProducto}, Tipo: {producto3.Tipo.NombreTipoProducto}");
        Console.WriteLine("\n");
        Console.WriteLine("Lista de tipos de Productos: \n ");
        Console.WriteLine($"IdGenero: {fruta.IdTipoProducto}, Genero: {fruta.NombreTipoProducto} ");
        Console.WriteLine($"IdGenero: {gaseosa.IdTipoProducto}, Genero: {gaseosa.NombreTipoProducto} ");
        Console.WriteLine($"IdGenero: {yerba.IdTipoProducto}, Genero: {yerba.NombreTipoProducto} ");

    }
}

// Definición de la clase Producto
public class Producto
{
    // Atributos
    public int IdProducto { get; set; }
    public string NombreProducto { get; set; }
    public TipoProducto Tipo { get; set; }

    // Constructor
    public Producto(int idProducto, string nombreProducto, TipoProducto tipo)
    {
        IdProducto = idProducto;
        NombreProducto = nombreProducto;
        Tipo = tipo;
    }
}

// Definición de la clase TipoProducto
public class TipoProducto
{
    // Atributos
    public int IdTipoProducto { get; set; }
    public string NombreTipoProducto { get; set; }

    // Constructor
    public TipoProducto(int idTipoProducto, string nombreTipoProducto)
    {
        IdTipoProducto = idTipoProducto;
        NombreTipoProducto = nombreTipoProducto;
    }
}