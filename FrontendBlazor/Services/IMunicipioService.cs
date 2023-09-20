using FrontendBlazor.Models;

namespace FrontendBlazor.Services
{
    public interface IMunicipioService
    {
        Task<IEnumerable<Municipio>> GetAll();
        Task<IEnumerable<Municipio>> GetByDepartamento(int idDepto);
        Task<Municipio> GetById(int id);
    }
}
