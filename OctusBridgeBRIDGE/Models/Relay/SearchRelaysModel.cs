using System.ComponentModel.DataAnnotations;

namespace OctusBridgeBRIDGE.Models.Relay
{
#pragma warning disable CS1591
    public class SearchRelaysModel
    {
        [Required]
        public int? createdAtGe { get; set; }
        [Required]
        public int? createdAtLe { get; set; }
        [Required]
        public int limit { get; set; }
        [Required]
        public int offset { get; set; }
        [Required]
        public string? ordering { get; set; }
        [Required]
        public List<string> relayAddresses { get; set; }
        [Required]
        public int roundNum { get; set; }
        [Required]
        public string stakeGe { get; set; }
        [Required]
        public string stakeLe { get; set; }
        [Required]
        public string? transferContractAddress { get; set; }
    }
}
