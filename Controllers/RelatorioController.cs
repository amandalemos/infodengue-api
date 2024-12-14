using InfoDengue.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class RelatorioController : Controller
{
    private readonly HttpClient _httpClient;

    public RelatorioController(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // Ação para exibir o formulário e processar os dados
    [HttpGet]
    public IActionResult Index()
    {
        return View(); // Exibe o formulário vazio para o usuário preencher
    }

}
