namespace LibreriaFiguras
{
    public abstract class Canva
    {
        public abstract IFigura crearFigura();

        public void creadorFiguras()
        {
            Console.WriteLine("Fabrica: Operación en Canva");
            IFigura figura = crearFigura();
            figura.dibujarFigura();
        }
    }
}

