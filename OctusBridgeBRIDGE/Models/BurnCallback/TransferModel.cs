namespace OctusBridgeBRIDGE.Models.BurnCallback
{
#pragma warning disable CS1591
    public class TransferModel
    {
        public string Amount { get; set; }
        public int BurnCallbackTimestampLt { get; set; }
        public int CallId { get; set; }
        public int ChainId { get; set; }
        public int CreatedAt { get; set; }
        public string CreditProcessorAddress { get; set; }
        public string EthUserAddress { get; set; }
        public string ProxyAddress { get; set; }
        public string? TonEventContractAddress { get; set; }
        public string UserAddress { get; set; }

    }
}
