using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E7GuildWarRecorder.Models;

[Table("hero")]
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

    public virtual ICollection<Match> Offense1Matches { get; set; }

    public virtual ICollection<Match> Offense2Matches { get; set; }

    public virtual ICollection<Match> Offense3Matches { get; set; }

    public virtual ICollection<Match> Defense1Matches { get; set; }

    public virtual ICollection<Match> Defense2Matches { get; set; }

    public virtual ICollection<Match> Defense3Matches { get; set; }
}
