using APIManuel.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIManuel.DTOs
{
    //Retorna o que o usuario precisa visualizar de fato
    public class BrinquedoReadDTO
    {
        public Guid Guid { get; set; }
        public string Nome { get; set; }

        public string NomeTipo { get; set; }

        public Tipo Tipo { get; set; }

        public Tamanho Tamanho { get; set; }

        public decimal Preco { get; set; }
    }
}
