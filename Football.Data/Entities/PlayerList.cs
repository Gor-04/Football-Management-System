//using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Football.Data.Entities;

public class PlayerList
{
    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    public DateTime DOB { get; set; }

    [Required]
    public string Nationality { get; set; }

    [Required]
    public string Position { get; set; }

    [Required]
    public string Team { get; set; }

    [Required]
    public int Price { get; set; }
   

}
