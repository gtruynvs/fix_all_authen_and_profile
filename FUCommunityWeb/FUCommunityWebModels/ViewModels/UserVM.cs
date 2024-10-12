﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuCommunityWebModels.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace FuCommunityWebModels.ViewModels
{
    public class UserVM
    {
		public ApplicationUser User { get; set; }
		public List<Enrollment> Enrollments { get; set; }
		public List<Post> Post { get; set; }
		//public string FullName { get; set; }
		//public string Bio { get; set; }
		//public string Address { get; set; }
		//public string Gender { get; set; }
		//[ValidateNever]
		//public DateTime DOB { get; set; }
		//public string PhoneNumber { get; set; }
		//[ValidateNever]
		//public string Description { get; set; }
		//[ValidateNever]
		//public string AvatarImage { get; set; }
	}
}
