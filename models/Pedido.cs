namespace models;

class Pedido {

    private List<Producto>  productos;

    public Pedido(){

        productos = new List<Producto>();

    }

    public void AñadirProductos(Producto producto){

        productos.Add(producto);
        Console.WriteLine($"Producto añadido: {producto.Nombre}")

    }

    public void MostrarPedido(){

        Console.WriteLine("\n--------Pedido--------")
        foreach (var producto in productos)        {
            producto.MostrarDetalles();
        }

    }

    public double CalcularTotal(){

        duble total = 0;
        foreach (var producto in productos){
            total += producto.Precio;
        }
    return total;
    }

}