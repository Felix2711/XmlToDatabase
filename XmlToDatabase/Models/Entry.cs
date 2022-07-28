using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XmlToDatabase.Models
{
	public class Entry
	{
        [Required]
        [Key]
		public int pk { set; get; }
		[Required]
		[MaxLength(50)]
		public string Id { get; set; }
		[Required]
		[MaxLength(100)]
		public string Betrag { get; set; }
		[Required]
		[MaxLength(30)]
		public string Datum { get; set; }
		[Required]
		[MaxLength(500)]
		public string Name { get; set; }
		[Required]
		[MaxLength(50)]
		public string IBAN { get; set; }
		[MaxLength(50)]
		public string Referenz { get; set; }
		[MaxLength(250)]
		public string Info { get; set; }
	}
}
