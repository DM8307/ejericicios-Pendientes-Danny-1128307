// See https://aka.ms/new-console-template for more information
using TriangulosClases;

bool condicion = true;
string eleccion;
while (condicion)
{
	Console.Write($"\n1. - Que tipo de triangulo es? \n2. - Salir \n:");
	eleccion = Console.ReadLine();
    Console.Clear();
	switch (eleccion)
	{
		case "1":
            Console.WriteLine("Ingrese el valor del lado 1 del triángulo:");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del lado 2 del triángulo:");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del lado 3 del triángulo:");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            Triangulos triangulo = new Triangulos(lado1, lado2, lado3);

            triangulo.MostrarLados();

            if (triangulo.EsTriangulo())
            {
                Console.WriteLine("Es un triángulo válido.");
                Console.WriteLine($"Tipo de triángulo: {triangulo.TipoTriangulo()}");
            }
            else
            {
                Console.WriteLine("Los lados ingresados no forman un triángulo.");
            }
            break;
		case "2":
			condicion = false;
			break;
		default:
			Console.WriteLine("Debe seleccionar una opcion. ");
			break;
	}
}