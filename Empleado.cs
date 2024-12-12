
public class Empleado
{
    // Atributos
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string CorreoElectronico { get; set; }
    public List<Pedido> HistorialDeVentas { get; set; }

    // Constructor
    public Empleado(string nombre, string direccion, string correoElectronico)
    {
        Nombre = nombre;
        Direccion = direccion;
        CorreoElectronico = correoElectronico;
        HistorialDeVentas = new List<Pedido>();
    }

    // Métodos
    public void ConsultarVentas()
    {
        Console.WriteLine("Historial de ventas:");
        foreach (var pedido in HistorialDeVentas)
        {
            Console.WriteLine($"Pedido {pedido.NumeroPedido} - Estado: {pedido.Estado}");
        }
    }
}
