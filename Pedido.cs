
public class Pedido
{
    // Atributos
    public int NumeroPedido { get; set; }
    public DateTime Fecha { get; set; }
    public string Estado { get; set; }
    public List<Producto> Productos { get; set; }

    // Constructor
    public Pedido(int numeroPedido, DateTime fecha, List<Producto> productos)
    {
        NumeroPedido = numeroPedido;
        Fecha = fecha;
        Estado = "Pendiente";
        Productos = productos;
    }

    // Métodos
    public void ConfirmarPedido()
    {
        Estado = "Confirmado";
        Console.WriteLine($"El pedido {NumeroPedido} ha sido confirmado.");
    }

    public void CancelarPedido()
    {
        Estado = "Cancelado";
        Console.WriteLine($"El pedido {NumeroPedido} ha sido cancelado.");
    }
}
