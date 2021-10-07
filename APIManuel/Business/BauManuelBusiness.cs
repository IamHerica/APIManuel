using APIManuel.DTOs;
using APIManuel.Models;
using APIManuel.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIManuel.Business
{
    public class BauManuelBusiness : IBauManuelBusiness
    {
        private readonly IBauManuelRepository _bauManuelRepository;

        public BauManuelBusiness(IBauManuelRepository bauManuelRepository)
        {
            _bauManuelRepository = bauManuelRepository;
        }

        public async Task<BrinquedoReadDTO> CreateBrinquedo(BrinquedoCreateDTO brinquedoDTO)
        {
            var brinquedo = new Brinquedo
            {
                Nome = brinquedoDTO.Nome,
                NomeTipo = brinquedoDTO.NomeTipo,
                Tamanho = brinquedoDTO.Tamanho,
                Tipo = brinquedoDTO.Tipo,
                Preco = brinquedoDTO.Preco,
                Guid = Guid.NewGuid()
            };


            var RetornoBrinquedo = await _bauManuelRepository.CreateBrinquedo(brinquedo);

            return new BrinquedoReadDTO
            {
                Nome = RetornoBrinquedo.Nome,
                NomeTipo = RetornoBrinquedo.NomeTipo,
                Tamanho = RetornoBrinquedo.Tamanho,
                Tipo = RetornoBrinquedo.Tipo,
                Preco = RetornoBrinquedo.Preco,
                Guid = RetornoBrinquedo.Guid
            };
        }

        public async Task<List<BrinquedoReadDTO>> GetAllBrinquedos()
        {
            var listaDeBrinquedosDoBancoDeDados = await _bauManuelRepository.ReadAllBrinquedos();

            var listaDeBrinquedosParaSeremRetornados = new List<BrinquedoReadDTO>();

            foreach (var brinquedo in listaDeBrinquedosDoBancoDeDados)
            {
                var objetoDeTransferenciaDeDado = new BrinquedoReadDTO
                {
                    Guid = brinquedo.Guid,
                    Nome = brinquedo.Nome,
                    Tamanho = brinquedo.Tamanho,
                    NomeTipo = brinquedo.NomeTipo,
                    Tipo = brinquedo.Tipo,
                    Preco = brinquedo.Preco
                };
                listaDeBrinquedosParaSeremRetornados.Add(objetoDeTransferenciaDeDado);
            }
            

            return listaDeBrinquedosParaSeremRetornados;
        }

        public async Task<BrinquedoReadDTO> GetBrinquedo(Guid guid)
        {
            var RetornoGet = await _bauManuelRepository.ReadBrinquedo(guid);

            if (RetornoGet == default)
                return default;

            return new BrinquedoReadDTO
            {
                Guid = RetornoGet.Guid,
                Nome = RetornoGet.Nome,
                Preco = RetornoGet.Preco,
                Tipo = RetornoGet.Tipo,
                NomeTipo = RetornoGet.NomeTipo,
                Tamanho = RetornoGet.Tamanho
            };
        }

       
    }
}
