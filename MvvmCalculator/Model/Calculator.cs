namespace MvvmCalculator.Model
{
    public class Calculator : ICalculator
    {
        public int Result { get; private set; }

        public void Add(int a, int b)
        {
            Result = a + b;
        }
        public void Subtract(int a, int b)
        {
            Result = a - b;
        }
        public void Multiply(int a, int b)
        {
            Result = a * b;
        }
        public void Divide(int a, int b)
        {
            Result = a / b;
        }
    }
}
