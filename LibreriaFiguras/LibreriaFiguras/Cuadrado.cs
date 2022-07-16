namespace LibreriaFiguras
{
    public class Cuadrado : IFigura
    {
        public string Texto { get; set; }
        public string Tipo { get; set; }
        public string Cadena { get; set; }

        public void dibujarFigura()
        {
            Console.WriteLine("Producto figura Cuadrado");
            Console.WriteLine("Texto  : " + Texto);
            Console.WriteLine("Tipo   : " + Tipo);
            Console.WriteLine("Cadena : " + Cadena);
        }

        public double calcularArea()
        {
            var arreglo = Cadena.Split(";");
            var arr1 = arreglo[0];
            var number1 = (from t in arr1 where char.IsDigit(t) select t).ToArray();
            //Console.WriteLine(number1);
            var arr2 = arreglo[1];
            var number2 = (from t in arr2 where char.IsDigit(t) select t).ToArray();
            //Console.WriteLine(number2);

            var lado1 = Int32.Parse(number1);
            var lado2 = Int32.Parse(number2);
            var area = lado1 * lado2;
            return area;
        }

        public double calcularPerimetro()
        {
            var arreglo = Cadena.Split(";");
            var arr1 = arreglo[0];
            var number1 = (from t in arr1 where char.IsDigit(t) select t).ToArray();
            //Console.WriteLine(number1);
            
            var lado = Int32.Parse(number1);
            var perimetro = lado * 4;
            return perimetro;
        }

    }
}

