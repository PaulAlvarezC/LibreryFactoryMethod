using LibreriaFiguras;
namespace ProgramaFiguras
{
    public class CreadorTrapecio : Canva
    {
        public override IFigura crearFigura(string a, string b, string c)
        {
            Console.WriteLine("Creador: Trapecio");
            Trapecio trapecio = new();
            trapecio.Texto = a;
            trapecio.Tipo = b;
            trapecio.Cadena = c;
            return trapecio;
        }
    }
}

