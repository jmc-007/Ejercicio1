namespace Ejercicio1API.Controller
{

    public class Ejercicio1Controller
    {
        private IOperation _operation;
        public Ejercicio1Controller(IOperation operation)
        {
            _operation = operation;
        }

        public decimal Result(decimal no1, decimal no2, decimal no3)
        {
            return _operation.operation(no1, no2, no3);
        }

    }
}
