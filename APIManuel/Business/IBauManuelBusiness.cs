using APIManuel.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIManuel.Business
{
    public interface IBauManuelBusiness
    {
        Task<BrinquedoReadDTO> CreateBrinquedo(BrinquedoCreateDTO brinquedoDTO);
        Task<BrinquedoReadDTO> GetBrinquedo(Guid guid);
        Task<List<BrinquedoReadDTO>> GetAllBrinquedos();
    }
}
