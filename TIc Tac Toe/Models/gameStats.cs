using System.ComponentModel.DataAnnotations;

namespace TIc_Tac_Toe.Models
{
    public class gameStats
    {
        [Required]
        public int player1_userid { get; set; }

        [Required]
        public int player2_userid { get; set; }

        [Required]
        public string moveNotation { get; set; }

        [RegularExpression("[OX]$")]
        public string winner { get;set; }

        [DataType(DataType.DateTime)]
        public DateTime timestamp { get; set; }
    }
}
