using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubeSquad.Models
{
    [Table("tb_reserva")]
    public class Reserva
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("descricao")]
        public string Descricao { get; set; }
        [Column("data_entrada")]
        public DateTime Data_entrada { get; set; }
        [Column("data_saida")]
        public DateTime Data_saida { get; set; }
        [Column("id_cliente")]
        public int Id_cliente { get; set; }
        [Column("id_quarto")]
        public int Id_quarto { get; set; }
    }
}
