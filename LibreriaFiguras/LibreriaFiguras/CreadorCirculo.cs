namespace LibreriaFiguras
{
    public class CreadorCirculo : Canva
    {
        public override IFigura crearFigura(string a, string b, string c)
        {
            Console.WriteLine("Creador: Circulo");
            Circulo circulo = new();
            circulo.Texto = a;
            circulo.Tipo = b;
            circulo.Cadena = c;
            return circulo;
        }
    }
}

