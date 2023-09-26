using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TIc_Tac_Toe.Models
{
    public class user
    {
        [Display(Name = "ID")]
        public int userId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string userName { get; set; }




    }
}
