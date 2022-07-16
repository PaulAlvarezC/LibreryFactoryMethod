namespace LibreriaFiguras
{
    public class Triangulo : IFigura
    {
        public string Texto { get; set; }
        public string Tipo { get; set; }
        public string Cadena { get; set; }

        public void dibujarFigura()
        {
            Console.WriteLine("Producto figura Triangulo");
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

            var arr3 = arreglo[2];
            var number3 = (from t in arr3 where char.IsDigit(t) select t).ToArray();
            //Console.WriteLine(number3);


            var lado1 = Int32.Parse(number1);
            var lado2 = Int32.Parse(number2);
            var lado3 = Int32.Parse(number3);

            double perimetro = lado1 + lado2 + lado3;
            double subperimetro = perimetro / 2;
            double interno = subperimetro * (subperimetro - lado1) * (subperimetro - lado2) * (subperimetro - lado3);
            double area = Math.Sqrt(interno);

            return area;
        }

        public double calcularPerimetro()
        {
            var arreglo = Cadena.Split(";");

            var arr1 = arreglo[0];
            var number1 = (from t in arr1 where char.IsDigit(t) select t).ToArray();
            //Console.WriteLine(number1);

            var arr2 = arreglo[1];
            var number2 = (from t in arr2 where char.IsDigit(t) select t).ToArray();
            //Console.WriteLine(number2);

            var arr3 = arreglo[2];
            var number3 = (from t in arr3 where char.IsDigit(t) select t).ToArray();
            //Console.WriteLine(number3);


            var lado1 = Int32.Parse(number1);
            var lado2 = Int32.Parse(number2);
            var lado3 = Int32.Parse(number3);

            var perimetro = lado1 + lado2 + lado3;
            return perimetro;
        }
    }
}