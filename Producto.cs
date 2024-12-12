
public class Producto
{
    // Atributos
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public double Precio { get; set; }
    public int CantidadEnStock { get; set; }

    // Constructor
    public Producto(string nombre, string descripcion, double precio, int cantidadEnStock)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        Precio = precio;
        CantidadEnStock = cantidadEnStock;
    }

    // Métodos
    public void AgregarAlCarrito()
    {
        Console.WriteLine($"{Nombre} ha sido agregado al carrito.");
    }
}
