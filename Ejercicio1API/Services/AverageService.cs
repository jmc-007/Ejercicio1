namespace Ejercicio1API.Services
{
    public class AverageService : IOperation
    {
        public decimal operation(decimal no1, decimal no2, decimal no3)
        {
            return (no1 + no2 + no3)/3;
        }
    }
}
