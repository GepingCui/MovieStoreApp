using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MovieStoreApp.Core.Entity
{
    public class Review
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
        [MaxLength(2000)]
        [Column(TypeName = "Varchar")]
        public string? ReviewText { get; set; }

        public decimal Rating { get; set; }
    }
}
