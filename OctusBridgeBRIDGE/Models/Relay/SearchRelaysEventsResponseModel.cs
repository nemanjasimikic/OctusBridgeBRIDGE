namespace OctusBridgeBRIDGE.Models.Relay
{
#pragma warning disable CS1591
    public class SearchRelaysEventsResponseModel
    {
        public List<SearchRelaysHelperResponseModel> Relays { get; set; }
        public int TotalCount { get; set; }
    }

    public class SearchRelaysEventsHelperModel
    {
        public string Amount { get; set; }
        public int ChainId { get; set; }
        public string ContractAddress { get; set; }
        public string From { get; set; }
        public int Timestamp { get; set; }
        public string To { get; set; }
        public string TokenAddress { get; set; }
        public string TransferKind { get; set; }
    }
}
