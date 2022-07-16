namespace LibreriaFiguras
{
    public class CreadorCuadrado : Canva
    {
        public override IFigura crearFigura(string a, string b, string c)
        {
            Console.WriteLine("Creador: Cuadrado");
            Cuadrado cuadrado = new();
            cuadrado.Texto = a;
            cuadrado.Tipo = b;
            cuadrado.Cadena = c;
            return cuadrado;
        }
    }
}

