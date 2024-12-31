using Microsoft.AspNetCore.Mvc;
using MyRapidApiProject.Models;
using Newtonsoft.Json;

namespace MyRapidApiProject.Controllers
{
    public class IMDBMovieControllerController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "x-rapidapi-key", "46a290a1c5msh0f4453a046d87edp17ebd2jsne5a9a7b2d538" },
        { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<IMDBMovieViewModel>>(body);
                return View(values?.ToList());
            }
        }
    }
}
