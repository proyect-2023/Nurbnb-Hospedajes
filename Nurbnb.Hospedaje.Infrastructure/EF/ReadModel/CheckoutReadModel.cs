using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Infrastructure.EF.ReadModel
{
    [Table("checkout")]
    internal class CheckoutReadModel
    {
        [Key]
        [Column("checkoutId")]
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

       
    }
}
