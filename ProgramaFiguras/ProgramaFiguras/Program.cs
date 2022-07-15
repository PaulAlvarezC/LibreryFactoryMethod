//IMPORTO DLL DE MI LIBRERIA
using LibreriaFiguras;

namespace ProgramaFiguras
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreadorCuadrado creatorA = new();
            CreadorCirculo creatorB = new();
            CreadorTriangulo creatorC = new();
            CreadorTrapecio creatorD = new();

            Console.WriteLine();
            Console.WriteLine("Defino Creadores y Productos");

            Console.WriteLine();
            Console.WriteLine("*********Creadores*********");
            List<IFigura> listaFiguras = new List<IFigura>();
            listaFiguras.Add(creatorA.crearFigura());
            listaFiguras.Add(creatorB.crearFigura());
            listaFiguras.Add(creatorC.crearFigura());
            listaFiguras.Add(creatorD.crearFigura());

            Console.WriteLine();
            Console.WriteLine("*********Productos*******");
            foreach (IFigura fig in listaFiguras)
            {
                fig.dibujarFigura();
            }

            List<Canva> listaCreator = new List<Canva>();

            listaCreator.Add(new CreadorCuadrado());
            listaCreator.Add(new CreadorCirculo());
            listaCreator.Add(new CreadorTriangulo());
            listaCreator.Add(new CreadorTrapecio());

            
            Console.WriteLine();
            Console.WriteLine("*********Fabricas*****");
            foreach (Canva canva in listaCreator)
            {
                canva.creadorFiguras();
                Console.WriteLine();
            }
        }
    }
}