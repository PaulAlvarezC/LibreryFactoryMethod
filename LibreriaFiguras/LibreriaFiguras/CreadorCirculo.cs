namespace LibreriaFiguras
{
    public class CreadorCirculo : Canva
    {
        public override IFigura crearFigura()
        {
            Console.WriteLine("Creador: Circulo");
            return new Circulo();
        }
    }
}

