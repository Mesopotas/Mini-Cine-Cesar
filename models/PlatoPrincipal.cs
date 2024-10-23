using models;

public class PlatoPrincipal : Producto{


    public string Ingredientes {set;get;}

    //Llamada al constructor de Productos.cs, y aparte le añadimos lo que creamos en este
    public PlatoPrincipal(string nombre, double precio, string Ingredientes): base(nombre, precio){

        Ingredientes = ingredientes;

    }

    //Usamos el metodo que hemos creado de forma abstracta en Producto.cs y lo rellenamos
    public override void MostrarDetalles(){

        Console.WriteLine($"Plato pricipal: {Nombre}, Precio: {Precio}, Ingredientes: {Ingredientes}")

    }

     

}