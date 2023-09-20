using FrontendBlazor.Models;
using System.Text.Json;

namespace FrontendBlazor.Services
{
    public class DepartamentoService : IDepartamentoService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient client;
        public DepartamentoService(HttpClient httpClient)
        {
            client = httpClient;
        }

        public async Task<IEnumerable<Departamento>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await client.GetStringAsync($"Departamento");
            return JsonSerializer.Deserialize<IEnumerable<Departamento>>(resp, options);
        }
    }
}
