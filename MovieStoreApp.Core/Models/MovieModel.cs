using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MovieStoreApp.Core.Models
{
    public class MovieResponseModel
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "Varchar")]
        public string Title { get; set; }
        [MaxLength(1000)]
        [Column(TypeName = "Varchar")]
        public string Overview { get; set; }
        [MaxLength(300)]
        [Column(TypeName = "Varchar")]
        public string Tagline { get; set; }
        public decimal Budget { get; set; }
        public decimal Revenue { get; set; }
        [MaxLength(350)]
        [Column(TypeName = "Varchar")]
        public string ImdbUrl { get; set; }
        [MaxLength(350)]
        [Column(TypeName = "Varchar")]
        public string TmdbUrl { get; set; }
        [MaxLength(350)]
        [Column(TypeName = "Varchar")]
        public string PosterUrl { get; set; }
        [MaxLength(350)]
        [Column(TypeName = "Varchar")]
        public string BackdropUrl { get; set; }
        [MaxLength(20)]
        [Column(TypeName = "Varchar")]
        public string OriginalLanguage { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Runtime { get; set; }
        public decimal? Price { get; set; }


        public virtual IEnumerable<MovieCastModel> MovieCasts { get; set; }

    }
}
