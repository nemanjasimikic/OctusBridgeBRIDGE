namespace OctusBridgeBRIDGE.Models.BurnCallback
{
#pragma warning disable CS1591
    public class BurnCallbackSearchModel
    {
        public string amountGe { get; set; }
        public string amountLe { get; set; }
        public long callId { get; set; }
        public long chainId { get; set; }
        public long createdAtGe { get; set; }
        public long createdAtLe { get; set; }
        public string creditProcessorAddress { get; set; }
        public string ethUserAddress { get; set; }
        public long limit { get; set; }
        public long offset { get; set; }
        public string ordering { get; set; }
        public string proxyAddress { get; set; }
        public string tonEventUserAddress { get; set; }

    }
}
