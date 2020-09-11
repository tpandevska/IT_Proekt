using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_Proekt_173032.Models
{
    public class Tickets {

        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Име")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Тип")]
        public string Tip { get; set; }
        [Required]
        [Display(Name = "Цена")]
        [Range(0, 10000, ErrorMessage = "Внеси број помеѓу 0 и 10000")]
        public int Price { get; set; }
        [Required]
        [Display(Name = "Локација")]
        public string Location { get; set; }
        [Required]
        [Display(Name = "Датум")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [Required]
        [Display(Name = "Време")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Time { get; set; }
        [Display(Name = "Информации за настанот")]
        public string Info { get; set; }
        [Required]
        [Display(Name = "URL од Слика")]
        public string ImgUrl { get; set; }
        [Display(Name = "Број на карти")]
        [Required]
        public int numberTickets { get; set; }
        public Tickets()
        {

        }
        
    }
}