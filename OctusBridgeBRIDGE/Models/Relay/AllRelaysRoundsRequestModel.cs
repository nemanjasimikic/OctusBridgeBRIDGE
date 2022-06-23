using System.ComponentModel.DataAnnotations;

namespace OctusBridgeBRIDGE.Models.Relay
{
#pragma warning disable CS1591
    public class AllRelaysRoundsRequestModel
    {
        [Required]
        public int limit { get; set; }
        [Required]
        public int offset { get; set; }
        [Required]
        public string ordering { get; set; }
        [Required]
        public string userAddress { get; set; }

    }
}
