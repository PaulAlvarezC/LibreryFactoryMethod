using LibreriaFiguras;

namespace ProgramaFiguras
{
    public class CreadorTrapecio : Canva
    {
        public override IFigura crearFigura()
        {
            Console.WriteLine("Creador: Trapecio");
            return new Trapecio();
        }
    }
}