using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangulosClases
{
    public class Triangulos
    {
        private double lado1;
        private double lado2;
        private double lado3;

        // Constructor para almacenar los lados y luego verificar
        public Triangulos(double l1, double l2, double l3)
        {
            lado1 = l1;
            lado2 = l2;
            lado3 = l3;
        }

        // Método para mostrar los lados
        public void MostrarLados()
        {
            Console.WriteLine($"Lados del triángulo: {lado1}, {lado2}, {lado3}");
        }

        // Método para verificar si es un triángulo válido
        public bool EsTriangulo()
        {
            return (lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1);
        }

        // Método para determinar el tipo de triángulo
        public string TipoTriangulo()
        {
            if (!EsTriangulo())
            {
                return "No es un triángulo válido";
            }

            if (lado1 == lado2 && lado2 == lado3)
            {
                return "Triángulo Equilátero";
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                return "Triángulo Isósceles";
            }
            else
            {
                return "Triángulo Escaleno";
            }
        }
    }
}
