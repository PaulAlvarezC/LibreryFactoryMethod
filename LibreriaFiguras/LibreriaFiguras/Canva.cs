namespace LibreriaFiguras
{
    public abstract class Canva
    {
        public int AreaCanva
        {
            get { return areaCanva; }
            set { areaCanva = value; }
        }
        private int areaCanva;

        public abstract IFigura crearFigura(string a, string b, string c);

        public void creadorFiguras(string a, string b, string c)
        {
            Console.WriteLine("Fabrica: Operación en Canva");
            //IFigura figura = crearFigura(a, b, c);
            //figura.dibujarFigura();
        }
    }
}

