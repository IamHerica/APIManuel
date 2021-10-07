using APIManuel.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIManuel.DTOs
{
    //DTO = DATA TRANSFER OBJECT
    // Objeto que vai transferir dados de uma classe para outra
    public class BrinquedoCreateDTO
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string NomeTipo { get; set; }

        [Required]
        public Tipo Tipo { get; set; }

        [Required]
        public Tamanho Tamanho { get; set; }

        [Required]
        public decimal Preco { get; set; }

    }
}
