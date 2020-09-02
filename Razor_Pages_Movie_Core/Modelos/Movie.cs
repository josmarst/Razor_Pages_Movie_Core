using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Razor_Pages_Movie_Core.Modelos
{

    public class Movie
    {
        public int ID { get; set; }

        [Display(Name = "Título"), StringLength(60, MinimumLength = 3), Required(ErrorMessage = "Campo Obrigatório")]
        public string Title { get; set; }

        [Display(Name = "Data Lançamento"), DataType(DataType.Date), Required(ErrorMessage ="Campo Obrigatório")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Gênero"), StringLength(30), Required(ErrorMessage = "Campo Obrigatório")]
        //  [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string Genre { get; set; }

        [Display(Name = "Preço")]
        [Range(1, 100), DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)"), Required(ErrorMessage = "Campo Obrigatório")]
        public decimal Price { get; set; }

        [Display(Name = "Nota")]
        //  [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5), Required(ErrorMessage = "Campo Obrigatório")]
        public string Rating { get; set; }
    }
}
