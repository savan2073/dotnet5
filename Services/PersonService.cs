using FizzBuzzWeb.Data;
using FizzBuzzWeb.Interfaces;
using FizzBuzzWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzWeb.Services
{
    public class PersonService : IPersonService
    {
        private readonly ApplicationDbContext _context;
        public PersonService(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<FizzBuzz> fizzBuzzes { get; set; }
        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }
        public FizzBuzz AddEntry(FizzBuzz newFizz)
        {
            _context.FizzBuzz.Add(newFizz);
            _context.SaveChanges();
            return FizzBuzz;
        }

        public IQueryable<FizzBuzz> GetAllEntries()
        {
            var wyswietl = (from FizzBuzz in _context.FizzBuzz orderby FizzBuzz.Date descending select FizzBuzz);
            return wyswietl;
        }

        public IQueryable<FizzBuzz> GetEntriesFromToday()
        {
            var wyswietl = (from FizzBuzz in _context.FizzBuzz where DateTime.Compare(FizzBuzz.Date, DateTime.Today) == 1 orderby FizzBuzz.Date descending select FizzBuzz).Take(20);
            return wyswietl;
        }
    }
}
