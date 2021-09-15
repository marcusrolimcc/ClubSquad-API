using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubeSquad.Models
{
    [Table("tb_passeio")]
    public class Passeio
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("preco")]
        public decimal Preco { get; set; }
        [Column("duracao")]
        public int Duracao { get; set; }
    }
}
