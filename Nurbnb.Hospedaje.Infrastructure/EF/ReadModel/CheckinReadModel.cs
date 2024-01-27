using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Infrastructure.EF.ReadModel
{
    [Table("checkin")]
    internal class CheckinReadModel
    {
        [Key]
        [Column("checkinId")]
        public Guid Id { get; set; }

        [Required]
        [Column("operacionId")]
        public Guid OperacionId { get; set; }

        [Required]
        [Column("fecha")]
        public DateTime Fecha { get; set; }

        [Required]
        [Column("hora")]
        [StringLength(5)]
        public string Hora { get; set; }

        [Column("instrucciones")]
        [StringLength(500)]
        [Required]
        public string Instrucciones { get; set; }
    }
}
