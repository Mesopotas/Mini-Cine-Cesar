namespace models;

class Peliculas{

    public string Nombre {get;set;}

    public double Precio {get;set;}

    public Peliculas(string nombre, double precio){ //Constructor
        Nombre = nombre;
        Precio = precio;

        //Esto es lo mismo, que en java era this.Nombre = nombre

    }
    
}