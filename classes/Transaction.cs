using System;

namespace classes
{
	public class Transaction
	{
		public decimal Amount { get; }
		public DateTime Date { get; }
		public string Notes { get; }

		// constructor called by new
		public Transaction(decimal amount, DateTime date, string note)
		{
			this.Amount = amount;
			this.Date = date;
			this.Notes = note;
		}
	}
}
