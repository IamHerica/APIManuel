using APIManuel.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIManuel.Models
{
    public class Brinquedo
    {
        [Key][Required]
        public int Id { get; set; }

        [Required]
        public Guid Guid { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string NomeTipo { get; set; }

        [Required]
        public Tipo Tipo { get; set; }

        [Required]
        public Tamanho Tamanho { get; set; }

        //Column é para dizer como será a coluna preco no banco de dados, com 6 casas e duas decimais
        [Required][Column(TypeName = "decimal(6,2)")]

        public decimal Preco { get; set; }


    }
}
