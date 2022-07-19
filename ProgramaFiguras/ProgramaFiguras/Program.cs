//IMPORTO DLL DE MI LIBRERIA
using LibreriaFiguras;
using Newtonsoft.Json;

namespace ProgramaFiguras
{
    public class Program
    {
        //private static string _path = @"C:\data.json";
        private static string _path = @"/Volumes/iGatoAlvarez/data.json";

        public static void Main(string[] args)
        {
            //LEER JSON
            Console.WriteLine("LEER JSON -> FIGURAS");
            var figuras = GetFiguresJsonFromFile();
            Console.WriteLine(figuras);

            Console.WriteLine();
            Console.WriteLine("Defino Creadores y Productos");
            CreadorCuadrado creatorA = new();
            CreadorCirculo creatorB = new();
            CreadorTriangulo creatorC = new();
            CreadorTrapecio creatorD = new();

            Console.WriteLine();
            Console.WriteLine("*********Creadores*********");
            List<IFigura> listaFiguras = new List<IFigura>();

            var fig = JsonConvert.DeserializeObject<List<Modelo>>(figuras);

            if (fig != null)
            {
                for (int i = 0; i < fig.Count; i++)
                {
                    Console.WriteLine("Figura: " + i);
                    if (fig[i].Figura.Nombre == "Cuadrado") {
                        listaFiguras.Add(creatorA.crearFigura(fig[i].Figura.Nombre, fig[i].Figura.Tipo, fig[i].Figura.Cadena));
                    } else if (fig[i].Figura.Nombre == "Circulo") {
                        listaFiguras.Add(creatorB.crearFigura(fig[i].Figura.Nombre, fig[i].Figura.Tipo, fig[i].Figura.Cadena));
                    } else if (fig[i].Figura.Nombre == "Triangulo"){
                        listaFiguras.Add(creatorC.crearFigura(fig[i].Figura.Nombre, fig[i].Figura.Tipo, fig[i].Figura.Cadena));
                    } else if (fig[i].Figura.Nombre == "Trapecio"){
                        listaFiguras.Add(creatorD.crearFigura(fig[i].Figura.Nombre, fig[i].Figura.Tipo, fig[i].Figura.Cadena));
                    } else if (fig[i].Figura.Nombre == "Elipse"){
                        listaFiguras.Add(creatorD.crearFigura(fig[i].Figura.Nombre, fig[i].Figura.Tipo, fig[i].Figura.Cadena));
                    }
                }
            }

            double acumuladorAreas = 0;
            double canvaArea = 70;
            Console.WriteLine();
            Console.WriteLine("*********Productos*******");
            int count = 0;
            foreach (IFigura figu in listaFiguras)
            {
                Console.WriteLine("FIGURA: " + count);
                figu.dibujarFigura();
                double area = figu.calcularArea();
                Console.WriteLine("El Área es: " + area);
                acumuladorAreas = acumuladorAreas + area;
                Console.WriteLine("El Perímetro es: " + figu.calcularPerimetro());
                Console.WriteLine("==========================");
                count++;
            }

            Console.WriteLine();
            Console.WriteLine("AREA TOTAL DE CANVA  : " + canvaArea);
            Console.WriteLine();
            Console.WriteLine("AREA TOTAL DE FIGURAS: " + acumuladorAreas);
            Console.WriteLine();
            Console.WriteLine("FABRICA");
            if (canvaArea > acumuladorAreas)
            {
                foreach (IFigura figu in listaFiguras)
                {
                    Console.WriteLine();
                    Console.WriteLine("*****DIBUJANDO EN CANVA****");
                    figu.dibujarFigura();
                }
            }
            else
            {
                Console.WriteLine("ÁREA DE CANVA INSUFICIENTE");
            }
        }

        public static string GetFiguresJsonFromFile()
        {
            string figurasFromFile;
            using (var render = new StreamReader(_path))
            {
                figurasFromFile = render.ReadToEnd();
            }
            return figurasFromFile;
        }

    }
}