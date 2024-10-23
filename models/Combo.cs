 using models;

public class Combo : Producto{


    public string PlatoPrincipal {set;get;}
    public string Bebida {set;get;}
    public string Postre {set;get;}
    public double Descuento {set;get;} = 0.10; 

    //Llamada al constructor de Productos.cs, y aparte le añadimos lo que creamos en este
    public Combo(string platoPrincipal, string bebida, string postre, double descuento): base("ComboCombazo", 0){

        PlatoPrincipal = platoPrincipal;
        Bebida = bebida;
        Postre = postre;
        Descuento = descuento;
        Precio = CalcularPrecio;

    }

    public double CalcularPrecio(){

        double precio = PlatoPrincipal.Precio + Bebida.Precio + Postre.Precio;
        double precioConDescuneto = Precio * (1-Descuento);
        return precioConDescuneto;

    }

    //Usamos el metodo que hemos creado de forma abstracta en Producto.cs y lo rellenamos
    public override void MostrarDetalles(){

        Console.WriteLine($"Plato pricipal: {Nombre}, Bebida: {Bebida}, Postre: {Postre}, Descuento: {Descuento}")
        Console.WriteLine($"Precio final: {Precio}")

    }

     

}