using models;


//Inicializamos la clase PlatoPrincipal, nombrandola como "plato", y en la informacion, la rellenamos
var plato = new PlatoPrincipal("Plato combinado", 9.99, "Pollo, patatas, ensalada")
//Hacemos que muestre los detalles porque asi lo creamos en PlatoPrincipal.cs
plato.MostrarDetalles();


//Inicializamos la clase Bebida, nombrandola como "bebida", y en la informacion, la rellenamos, diferente a PlatoPrincipal, pues no tiene Ingredientes, sino, EsAlcoholica que es bool
var bebida = new Bebida("Cerveza", 2.0, "false")
//Hacemos que muestre los detalles porque asi lo creamos en PlatoPrincipal.cs
bebida.MostrarDetalles();


//Inicializamos la clase Bebida, nombrandola como "bebida", y en la informacion, la rellenamos, diferente a PlatoPrincipal, pues no tiene Ingredientes, sino, EsAlcoholica que es bool
var postre = new Postre("Tarta de Queso", 4.0, 650, "true")
//Hacemos que muestre los detalles porque asi lo creamos en PlatoPrincipal.cs
bebida.MostrarDetalles();

//Iniciamos Pedido en pedido
var pedido = new Pedido();

//Vamos añadiendo los productos que anteriormente hemos creado, llamando a la funcion creada con .NombreDeLaFuncion, en este caso es .AñadirProductos
pedido.AñadirProductos(plato);
pedido.AñadirProductos(bebida);
pedido.AñadirProductos(postre);

//Mostamos el pedido con la funcionque hemos creado
pedido.MostrarPedido();
 

var total = pedido.CalcularTotal();
Console.WriteLine($"El total es: {total}")