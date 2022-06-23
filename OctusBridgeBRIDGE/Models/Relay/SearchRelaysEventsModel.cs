using System.ComponentModel.DataAnnotations;

namespace OctusBridgeBRIDGE.Models.Relay
{
#pragma warning disable CS1591
    public class SearchRelaysEventsModel
    {
        [Required]
        public string amountGe { get; set; }
        [Required]
        public string amountLe { get; set; }
        [Required]
        public int? chainId { get; set; }
        [Required]
        public string? ethUserAddress { get; set; }
        [Required]
        public int limit { get; set; }
        [Required]
        public int offset { get; set; }
        [Required]
        public string? ordering { get; set; }
        [Required]
        public string? relayAddress { get; set; }
        [Required]
        public int? roundNum { get; set; }
        [Required]
        public int? timestampGe { get; set; }
        [Required]
        public int? timestampLe { get; set; }
        [Required]
        public string? tokenAddress { get; set; }
        [Required]
        public string? tonUserAddress { get; set; }
        [Required]
        public string? transferContractAddress { get; set; }
        [Required]
        public string? transferKind { get; set; }
    }
}
