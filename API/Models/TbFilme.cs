using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("tb_filme")]
    public partial class TbFilme
    {
        [Key]
        [Column("id_filme", TypeName = "int(11)")]
        public int IdFilme { get; set; }
        [Column("nm_filme", TypeName = "varchar(100)")]
        public string NmFilme { get; set; }
        [Column("ds_categoria", TypeName = "varchar(100)")]
        public string DsCategoria { get; set; }
        [Column("dt_lancamento", TypeName = "date")]
        public DateTime? DtLancamento { get; set; }
    }
}
