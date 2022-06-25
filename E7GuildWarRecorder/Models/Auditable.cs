using System;
namespace E7GuildWarRecorder.Models
{
	public abstract class Auditable
	{
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
	}
}

