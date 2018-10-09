using System;
using System.Collections.Generic;
using Gamely.Models;

namespace Gamely.ViewModels
{
	public class NewCustomerViewModel
	{
		public IEnumerable<MembershipType> MembershipTypes { get; set; }
		public Customer Customer { get; set; }
	}
}