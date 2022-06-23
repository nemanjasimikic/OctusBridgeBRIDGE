namespace OctusBridgeBRIDGE.Models.Relay
{
    public class RelayRoundResponseModel
    {
#pragma warning disable CS1591
        public int EndTime { get; set; }
        public string EthToTonUsdt { get; set; }
        public int EventsConfirmed { get; set; }
        public string EventsConfirmedShare { get; set; }
        public List<EvmStatsModel> EvmStats { get; set; }
        public string RelayAddress { get; set; }
        public int RelayPlace { get; set; }
        public string RoundAddress { get; set; }
        public int RoundNum { get; set; }
        public string Stake { get; set; }
        public int StartTime { get; set; }
        public string TonToEthUsdt { get; set; }
        public int TotalRoundConfirms { get; set; }

    }
}
