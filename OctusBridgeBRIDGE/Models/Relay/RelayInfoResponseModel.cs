namespace OctusBridgeBRIDGE.Models.Relay
{
#pragma warning disable CS1591
    public class RelayInfoResponseModel
    {
        public List<EvmStatsModel> EvmStats { get; set; }
        public string FrozenStake { get; set; }
        public string LatestReward { get; set; }
        public int PotentialTotalConfirmed { get; set; }
        public int RelayTotalConfirmed { get; set; }
        public int SuccessfulRounds { get; set; }
        public int TotalCountRounds { get; set; }
        public string TotalReward { get; set; }
        public int UntilFrozen { get; set; }
    }
}
