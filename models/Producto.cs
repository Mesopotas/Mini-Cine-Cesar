namespace models;

class Producto{

    public string Nombre {get;set;}

    public double Precio {get;set;}

    public Producto(string nombre, double precio){ //Constructor
        Nombre = nombre;
        Precio = precio;

        //Esto es lo mismo, que en java era this.Nombre = nombre

    }

    public abstract void MostrarDetalles();
    
}