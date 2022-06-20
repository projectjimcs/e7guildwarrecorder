using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E7GuildWarRecorder.Models;

public class Hero
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "VARCHAR(250)")]
    public string Key { get; set; }

    [Column(TypeName = "VARCHAR(250)")]
    public string Name { get; set; }

    [Column(TypeName = "VARCHAR(250)")]
    public string Icon { get; set; }
}
