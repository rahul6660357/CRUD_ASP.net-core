using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DempApplication.Model
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength =3)]
        [Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Release Date")]
        public DateTime releaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string genric { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string Rating { get; set; }

    }
}
