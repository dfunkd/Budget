using System;

namespace Budget.View.Models
{
    public class Extraneous
    {
		public int Id { get; set; }
		public int BudgetPersonId { get; set; }

		public string Name { get; set; }

		public DateTime PaymentDate { get; set; }

		public decimal Amount { get; set; }
	}
}