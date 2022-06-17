using System.ComponentModel.DataAnnotations;

namespace E7GuildWarRecorder.Models;

public class Match
{
    [Key]
    public int id { get; set; }

    public bool result { get; set; }

    public string? offense1 { get; set; }

    public string? offense2 { get; set; }

    public string? offense3 { get; set; }

    public string? defense1 { get; set; }

    public string? defense2 { get; set; }

    public string? defense3 { get; set; }

    public string? notes { get; set; }
}

