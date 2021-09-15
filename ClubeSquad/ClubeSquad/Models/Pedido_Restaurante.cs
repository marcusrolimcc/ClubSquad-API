using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubeSquad.Models
{
    [Table("tb_pedido_restaurante")]
    public class Pedido_Restaurante
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
        [Column("validade")]
        public DateTime Validade { get; set; }
        [Column("id_restaurante")]
        public int Id_restaurante { get; set; }
    }
}
