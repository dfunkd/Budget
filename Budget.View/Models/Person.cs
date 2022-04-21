using Budget.View.Models.Enums;

namespace Budget.View.Models
{
    public class Person
    {
		public int Id { get; set; }

		public string Name { get; set; }

		public PaycheckType PaycheckType { get; set; }

		public decimal PaycheckAmout { get; set; }
	}
}