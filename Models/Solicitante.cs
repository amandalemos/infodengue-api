using System;
using System.ComponentModel.DataAnnotations;

namespace InfoDengue.Models
{
    public class Solicitante
    {
        public int id { get; set; }  // Chave primária auto incremento

        [Required]
        [StringLength(255)]
        public string solicitante { get; set; } = string.Empty;  // Nome do solicitante inicializado com valor padrão

        [Required]
        public string cpf { get; set; } = string.Empty;  // CPF do solicitante inicializado com valor padrão

        [DataType(DataType.DateTime)]
        public DateTime register_date { get; set; } = DateTime.Now;  // Data de registro inicializada com a data atual

        [Required]
        public string ip { get; set; } = string.Empty;  // IP do solicitante inicializado com valor padrão
    }
}
