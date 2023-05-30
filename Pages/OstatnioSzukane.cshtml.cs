using FizzBuzzWeb.Data;
using FizzBuzzWeb.Interfaces;
using FizzBuzzWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace FizzBuzzWeb.Pages
{
    [Authorize]
    public class OstatnioSzukaneModel : PageModel
    {
        private readonly IPersonService _personService;

        public OstatnioSzukaneModel(IPersonService personService)
        {
            _personService = personService;
        }
        public FizzBuzz FizzBuzz { get; set; }
        public IList<FizzBuzz> FizzBuzzes { get; set; }
        public void OnGet()
        {
            var wyswietl = _personService.GetAllEntries();
            FizzBuzzes = wyswietl.ToList();

        }
    }
}
