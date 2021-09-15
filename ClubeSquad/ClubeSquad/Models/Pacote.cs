using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubeSquad.Models
{
    [Table("tb_pacote")]
    public class Pacote
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("id_cliente")]
        public int Id_cliente { get; set; }
        [Column("id_passeio")]
        public int Id_passeio { get; set; }
    }
}
