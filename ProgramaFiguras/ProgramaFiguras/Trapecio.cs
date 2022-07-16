using LibreriaFiguras;
namespace ProgramaFiguras
{
    public class Trapecio : IFigura
    {
        public string Texto { set; get; }
        public string Tipo { set; get; }
        public string Cadena { set; get; }

        double IFigura.calcularArea()
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
            var arr4 = arreglo[3];
            var number4 = (from t in arr4 where char.IsDigit(t) select t).ToArray();
            //Console.WriteLine(number4);
            var arr5 = arreglo[4];
            var number5 = (from t in arr5 where char.IsDigit(t) select t).ToArray();
            //Console.WriteLine(number5);

            var a = Int32.Parse(number1);
            var b = Int32.Parse(number2);
            var c = Int32.Parse(number3);
            var d = Int32.Parse(number4);
            var h = Int32.Parse(number5);
            var area = h * (a + b)/2;
            return area;
        }

        double IFigura.calcularPerimetro()
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
            var arr4 = arreglo[3];
            var number4 = (from t in arr4 where char.IsDigit(t) select t).ToArray();
            //Console.WriteLine(number4);

            var a = Int32.Parse(number1);
            var b = Int32.Parse(number2);
            var c = Int32.Parse(number3);
            var d = Int32.Parse(number4);
            var perimetro = a + b + c + d;
            return perimetro;
        }

        void IFigura.dibujarFigura()
        {
            Console.WriteLine("Dibujando figura: ");
            Console.WriteLine("Texto  : " + Texto);
            Console.WriteLine("Tipo   : " + Tipo);
            Console.WriteLine("Cadena : " + Cadena);
        }
    }
}

