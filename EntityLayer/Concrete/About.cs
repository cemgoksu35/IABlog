﻿#nullable disable

using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class About
	{
		[Key]
		public int AboutId { get; set; }

		public string AboutDetails1 { get; set; }

		public string AboutDetails2 { get; set; }

		public string AboutImage1 { get; set; }

		public string AboutImage2 { get; set; }

		public bool AboutStatus { get; set; }

		public string AboutMapLocation { get; set; }

	}
}
