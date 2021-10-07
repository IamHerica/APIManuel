using APIManuel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIManuel.Repository
{
    public interface IBauManuelRepository
    {
        //é uma task porque é assincrono, dividindo as tasks
        Task<Brinquedo> CreateBrinquedo(Brinquedo brinquedo);
        Task<Brinquedo> ReadBrinquedo(Guid guid);
        Task<List<Brinquedo>> ReadAllBrinquedos();
        Task<Brinquedo> UpdateBrinquedo(Brinquedo brinquedo);
        //é somente uma task pq não tem nenhum retorno, já que estamos excluindo o brinquedo
        Task DeleteBrinquedo(int id);

    }
}
