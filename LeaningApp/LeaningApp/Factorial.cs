namespace LeaningApp
{
    class Factorial
    {
        static Factorial _factorial;
        Factorial()
        {

        }
        public static Factorial GetInstance()
        {
            _factorial = _factorial == null ? new Factorial() : _factorial;
            return _factorial;
        }

        internal void PrintFactorial(int value)
        {
            var factotial = 1;
            for (int i = 1; i <= value; i++)
            {
                factotial = factotial * i;
            }

            Console.WriteLine($"Factorial is {factotial}");

        }
    }
}
