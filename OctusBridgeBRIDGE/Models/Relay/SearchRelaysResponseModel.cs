namespace OctusBridgeBRIDGE.Models.Relay
{
#pragma warning disable CS1591
    public class SearchRelaysResponseModel
    {
        public List<SearchRelaysHelperResponseModel> Relays { get; set; }
        public int TotalCount { get; set; }
    }

    public class SearchRelaysHelperResponseModel
    {
        public int CreatedAt { get; set; }
        public bool CurrentRound { get; set; }
        public int PotentialTotalConfirmed { get; set; }
        public string RelayAddress { get; set; }
        public int RelayTotalConfirmed { get; set; }
        public bool Slashed { get; set; }
        public string Stake { get; set; }
        public int SuccessfulRounds { get; set; }
        public int TotalRounds { get; set; }
    }
}
