namespace LibreriaFiguras
{
    public class CreadorTriangulo : Canva
    {
        public override IFigura crearFigura()
        {
            Console.WriteLine("Creador: Triangulo");
            return new Triangulo();
        }
    }
}

