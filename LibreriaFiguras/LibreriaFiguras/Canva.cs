namespace LibreriaFiguras
{
    public abstract class Canva
    {
        public abstract IFigura crearFigura(string a, string b, string c);

        public void creadorFiguras(string a, string b, string c)
        {
            Console.WriteLine("Fabrica: Operación en Canva");
            //IFigura figura = crearFigura(a, b, c);
            //figura.dibujarFigura();
        }
    }
}

