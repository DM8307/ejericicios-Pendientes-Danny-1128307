using System;
using System.Collections.Generic;
using System.Linq;

namespace Programadeelecciones
{
    internal class Program
    {
        // Clase que representa a un candidato
        class Candidato
        {
            public string Nombre { get; set; } // Nombre del candidato
            public List<int> VotosPorDistrito { get; set; } = new List<int>(); // Lista de votos por distrito
            public int TotalVotos => VotosPorDistrito.Sum(); // Total de votos sumando todos los distritos

            // Calcula el porcentaje de votos del candidato respecto al total general
            public double PorcentajeVotos(int totalGeneral)
            {
                return totalGeneral == 0 ? 0 : (double)TotalVotos / totalGeneral * 100;
            }
        }

        // Clase que representa la elección
        class Eleccion
        {
            public List<Candidato> Candidatos { get; set; } = new List<Candidato>(); // Lista de candidatos

            // Calcula el total de votos de todos los candidatos
            public int CalcularTotalGeneral()
            {
                return Candidatos.Sum(c => c.TotalVotos);
            }

            // Obtiene al ganador si tiene más del 50% de los votos
            public Candidato ObtenerGanador()
            {
                int total = CalcularTotalGeneral();
                return Candidatos.FirstOrDefault(c => c.PorcentajeVotos(total) > 50);
            }

            // Obtiene los dos candidatos más votados
            public List<Candidato> ObtenerDosMasVotados()
            {
                return Candidatos.OrderByDescending(c => c.TotalVotos).Take(2).ToList();
            }

            // Imprime una tabla con los votos por distrito
            public void ImprimirTabla()
            {
                int anchoColumna = 15; // Ancho de cada columna en la tabla

                // Encabezado de la tabla
                Console.Write("Distrito".PadRight(anchoColumna));
                foreach (var c in Candidatos)
                {
                    string nombre = c.Nombre.Length > anchoColumna ? c.Nombre.Substring(0, anchoColumna - 1) + "…" : c.Nombre;
                    Console.Write(nombre.PadRight(anchoColumna));
                }
                Console.WriteLine();

                // Filas con los votos por distrito
                int numDistritos = Candidatos[0].VotosPorDistrito.Count;
                for (int i = 0; i < numDistritos; i++)
                {
                    Console.Write($"{(i + 1).ToString().PadRight(anchoColumna)}"); // Número de distrito
                    foreach (var c in Candidatos)
                    {
                        Console.Write(c.VotosPorDistrito[i].ToString().PadRight(anchoColumna)); // Votos del candidato en el distrito
                    }
                    Console.WriteLine();
                }
            }

            // Imprime los resultados totales de la elección
            public void ImprimirResultados()
            {
                int totalGeneral = CalcularTotalGeneral();
                Console.WriteLine("\nResultados Totales:");
                foreach (var c in Candidatos)
                {
                    // Muestra el total de votos y el porcentaje de cada candidato
                    Console.WriteLine($"Candidato {c.Nombre}: {c.TotalVotos} votos ({c.PorcentajeVotos(totalGeneral):F2}%)");
                }

                // Determina si hay un ganador o si se requiere una segunda ronda
                var ganador = ObtenerGanador();
                if (ganador != null)
                {
                    Console.WriteLine($"\n Candidato {ganador.Nombre} ha ganado con más del 50% de los votos.");
                }
                else
                {
                    var top2 = ObtenerDosMasVotados();
                    Console.WriteLine("\n?? Ningún candidato obtuvo más del 50%.");
                    Console.WriteLine($" Pasan a segunda ronda: {top2[0].Nombre} y {top2[1].Nombre}");
                }
            }
        }

        static void Main(string[] args)
        {
            int cantidadCandidatos, cantidadDistritos;

            // Solicita al usuario la cantidad de candidatos
            Console.Write("¿Cuántos candidatos hay? ");
            while (!int.TryParse(Console.ReadLine(), out cantidadCandidatos) || cantidadCandidatos <= 0)
            {
                Console.Write("Ingrese un número válido de candidatos: ");
            }

            // Solicita al usuario la cantidad de distritos
            Console.Write("¿Cuántos distritos hay? ");
            while (!int.TryParse(Console.ReadLine(), out cantidadDistritos) || cantidadDistritos <= 0)
            {
                Console.Write("Ingrese un número válido de distritos: ");
            }

            var eleccion = new Eleccion();

            // Solicita los datos de cada candidato
            for (int i = 0; i < cantidadCandidatos; i++)
            {
                Console.Write($"Nombre del candidato #{i + 1}: ");
                string nombre = Console.ReadLine();

                var candidato = new Candidato { Nombre = nombre };

                // Solicita los votos por distrito para el candidato
                for (int j = 0; j < cantidadDistritos; j++)
                {
                    int votos;
                    Console.Write($"Votos del distrito #{j + 1} para {nombre}: ");
                    while (!int.TryParse(Console.ReadLine(), out votos) || votos < 0)
                    {
                        Console.Write("Ingrese un número válido de votos: ");
                    }
                    candidato.VotosPorDistrito.Add(votos);
                }

                eleccion.Candidatos.Add(candidato);
            }

            // Limpia la consola y muestra los resultados
            Console.Clear();
            eleccion.ImprimirTabla();
            eleccion.ImprimirResultados();
        }
    }
}
