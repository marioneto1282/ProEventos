using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
         public int Id { get; set; }
        public string Local { get; set; }
        public DateTime? DataEvento { get; set; }

        [Required(ErrorMessage = "O Campo {0} é Obrigatório."),
        MinLength(3, ErrorMessage = "{0} deve ter no minimo 4 caracteres"),
        MaxLength(50, ErrorMessage = "{0} deve ter no maximo 50 caracteres")]
        public string Tema { get; set; }

        [Range(1, 120000, ErrorMessage = "{0} nao pode ser menor que 1 e maior que 120.000")]        
        public int QtdPessoas {get; set;}
        
        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$")]
        public string ImagemURL { get; set; }
        
        [Required(ErrorMessage="O campo {0} e Obrigatorio."),
        Phone(ErrorMessage="O campo {0} esta com numero invalido")]
        public string Telefone { get; set; }

        [Required(ErrorMessage="O campo {0} e Obrigatorio."),
        EmailAddress(ErrorMessage = ("O campo {0} necessita de um E-mail válido."))
        ]
        public string Email { get; set; }
        
        public IEnumerable<LoteDto> Lotes { get; set; }
        public IEnumerable<RedeSocialDto> RedesSociais { get; set; }
        public IEnumerable<PalestranteDto> PalestrantesEventos { get; set; }
    }
}