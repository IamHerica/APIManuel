using APIManuel.Data;
using APIManuel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIManuel.Repository
{
    public class BauManuelRepository : IBauManuelRepository
    {
        public async Task<Brinquedo> CreateBrinquedo(Brinquedo brinquedo)
        {
            //Isso aqui permite o acesso ao banco de dados sqlite
            await using var _context = new BauManuelContext();

            //Adicionar o brinquedo de forma assincrona no banco de dados
            await _context.AddAsync(brinquedo);

            //Salvar as alterações no banco de dados
            await _context.SaveChangesAsync();

            //retornar exatamente o que a pessoa pediu para adicionar. dentro do banco fica uma cópia do objeto
            return brinquedo;
        }

        public Task DeleteBrinquedo(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Brinquedo> ReadBrinquedo(Guid guid)
        {
            await using var _context = new BauManuelContext();

            /*
                var brinquedolist = _context.Brinquedos.tolist();

                foreach (var brinquedo in brinquedolist)
                {
                    if (brinquedo.guid == guid)
                    {
                        return brinquedo;
                     }
                }
             */
            //O comentario acima é uma forma que explicar o lambda a seguir:
            return _context.Brinquedos.FirstOrDefault(brinquedo => brinquedo.Guid == guid);

        }

        public async Task<List<Brinquedo>> ReadAllBrinquedos()
        {
            await using var _context = new BauManuelContext();
            return _context.Brinquedos.ToList();
        }
         
        public Task<Brinquedo> UpdateBrinquedo(Brinquedo brinquedo)
        {
            throw new NotImplementedException();
        }
    }
}
