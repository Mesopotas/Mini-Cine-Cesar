using models;

public class Postre : Producto{


    public bool ConAzucar {set;get;}
    
     public int Calorias {set;get;}

    //Llamada al constructor de Productos.cs, y aparte le añadimos lo que creamos en este
    public Postre(string nombre, double precio, bool conAzucar, int calorias): base(nombre, precio){

         ConAzucar = conAzucar;
         Calorias = calorias;

    }

    //Usamos el metodo que hemos creado de forma abstracta en Producto.cs y lo rellenamos
    public override void MostrarDetalles(){

        string ComprobacionAzucar = ConAzucar ? "Si" : "No";
        Console.WriteLine($"Plato pricipal: {Nombre}, Precio: {Precio}, Calorias: {Calorias}, ¿LLeva azucar?: {ComprobacionAzucar}")

    }

     

}