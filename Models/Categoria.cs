using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace simulacro.Models
{
    [Table("t_categoria")]
    public class Categoria{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}
        public string nombre {get; set;}
        public ICollection<SolicitudCompra> solicitud {get; set;}
    }
}