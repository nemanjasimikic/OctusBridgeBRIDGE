namespace OctusBridgeBRIDGE.Models.Relay
{
#pragma warning disable CS1591
    public class RelayRoundsInfoResponseModel
    {
        public List<RelayRoundsInfoHelperModel> Relays { get; set; }
        public int TotalCount { get; set; }
    }
    public class RelayRoundsInfoHelperModel
    {
        public int EndTime { get; set; }
        public int EventsConfirmed { get; set; }
        public string EventsShare { get; set; }
        public string FromTonUsdt { get; set; }
        public string FromTonUsdtShare { get; set; }
        public string RoundAddress { get; set; }
        public int RoundNum { get; set; }
        public string Stake { get; set; }
        public int StartTime { get; set; }
        public string ToTonUsdt { get; set; }
        public string ToTonUsdtShare { get; set; }

    }
}
