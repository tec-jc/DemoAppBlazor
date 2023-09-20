using FrontendBlazor.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace FrontendBlazor.Services
{
    public class MunicipioService : IMunicipioService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient client;
        public MunicipioService(HttpClient httpClient)
        {
            client = httpClient;
        }

        //configurar las opciones del Serializador
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async Task<IEnumerable<Municipio>> GetAll()
        {
            string resp = await client.GetStringAsync($"Municipio");
            return JsonSerializer.Deserialize<IEnumerable<Municipio>>(resp, options);
        }

        public async Task<IEnumerable<Municipio>> GetByDepartamento(int idDepto)
        {
            var resp = await client.PostAsJsonAsync($"Municipio/Buscar", new { idDepartamento = idDepto });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Municipio>>(respString, options);
        }

        public async Task<Municipio> GetById(int id)
        {
            string resp = await client.GetStringAsync($"Municipio/{id}");
            return JsonSerializer.Deserialize<Municipio>(resp, options);
        }
    }
}
