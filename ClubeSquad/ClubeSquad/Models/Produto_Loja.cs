using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubeSquad.Models
{
    [Table("tb_produto_loja")]
    public class Produto_Loja
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("descricao")]
        public string Descricao { get; set; }
        [Column("valor")]
        public decimal Valor { get; set; }
        [Column("quantidade")]
        public int Quantidade { get; set; }
        [Column("id_loja")]
        public int Id_loja { get; set; }
    }
}
