using models;

public class Bebida : Producto{


    public bool EsAlcholica {set;get;}

    //Llamada al constructor de Productos.cs, y aparte le añadimos lo que creamos en este
    public Bebida(string nombre, double precio, bool esAlcholica): base(nombre, precio){

         EsAlcholica = esAlcholica;

    }

    //Usamos el metodo que hemos creado de forma abstracta en Producto.cs y lo rellenamos
    public override void MostrarDetalles(){

        string llevaAlcohol = EsAlcholica ? "Si" : "No";
        Console.WriteLine($"Plato pricipal: {Nombre}, Precio: {Precio}, ¿Es alcoholica?: {llevaAlcohol}")

    }

     

}