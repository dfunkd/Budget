using System;

namespace Budget.View.Models
{
    public class Payment
    {
		public int Id { get; set; }
		public int BudgetPersonId { get; set; }
		public int DueDay { get; set; }

		public DateTime? PaymentDate { get; set; }

		public string Name { get; set; }

		public decimal Amount { get; set; }

		public bool IsPaidOff { get; set; } = false;
	}
}