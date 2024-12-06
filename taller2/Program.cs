

using taller2.Builder;
using taller2.Enitiy;
using taller2.Factory;
using taller2.Singlenton;

var productoBasico = ProductoFactory.CrearProducto("Ropa") as Ropa;

Marca marca = new Marca();
marca.Nombre = "Nike";
marca.Pais = "Estados Unidos";
productoBasico.Marca = marca;

Material material = new Material();
material.Nombre = "Natural";

Tela tela = new Tela();
tela.Nombre = "Tejido Natural";
tela.MaterialPrincipal = "Tejido Animal";
tela.PorcentajeMaterialPrincipal = 100;

productoBasico.Tela = tela;

var builder = new ProductoBuilder(productoBasico);
builder.SetColor("Gris").SetTalla("M").SetMaterial("Cuero").Construir().Nombre="Chaqueta";



var productoClonado = productoBasico.Clonar();

var adminPedidos = AdministradorPedidos.ObtenerInstancia();
var pedido = adminPedidos.RegistrarPedido(productoBasico);
pedido.Estado = "Registrado";
Console.WriteLine($"Pedido {pedido.Estado} con ID {pedido.Id}\n producto Ropa\n Nombre: {productoBasico.Nombre}\n Talla: {productoBasico.Talla}\n Color: {productoBasico.Color} \n Marca:" +
    $" {productoBasico.Marca.Nombre}\n Material: {productoBasico.Tela.MaterialPrincipal}\n Prcentaje del Material: {productoBasico.Tela.PorcentajeMaterialPrincipal}%");
