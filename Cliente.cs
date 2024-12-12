
public class Cliente
{
    // Atributos
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string CorreoElectronico { get; set; }
    public List<Producto> HistorialDeCompras { get; set; }

    // Constructor
    public Cliente(string nombre, string direccion, string correoElectronico)
    {
        Nombre = nombre;
        Direccion = direccion;
        CorreoElectronico = correoElectronico;
        HistorialDeCompras = new List<Producto>();
    }

    // Métodos
    public void RealizarCompra(Pedido pedido)
    {
        Console.WriteLine($"{Nombre} ha realizado una compra.");
        HistorialDeCompras.AddRange(pedido.Productos);
    }

    public void VerCarrito(List<Producto> carrito)
    {
        Console.WriteLine("Carrito de compras:");
        foreach (var producto in carrito)
        {
            Console.WriteLine($"{producto.Nombre} - {producto.Precio:C}");
        }
    }
}
