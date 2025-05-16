namespace CoinMarketCap.LatestQuotes
{
	using System;

	public class Data
	{
		public int active_cryptocurrencies { get; set; }
		public int total_cryptocurrencies { get; set; }
		public int active_market_pairs { get; set; }
		public int active_exchanges { get; set; }
		public int total_exchanges { get; set; }
		public double eth_dominance { get; set; }
		public double btc_dominance { get; set; }
		public double eth_dominance_yesterday { get; set; }
		public double btc_dominance_yesterday { get; set; }
		public double eth_dominance_24h_percentage_change { get; set; }
		public double btc_dominance_24h_percentage_change { get; set; }
		public double defi_volume_24h { get; set; }
		public double defi_volume_24h_reported { get; set; }
		public double defi_market_cap { get; set; }
		public double defi_24h_percentage_change { get; set; }
		public double stablecoin_volume_24h { get; set; }
		public double stablecoin_volume_24h_reported { get; set; }
		public double stablecoin_market_cap { get; set; }
		public double stablecoin_24h_percentage_change { get; set; }
		public double derivatives_volume_24h { get; set; }
		public double derivatives_volume_24h_reported { get; set; }
		public double derivatives_24h_percentage_change { get; set; }
		public int total_crypto_dex_currencies { get; set; }
		public int today_incremental_crypto_number { get; set; }
		public int past_24h_incremental_crypto_number { get; set; }
		public int past_7d_incremental_crypto_number { get; set; }
		public int past_30d_incremental_crypto_number { get; set; }
		public double today_change_percent { get; set; }
		public TrackedYearlyNumber tracked_yearly_number { get; set; }
		public Quote quote { get; set; }
		public DateTime last_updated { get; set; }
	}

	public class Quote
	{
		public USD USD { get; set; }
	}

	public class Root
	{
		public Status status { get; set; }
		public Data data { get; set; }
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

	public class TrackedYearlyNumber
	{
		public int maxIncrementalNumber { get; set; }
		public int minIncrementalNumber { get; set; }
		public DateTime maxIncrementalDate { get; set; }
		public DateTime minIncrementalDate { get; set; }
	}

	public class USD
	{
		public double total_market_cap { get; set; }
		public double total_volume_24h { get; set; }
		public double total_volume_24h_reported { get; set; }
		public double altcoin_volume_24h { get; set; }
		public double altcoin_volume_24h_reported { get; set; }
		public double altcoin_market_cap { get; set; }
		public double defi_volume_24h { get; set; }
		public double defi_volume_24h_reported { get; set; }
		public double defi_24h_percentage_change { get; set; }
		public double defi_market_cap { get; set; }
		public double stablecoin_volume_24h { get; set; }
		public double stablecoin_volume_24h_reported { get; set; }
		public double stablecoin_24h_percentage_change { get; set; }
		public double stablecoin_market_cap { get; set; }
		public double derivatives_volume_24h { get; set; }
		public double derivatives_volume_24h_reported { get; set; }
		public double derivatives_24h_percentage_change { get; set; }
		public double total_market_cap_yesterday { get; set; }
		public long total_volume_24h_yesterday { get; set; }
		public double total_market_cap_yesterday_percentage_change { get; set; }
		public double total_volume_24h_yesterday_percentage_change { get; set; }
		public DateTime last_updated { get; set; }
	}
}
