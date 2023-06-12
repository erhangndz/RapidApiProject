using Microsoft.AspNetCore.Mvc;
using RapidApiProject.Models;
using System.Net.Http.Headers;

namespace RapidApiProject.Controllers
{
    public class CurrencyController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-converter-by-api-ninjas.p.rapidapi.com/v1/convertcurrency?have=USD&want=TRY&amount=100"),
                Headers =
    {
        { "X-RapidAPI-Key", "e782ab3024msh2e78af442950fd0p115136jsnc3dd0b8c5f54" },
        { "X-RapidAPI-Host", "currency-converter-by-api-ninjas.p.rapidapi.com" },
    },
            };
            using var response = await client.GetAsync("https://currency-converter-by-api-ninjas.p.rapidapi.com/v1/convertcurrency?have=USD&want=TRY&amount=100");
            if (response.IsSuccessStatusCode)
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                return View(body);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CurrencyViewModel model)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-converter-by-api-ninjas.p.rapidapi.com/v1/convertcurrency?have=USD&want=TRY&amount=100"),
                Headers =
    {
        { "X-RapidAPI-Key", "e782ab3024msh2e78af442950fd0p115136jsnc3dd0b8c5f54" },
        { "X-RapidAPI-Host", "currency-converter-by-api-ninjas.p.rapidapi.com" },
    },
            };
            using var response = await client.GetAsync("https://currency-converter-by-api-ninjas.p.rapidapi.com/v1/convertcurrency?have=&want=TRY&amount=100");
            if (response.IsSuccessStatusCode)
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                return View(body);
            }
            return View();
        }
    }
}



