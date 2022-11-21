using System;
using Microsoft.EntityFrameworkCore;

namespace small_api.Models
{
	public class Website
	{
		public int Id { get; set; }

		public string? Name { get; set; }

		public string? Url { get; set; }

		public string? Category { get; set; }

		public string? Favicon { get; set; }
	}
}

