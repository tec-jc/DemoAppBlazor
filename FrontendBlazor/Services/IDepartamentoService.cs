using FrontendBlazor.Models;

namespace FrontendBlazor.Services
{
    public interface IDepartamentoService
    {
        Task<IEnumerable<Departamento>> GetAll();
    }
}
