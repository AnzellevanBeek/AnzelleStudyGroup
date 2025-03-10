using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnzelleStudyGroup.Models
{
	public class StudentModel
	{
		[Display(Name = "STUDENT NUMBER")]
		public string StudentNumber { get; set; }

        [Display(Name = "NAME")]
        public string Name { get; set; }

        [Display(Name = "SURNAME")]
        public string Surname { get; set; }

        [Display(Name = "EMAIL ADDRESS")]
        public string EmailAddress { get; set; }

        [Display(Name = "Link to personal page")]
        public string myLink { get; set; }
    }
}