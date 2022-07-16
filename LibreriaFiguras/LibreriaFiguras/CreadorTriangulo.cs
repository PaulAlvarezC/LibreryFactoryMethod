namespace LibreriaFiguras
{
    public class CreadorTriangulo : Canva
    {
        public override IFigura crearFigura(string a, string b, string c)
        {
            Console.WriteLine("Creador: Triangulo");
            Triangulo triangulo = new();
            triangulo.Texto = a;
            triangulo.Tipo = b;
            triangulo.Cadena = c;
            return triangulo;
        }
    }
}

