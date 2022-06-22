using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E7GuildWarRecorder.Models;

public class Match
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "VARCHAR(250)")]
    public string Result { get; set; }

    public int? Offense1Id { get; set; }

    public int? Offense2Id { get; set; }

    public int? Offense3Id { get; set; }

    public int? Defense1Id { get; set; }

    public int? Defense2Id { get; set; }

    public int? Defense3Id { get; set; }

    public string? Notes { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("Offense1Id")]
    [InverseProperty("Offense1Matches")]
    public virtual Hero? Offense1 { get; set; }

    [ForeignKey("Offense2Id")]
    [InverseProperty("Offense2Matches")]
    public virtual Hero? Offense2 { get; set; }

    [ForeignKey("Offense3Id")]
    [InverseProperty("Offense3Matches")]
    public virtual Hero? Offense3 { get; set; }

    [ForeignKey("Defense1Id")]
    [InverseProperty("Defense1Matches")]
    public virtual Hero? Defense1 { get; set; }

    [ForeignKey("Defense2Id")]
    [InverseProperty("Defense2Matches")]
    public virtual Hero? Defense2 { get; set; }

    [ForeignKey("Defense3Id")]
    [InverseProperty("Defense3Matches")]
    public virtual Hero? Defense3 { get; set; }
}

