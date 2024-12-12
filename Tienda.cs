
public class Tienda
{
    // Atributos
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public List<Empleado> Empleados { get; set; }
    public List<Pedido> Pedidos { get; set; }
    public double VentasTotales { get; set; }

    // Constructor
    public Tienda(string nombre, string direccion, string telefono)
    {
        Nombre = nombre;
        Direccion = direccion;
        Telefono = telefono;
        Empleados = new List<Empleado>();
        Pedidos = new List<Pedido>();
        VentasTotales = 0.0;
    }

    // Métodos
    public void RegistrarEmpleado(Empleado empleado)
    {
        Empleados.Add(empleado);
        Console.WriteLine($"Empleado {empleado.Nombre} registrado en la tienda.");
    }

    public void RegistrarPedido(Pedido pedido)
    {
        Pedidos.Add(pedido);
        VentasTotales += pedido.Productos.Sum(p => p.Precio);
        Console.WriteLine($"Pedido {pedido.NumeroPedido} registrado.");
    }
}
