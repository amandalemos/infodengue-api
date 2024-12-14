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

        // Ação para exibir o formulário (GET)
        public IActionResult Index()
        {
            return View();
        }




        [HttpPost]
        public async Task<IActionResult> ConsultarDadosApi(Relatorio filtro)
        {
            try
            {
                // Monta a URL da API de alertas com base nos filtros
                string apiUrl = $"https://info.dengue.mat.br/api/alertcity?" +
                                 $"geocode={filtro.CodigoIBGE}&" +  // Acessando a nova propriedade
                                 $"disease={filtro.Arbovirose}&" +  // Acessando a nova propriedade
                                 $"format=json&" +
                                 $"ew_start={filtro.SemanaInicio}&" +  // Acessando a nova propriedade
                                 $"ew_end={filtro.SemanaFim}&" +  // Acessando a nova propriedade
                                 $"ey_start={filtro.AnoInicio}&" +  // Acessando a nova propriedade
                                 $"ey_end={filtro.AnoFim}";  // Acessando a nova propriedade

                // Faz a requisição à API do servidor backend para evitar bloqueios CORS no frontend
                var response = await _httpClient.GetStringAsync(apiUrl);

                // Verificando o conteúdo da resposta antes de tentar deserializar
                if (string.IsNullOrWhiteSpace(response))
                {
                    return Json(new { success = false, message = "A resposta da API está vazia." });
                }

                // Log da resposta para verificar o que está sendo retornado pela API
                Console.WriteLine("Resposta da API: " + response);

                // Tenta deserializar o resultado diretamente como um array de objetos Relatorio
                var data = JsonConvert.DeserializeObject<List<Relatorio>>(response);

                // Se a consulta retornar dados, exibe no formulário, caso contrário, exibe uma mensagem
                if (data != null && data.Count > 0)
                {
                    return Json(new { success = true, data = data });
                }
                else
                {
                    return Json(new { success = false, message = "Nenhum relatório encontrado para os parâmetros fornecidos." });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = $"Erro ao consultar a API: {ex.Message}" });
            }
        }









    }
}
