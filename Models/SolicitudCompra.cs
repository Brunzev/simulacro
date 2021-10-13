using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace simulacro.Models
{
    [Table("t_solicitud")]
    public class SolicitudCompra{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id{get; set;}
        public string nombre{get; set;}
        public string foto{get; set;}
        public string descripcion{get; set;}
        public decimal precio{get; set;}
        public string celular{get; set;}
        public DateTime fecha{get; set;}
        public string lugar{get; set;}
        public string comprador{get; set;}
        public Categoria categoria {get; set;}

        public SolicitudCompra(){
            this.fecha = new DateTime();
        }
    }
}