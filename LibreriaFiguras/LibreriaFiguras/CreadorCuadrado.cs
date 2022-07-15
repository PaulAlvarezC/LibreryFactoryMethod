namespace LibreriaFiguras
{
    public class CreadorCuadrado : Canva
    {
        public override IFigura crearFigura()
        {
            Console.WriteLine("Creador: Cuadrado");
            return new Cuadrado();
        }
    }
}

