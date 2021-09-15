using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubeSquad.Models
{
    [Table("tb_pedido_loja")]
    public class Pedido_Loja
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("descricao")]
        public string Descricao { get; set; }
        [Column("id_produto_loja")]
        public int Id_produto_loja { get; set; }
        [Column("id_quarto")]
        public int Id_quarto { get; set; }
    }
}
