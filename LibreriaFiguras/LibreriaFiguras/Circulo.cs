namespace LibreriaFiguras
{
    public class Circulo : IFigura
    {
        public string Texto { get; set; }
        public string Tipo { get; set; }
        public string Cadena { get; set; }

        public void dibujarFigura()
        {
            Console.WriteLine("Producto figura Circulo");
            Console.WriteLine("Texto  : " + Texto);
            Console.WriteLine("Tipo   : " + Tipo);
            Console.WriteLine("Cadena : " + Cadena);
        }

        public double calcularArea() {
            var arreglo = Cadena.Split(";");
            var arr1 = arreglo[0];
            var number1 = (from t in arr1 where char.IsDigit(t) select t).ToArray();
            //Console.WriteLine(number1);
            var radio = Int32.Parse(number1);
            var area = 3.14 * Math.Pow(radio, 2);
            return area;
        }

        public double calcularPerimetro()
        {
            var arreglo = Cadena.Split(";");
            var arr1 = arreglo[0];
            var number1 = (from t in arr1 where char.IsDigit(t) select t).ToArray();
            //Console.WriteLine(number1);
            var radio = Int32.Parse(number1);
            var perimetro = 2 * 3.14 * radio;
            return perimetro;
        }
    }
}

