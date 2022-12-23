using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BeautyBooking.Web.ViewModels
{
	public class TovarCreateViewModel
	{
		[Required]
		[Display(Name = "First name")]
		[MaxLength(50)]
		public string Name { get; set; }

		[Required]
		[Display(Name = "Count")]
		[MaxLength(50)]
		public string count { get; set; }

		[Required]
		[Display(Name = "Cost")]
		[MaxLength(50)]
		public string cost { get; set; }

		[Required]
		[Display(Name = "Description")]
		[MaxLength(50)]
		public string descrip { get; set; }

		[Required]
		[Display(Name = "Comment")]
		[MaxLength(50)]
		public string comment { get; set; }

		[Required]
		[Display(Name = "Dolg")]
		[MaxLength(50)]
		public string dolg { get; set; }


		[Required]
		[Display(Name = "Shir")]
		[MaxLength(50)]
		public string shir { get; set; }
	}
}
