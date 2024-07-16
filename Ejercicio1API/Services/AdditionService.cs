namespace Ejercicio1API.Services
{

    public class AdditionService : IOperation
    {
        public decimal operation(decimal no1, decimal no2, decimal no3)
        {
            return no1 + no2 + no3;
        }

    }
}
