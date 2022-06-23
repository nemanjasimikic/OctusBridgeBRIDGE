namespace OctusBridgeBRIDGE.Models.Relay
{
#pragma warning disable CS1591
    public class RoundInfoResponseModel
    {
        public string AverageRelayStake { get; set; }
        public string AverageRelayStakeChange { get; set; }
        public string EthToTonUsdt { get; set; }
        public int EventsConfirmed { get; set; }
        public EvmStatsModel EvmStats { get; set; }
        public int RelaysCount { get; set; }
        public string RelaysCountChange { get; set; }
        public int RoundNum { get; set; }
        public string TonToEthUsdt { get; set; }
        public string TotalStake { get; set; }
        public string TotalStakeChange { get; set; }

    }
}
