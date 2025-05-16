namespace CoinMarketCap.Categories
{
	using System;

	public class Data
	{
		public string id { get; set; }
		public string name { get; set; }
		public string title { get; set; }
		public string description { get; set; }
		public int num_tokens { get; set; }
		public double avg_price_change { get; set; }
		public double market_cap { get; set; }
		public double market_cap_change { get; set; }
		public double volume { get; set; }
		public double volume_change { get; set; }
		public DateTime last_updated { get; set; }
	}

	public class CategoryRoot
	{
		public Status status { get; set; }
		public Data data { get; set; }
	}

	public class CategoriesRoot
	{
		public Status status { get; set; }
		public Data[] data { get; set; }
	}

	public class Status
	{
		public DateTime timestamp { get; set; }
		public int error_code { get; set; }
		public object error_message { get; set; }
		public int elapsed { get; set; }
		public int credit_count { get; set; }
		public object notice { get; set; }
	}

	public class DataCollection
	{
		public Data[] data { get; set; }
	}
}
