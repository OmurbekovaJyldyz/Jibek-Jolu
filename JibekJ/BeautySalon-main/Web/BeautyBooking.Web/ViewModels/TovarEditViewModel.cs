using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BeautyBooking.Web.ViewModels
{
	public class TovarEditViewModel
	{
		
			[Required]
			[Display(Name = "Id")]

			public int Id { get; set; }

			[Required]
			[Display(Name = "Name")]

			public string Name { get; set; }

			[Required]
			[Display(Name = "count")]

			public string count { get; set; }

			[Required]
			[Display(Name = "cost")]

			public string cost { get; set; }

			[Required]
			[Display(Name = "descrip")]

			public string descrip { get; set; }

			[Required]
			[Display(Name = "comment")]

			public string comment { get; set; }
		}
	}


