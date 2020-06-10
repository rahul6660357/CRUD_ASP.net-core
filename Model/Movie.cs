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
        public string Title { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Release Date")]
        public DateTime releaseDate { get; set; }
        public string genric { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal price { get; set; }

    }
}
