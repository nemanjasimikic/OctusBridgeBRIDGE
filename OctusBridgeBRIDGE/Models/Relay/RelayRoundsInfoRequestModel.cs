namespace OctusBridgeBRIDGE.Models.Relay
{
#pragma warning disable CS1591
    public class RelayRoundsInfoRequestModel
    {
        public int limit { get; set; }
        public int offset { get; set; }
        public string ordering { get; set; }
        public int roundNum { get; set; }
        public string userAddress { get; set; }
    }
}
