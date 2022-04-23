using ClasesPA.Models;

namespace ClasesPA.Services
{
    public interface IEnrrollements
    {
        IEnumerable<Enrrollements> GetInnerJoin();
    }
}
