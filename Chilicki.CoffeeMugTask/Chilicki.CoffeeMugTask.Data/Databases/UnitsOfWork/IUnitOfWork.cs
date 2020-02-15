using System.Threading.Tasks;

namespace Chilicki.CoffeeMugTask.Data.Databases.UnitsOfWork
{
    public interface IUnitOfWork
    {
        Task SaveAsync();
        void Dispose();
    }
}
