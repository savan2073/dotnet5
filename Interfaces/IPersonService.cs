using FizzBuzzWeb.Models;

namespace FizzBuzzWeb.Interfaces
{
    public interface IPersonService
    {
        public FizzBuzz AddEntry(FizzBuzz newFizz);
        public IQueryable<FizzBuzz> GetAllEntries();
        public IQueryable<FizzBuzz> GetEntriesFromToday();
    }
}
