using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using InfoDengue.Models;
using System.Collections.Generic;

namespace InfoDengue.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;

        public HomeController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> ConsultarDadosApi(string codigoIBGE, string arbovirose, int semanaInicio, int semanaFim, int anoInicio, int anoFim)
        {
            // Construindo a URL da API
            var url = $"https://info.dengue.mat.br/api/alertcity?geocode={codigoIBGE}&disease={arbovirose}&format=json&ew_start={semanaInicio}&ew_end={semanaFim}&ey_start={anoInicio}&ey_end={anoFim}";

            // Fazendo a requisição à API externa
            var response = await _httpClient.GetStringAsync(url);

            // Retornando a resposta da API
            return Content(response, "application/json");
        }







    }
}
