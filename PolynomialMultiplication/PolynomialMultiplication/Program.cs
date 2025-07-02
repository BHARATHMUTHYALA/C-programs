namespace PolynomialMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Polynomial(1, 2, 3);
            var p2 = new Polynomial(3, 2, 1);

            Console.WriteLine("Polynomial 1 is :\np1: " + p1);
            Console.WriteLine("Polynomial 2 is :\np2: " + p2);
            Console.WriteLine("Product is :\nproduct: " + (p1 * p2));
            Console.ReadKey();
        }

        public class Polynomial
        {
            private int[] Coefficients;

            public Polynomial(params int[] coefficients)
            {
                Coefficients = coefficients;
            }

            public static Polynomial operator *(Polynomial p1, Polynomial p2)
            {
                int[] result = new int[p1.Coefficients.Length + p2.Coefficients.Length - 1];

                for (int i = 0; i < p1.Coefficients.Length; i++)
                {
                    for (int j = 0; j < p2.Coefficients.Length; j++)
                    {
                        result[i + j] += p1.Coefficients[i] * p2.Coefficients[j];
                    }
                }

                return new Polynomial(result);
            }
            public override string ToString()
            {
                var terms = Coefficients.Select((coefficient, index) => {
                    if (coefficient == 0) return null;
                    if (index == 0) return $"{coefficient}";
                    return index == 1 ? $"{coefficient}x" : $"{coefficient}x^{index}";
                }).Where(term => term != null);

                return string.Join("+", terms.Reverse());
            }
        }
    }
}
